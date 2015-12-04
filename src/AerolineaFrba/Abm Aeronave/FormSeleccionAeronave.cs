using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormSeleccionAeronave : Form
    {
        public FormSeleccionAeronave()
        {
            InitializeComponent();

            DataRow filaExtraServicio;
            var dtTipoServicio = new gdDataBase().GetDataWithParameters("ÑUFLO.TiposDeServicio", null);

            filaExtraServicio = dtTipoServicio.NewRow();
            filaExtraServicio["Tipo Servicio"] = "Cualquiera";
            dtTipoServicio.Rows.InsertAt(filaExtraServicio, 0);

            comboBoxTipoServicio.DataSource = dtTipoServicio;
            comboBoxTipoServicio.DisplayMember = dtTipoServicio.Columns[0].ColumnName;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            consultarConFiltro();
        }

        private void consultarConFiltro()
        {
            Boolean bajaVidaUtil = false, bajaFueraServicio = false;

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            if (checkBoxPorVidaUtil.Checked)
                bajaVidaUtil = true;
            if (checkBoxBajaPorServicio.Checked)
                bajaFueraServicio = true;

            if (textBoxMatricula.Text.Trim() != "")
                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            if (textBoxModelo.Text.Trim() != "")
                camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            if (textBoxFabricante.Text.Trim() != "")
                camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            if (comboBoxTipoServicio.Text.Trim() != "Cualquiera")
                camposValores.Add("tipo_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex).ToString(), SqlDbType.Int));
            if (textBoxCapacidadEncomiendas.Text.Trim() != "")
                camposValores.Add("capacidad_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            if (bajaFueraServicio)
                camposValores.Add("baja_fuera_servicio", new gdDataBase.ValorTipo(Convert.ToString(bajaFueraServicio), SqlDbType.Bit));
            if (bajaVidaUtil)
                camposValores.Add("baja_vida_util", new gdDataBase.ValorTipo(Convert.ToString(bajaVidaUtil), SqlDbType.Bit));
            if (textBoxCantidadButacas.Text.Trim() != "")
                camposValores.Add("cantidad_butacas", new gdDataBase.ValorTipo(textBoxCantidadButacas.Text, SqlDbType.Int));
            camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltroAeronave", camposValores);

            //dataGridViewAeronave.DataSource = ds;
            bindingAeronaves.DataSource = ds;
            dataGridViewAeronave.DataSource = bindingAeronaves;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCantidadButacas.Clear();
            textBoxCapacidadEncomiendas.Clear();
            textBoxFabricante.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();
            comboBoxTipoServicio.Text = "";
            checkBoxBajaPorServicio.Checked = false;
            checkBoxPorVidaUtil.Checked = false;
        }

        private void dataGridViewAeronave_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAeronave.SelectedRows.Count == 1)
            {
                btnModificarAeronave.Enabled = true;
                btnBajaFueraServicio.Enabled = true;
                btnBajaVidaUtil.Enabled = true;
                dateTimePicker1.Enabled = true;
                if (dataGridViewAeronave.SelectedRows[0].Cells[7].Value.ToString() != "")
                    btnBajaFueraServicio.Enabled = false;
                if (dataGridViewAeronave.SelectedRows[0].Cells[8].Value.ToString() != "0")
                    btnBajaVidaUtil.Enabled = false;
            }
            else
            {
                btnModificarAeronave.Enabled = false;
                btnBajaVidaUtil.Enabled = false;
                btnBajaFueraServicio.Enabled = false;
                dateTimePicker1.Enabled = false;
            }

        }

        private void btnModificarAeronave_Click(object sender, EventArgs e)
        {
            //abrir el formulario de alta con todos los datos de la aeronave seleccionada actualmente
            DataGridViewRow filaSeleccionada = dataGridViewAeronave.Rows[dataGridViewAeronave.SelectedRows[0].Index];

            FormAltaAeronave faa = new FormAltaAeronave();
            faa.Show();
            faa.setFilaDeAeronaveSeleccionada(filaSeleccionada);
        }

        private void btnBajaVidaUtil_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridViewAeronave.Rows[dataGridViewAeronave.SelectedRows[0].Index];

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));

            errorMensaje.Add(60004, "La nave ya se encuentra fuera de su vida util");

            var ejecucion = new SPPureExec("ÑUFLO.ValidarAeronaveActiva", camposValores, errorMensaje);

            if (!ejecucion.huboError())
            {

                int cantidadViajesPendientes = -1;
                /*if (dt.Rows.Count > 0)
                    cantidadViajesPendientes = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                */
                if (cantidadViajesPendientes > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea Reprogramar los " + cantidadViajesPendientes
                        + " pasajes/encomiendas asociados a la Aeronave dada en baja? (De elejir no, simplemente se cancelarán esos viajes",
                        "Baja por vida útil de Aeronave con viajes asignados", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // fecha inicio la considero como la fecha actual
                        camposValores.Clear();
                        camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
                        camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                        errorMensaje.Clear();
                        errorMensaje.Add(60005, "No se pudieron reemplazar todos los viajes");

                        new gdDataBase().Exec("ÑUFLO.ReemplazarAeronavePara", camposValores, errorMensaje,
                            "Pasajes/Encomiendas de la aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " reprogramadas exitosamente");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // fecha inicio la considero como la fecha actual
                        camposValores.Clear();
                        camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
                        camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                        new gdDataBase().Exec("ÑUFLO.CancelarPasajesYEncomiendasDe", camposValores, null,
                            "Pasajes de aronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " cancelados correctamente");
                    }
                }

                camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
                camposValores.Add("fecha", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                errorMensaje.Add(60004, "La Aeronave ya está fuera por vida útil");

                var dt = new gdDataBase().ExecAndGetData("ÑUFLO.BajaPorVidaUtil", camposValores, errorMensaje, "Baja por vida útil de Aeronave exitosa");

                consultarConFiltro();
            }
        }

        private void btnBajaFueraServicio_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridViewAeronave.Rows[dataGridViewAeronave.SelectedRows[0].Index];

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
            camposValores.Add("fecha_fuera", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
            camposValores.Add("fecha_rein", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            errorMensaje.Add(60003, "La Aeronave ya se encuentra en mantenimiento");

            var dt = new gdDataBase().ExecAndGetData("ÑUFLO.BajaFueraDeServicio", camposValores, errorMensaje, 
                "Baja por fuerda de servicio de Aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " exitosa");

            int cantidadViajesPendientes = -1;
            if (dt.Rows.Count > 0)
                cantidadViajesPendientes = Convert.ToInt32(dt.Rows[0].ItemArray[0]);

            if (cantidadViajesPendientes > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Desea Reprogramar los " + cantidadViajesPendientes
                    + " pasajes/encomiendas asociados a la Aeronave dada en baja? (De elejir no, simplemente se cancelarán esos viajes",
                    "Baja por vida útil de Aeronave con viajes asignados", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // fecha inicio la considero como la fecha actual
                    camposValores.Clear();
                    camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
                    camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
                    camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

                    errorMensaje.Clear();
                    errorMensaje.Add(60005, "No se pudieron reemplazar todos los viajes");

                    new gdDataBase().Exec("ÑUFLO.ReemplazarAeronavePara", camposValores, errorMensaje,
                        "Pasajes/Encomiendas de la aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " reprogramadas exitosamente");
                }
                else if (dialogResult == DialogResult.No)
                {
                    // fecha inicio la considero como la fecha actual
                    camposValores.Clear();
                    camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
                    camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
                    camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

                    new gdDataBase().Exec("ÑUFLO.CancelarPasajesYEncomiendasDe", camposValores, null,
                        "Pasajes de aronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " cancelados correctamente");
                }
            }

            consultarConFiltro();
        }

        private void checkBoxBajaPorServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBajaPorServicio.Checked)
                checkBoxPorVidaUtil.Enabled = false;
            else
                checkBoxPorVidaUtil.Enabled = true;
        }

        private void checkBoxPorVidaUtil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPorVidaUtil.Checked)
                checkBoxBajaPorServicio.Enabled = false;
            else
                checkBoxBajaPorServicio.Enabled = true;
        }
    }
}
