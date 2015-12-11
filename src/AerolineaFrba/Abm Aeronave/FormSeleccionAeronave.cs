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

        public void consultarConFiltro()
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

            deshabilitarModifBaja();
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

        private void deshabilitarModifBaja()
        {
            btnModificarAeronave.Enabled = false;
            btnBajaVidaUtil.Enabled = false;
            btnBajaFueraServicio.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private DataGridViewRow getFilaSeleccionada()
        {
            DataGridViewRow filaSeleccionada = null;

            filaSeleccionada = dataGridViewAeronave.CurrentRow;

            return filaSeleccionada;
        }

        private void btnModificarAeronave_Click(object sender, EventArgs e)
        {
            int cantidadVentanilla, cantidadPasillo;

            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            errorMensaje.Add(60017, "No se puede modificar una aeronave con viajes pendientes");

            camposValores.Clear();
            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            
            var ejecucion = new gdDataBase().Exec("ÑUFLO.ValidarAeronavesSinViajes", camposValores, errorMensaje, null);
            
            if (!ejecucion.huboError())
            {
                FormAltaAeronave faa = new FormAltaAeronave();

                faa.setPadre(this);
                faa.setFilaDeAeronaveSeleccionada(filaSeleccionada);

                var ds = new gdDataBase().ExecAndGetDataSet("ÑUFLO.CantidadButacasVentanillaPasillo", camposValores, null);
                cantidadVentanilla = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                cantidadPasillo = Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[0].ToString());

                faa.setButacasVentanilla(cantidadVentanilla);
                faa.setButacasPasillo(cantidadPasillo);

                faa.Show();
            }
        }
        //cantidadButacasVentanillaPasillo

        private void btnBajaVidaUtil_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            errorMensaje.Add(60003, "La nave ya se encuentra en mantenimiento");
            errorMensaje.Add(60004, "La nave ya se encuentra fuera de su vida util");
            errorMensaje.Add(62004, "La fecha de reincorporacion debe ser mayor a la fecha de hoy");

            var ejecucion = new SPExecGetData("ÑUFLO.ValidarAeronaveActiva", camposValores, errorMensaje);

            DataTable dt = (DataTable)ejecucion.Exec();

            if (!ejecucion.huboError())
            {
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
                        camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
                        camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                        errorMensaje.Clear();
                        errorMensaje.Add(60005, "No se pudieron reemplazar todos los viajes");

                        var ejecucionReemplazo = new SPPureExec("ÑUFLO.ReemplazarAeronavePara", camposValores, errorMensaje,
                            "Pasajes/Encomiendas de la aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " reprogramadas exitosamente");

                        ejecucionReemplazo.Exec();

                        if (ejecucionReemplazo.huboError())
                        {
                            DialogResult dialogResultReemplazo = MessageBox.Show("Desea generar una nueva aeronave para poder reprogramar los viajes?\n En caso de seleccionar no se cancelaran los mismos",
                        "Agregar nueva aeronave para reprogramar", MessageBoxButtons.YesNo);

                            if (dialogResultReemplazo == DialogResult.Yes)
                            {

                                Abm_Aeronave.FormAltaAeronave formularioAltaAeronave = new FormAltaAeronave();
                                formularioAltaAeronave.setPadre(this);
                                formularioAltaAeronave.setPadreEsVidaUtil(true);
                                formularioAltaAeronave.esReemplazoDe((int)filaSeleccionada.Cells[0].Value);
                                formularioAltaAeronave.ShowDialog();
                            }
                            else if (dialogResultReemplazo == DialogResult.No)
                            {
                                cancelarPasajesVidaUtil();
                                bajaVidaUtil();
                            }
                        }
                        else
                        {
                            bajaVidaUtil();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cancelarPasajesVidaUtil();
                        bajaVidaUtil();
                    }
                }
                else
                {
                    bajaVidaUtil();

                }
            }
        }

        private void bajaVidaUtil()
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();
            
            camposValores.Clear();
            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            errorMensaje.Clear();
            errorMensaje.Add(60004, "La Aeronave ya está fuera por vida útil");

            new gdDataBase().Exec("ÑUFLO.BajaPorVidaUtil", camposValores, errorMensaje, "Baja por vida útil de Aeronave exitosa");

            consultarConFiltro();
        }

        private void cancelarPasajesVidaUtil()
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            // fecha inicio la considero como la fecha actual
            camposValores.Clear();
            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            new gdDataBase().Exec("ÑUFLO.CancelarPasajesYEncomiendasDe", camposValores, null, null);
                    
        }

        private void btnBajaFueraServicio_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
            camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));

            errorMensaje.Add(60003, "La nave ya se encuentra en mantenimiento");
            errorMensaje.Add(60004, "La nave ya se encuentra fuera de su vida util");
            errorMensaje.Add(62004, "La fecha de reincorporacion debe ser mayor a la fecha de hoy");

            var ejecucion = new SPExecGetData("ÑUFLO.ValidarAeronaveActiva", camposValores, errorMensaje);

            DataTable dt = (DataTable)ejecucion.Exec();

            if (!ejecucion.huboError())
            {
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
                        camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
                        camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
                        camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

                        errorMensaje.Clear();
                        errorMensaje.Add(60005, "No se pudieron reemplazar todos los viajes");

                        var ejecucionReemplazo = new SPPureExec("ÑUFLO.ReemplazarAeronavePara", camposValores, errorMensaje,
                            "Pasajes/Encomiendas de la aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " reprogramadas exitosamente");

                        ejecucionReemplazo.Exec();

                        if (ejecucionReemplazo.huboError())
                        {
                            DialogResult dialogResultReemplazo = MessageBox.Show("Desea generar una nueva aeronave para poder reprogramar los viajes?\n En caso de seleccionar no se cancelaran los mismos",
                        "Agregar nueva aeronave para reprogramar", MessageBoxButtons.YesNo);

                            if (dialogResultReemplazo == DialogResult.Yes)
                            {
                                Abm_Aeronave.FormAltaAeronave formularioAltaAeronave = new FormAltaAeronave();
                                formularioAltaAeronave.setPadre(this);
                                formularioAltaAeronave.setPadreEsVidaUtil(false);
                                formularioAltaAeronave.esReemplazoDe((int)filaSeleccionada.Cells[0].Value);
                                formularioAltaAeronave.ShowDialog();
                            }
                            else if (dialogResultReemplazo == DialogResult.No)
                            {
                                cancelarPasajesFueraServicio();
                                bajaFueraDeServicio();
                            }
                        }
                        else
                        {
                            bajaFueraDeServicio();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cancelarPasajesFueraServicio();
                        bajaFueraDeServicio();
                    }
                }
                else 
                {
                    bajaFueraDeServicio();
                }
            }
        }

        public void cancelarPasajes(bool esVidaUtil) 
        {
            if (esVidaUtil) cancelarPasajesVidaUtil();
            else cancelarPasajesFueraServicio();
        }

        public void daDeBaja(bool esVidaUtil)
        {
            this.Enabled = true;

            if (esVidaUtil)
            {
                bajaVidaUtil();
            }
            else
            {
                bajaFueraDeServicio();
            }

            consultarConFiltro();
        }

        private void bajaFueraDeServicio()
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Clear();
            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_fuera", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
            camposValores.Add("fecha_rein", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString(), SqlDbType.DateTime));

            errorMensaje.Clear();
            errorMensaje.Add(60003, "La Aeronave ya se encuentra en mantenimiento");

            new gdDataBase().Exec("ÑUFLO.BajaFueraDeServicio", camposValores, errorMensaje,
                "Baja por fuerda de servicio de Aeronave " + filaSeleccionada.Cells[2].FormattedValue.ToString() + " exitosa");

            consultarConFiltro();
        }

        private void cancelarPasajesFueraServicio()
        {
            DataGridViewRow filaSeleccionada = getFilaSeleccionada();

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            // fecha inicio la considero como la fecha actual
            camposValores.Clear();
            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.Int));
            camposValores.Add("fecha_hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));
            camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            new gdDataBase().Exec("ÑUFLO.CancelarPasajesYEncomiendasDe", camposValores, null, null);
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

        private void FormSeleccionAeronave_Load(object sender, EventArgs e)
        {
            consultarConFiltro();
        }

        private void dataGridViewAeronave_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            senderGrid.CurrentRow.Selected = true;
            btnModificarAeronave.Enabled = true;
            btnBajaFueraServicio.Enabled = true;
            btnBajaVidaUtil.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
    }
}
