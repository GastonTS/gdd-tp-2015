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
            new gdDataBase().actualizarBindingSourceQuery(bindingSourceTipoServicio, "select * from [Ñuflo].TipoServicio");
            comboBoxTipoServicio.DisplayMember = "tipo_servicio";
            comboBoxTipoServicio.ValueMember = "id_tipo_servicio";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
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
            camposValores.Add("tipo_servicio", new gdDataBase.ValorTipo((comboBoxTipoServicio.SelectedIndex + 1).ToString(), SqlDbType.Int));
            if (textBoxCapacidadEncomiendas.Text.Trim() != "")
            camposValores.Add("capacidad_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            if (bajaFueraServicio)
            camposValores.Add("baja_fuera_servicio", new gdDataBase.ValorTipo(Convert.ToString(bajaFueraServicio), SqlDbType.Bit));
            if (bajaVidaUtil)
            camposValores.Add("baja_vida_util", new gdDataBase.ValorTipo(Convert.ToString(bajaVidaUtil), SqlDbType.Bit));
            if (textBoxCantidadButacas.Text.Trim() != "")
            camposValores.Add("cantidad_butacas", new gdDataBase.ValorTipo(textBoxCantidadButacas.Text, SqlDbType.Int));

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
            }
            else
            {
                btnModificarAeronave.Enabled = false;
                btnBajaVidaUtil.Enabled = false;
                btnBajaFueraServicio.Enabled = false;
            }
        }

        private void btnModificarAeronave_Click(object sender, EventArgs e)
        {
            //abrir el formulario de alta con todos los datos de la aeronave seleccionada actualmente
            DataGridViewRow filaSeleccionada = dataGridViewAeronave.Rows[dataGridViewAeronave.SelectedRows[0].Index];

            FormAltaAeronave faa = new FormAltaAeronave(filaSeleccionada);
            faa.Show();
        }

        private void btnBajaVidaUtil_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridViewAeronave.Rows[dataGridViewAeronave.SelectedRows[0].Index];

            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_aeronave", new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].FormattedValue.ToString(), SqlDbType.VarChar));
            camposValores.Add("fecha", new gdDataBase.ValorTipo(DateTime.Now.Date.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            errorMensaje.Add(60004, "La Aeronave ya está fuera por vida útil");

            var dt = new gdDataBase().ExecAndGetData("ÑUFLO.BajaPorVidaUtil", camposValores, errorMensaje, "Baja por vida útil de Aeronave exitosa");

            int cantidadViajesPendientes = -1;
            if(dt.Rows.Count > 0)
                cantidadViajesPendientes = Convert.ToInt32(dt.Rows[0].ItemArray[0]);


        }
    }
}
