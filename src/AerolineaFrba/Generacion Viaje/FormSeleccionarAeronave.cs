using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class FormSeleccionarAeronave : Form
    {
        FormGenerarViaje miPadre;

        public FormSeleccionarAeronave()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            if (textBoxMatricula.Text.Trim() != "")
                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
            if (textBoxModelo.Text.Trim() != "")
                camposValores.Add("modelo", new gdDataBase.ValorTipo(textBoxModelo.Text, SqlDbType.VarChar));
            if (textBoxFabricante.Text.Trim() != "")
                camposValores.Add("fabricante", new gdDataBase.ValorTipo(textBoxFabricante.Text, SqlDbType.VarChar));
            if (comboBoxTipoServicio.Text != "Cualquiera")
                camposValores.Add("tipo_servicio", new gdDataBase.ValorTipo(comboBoxTipoServicio.SelectedIndex.ToString(), SqlDbType.Int));
            if (textBoxCapacidadEncomiendas.Text.Trim() != "")
                camposValores.Add("capacidad_encomiendas", new gdDataBase.ValorTipo(textBoxCapacidadEncomiendas.Text, SqlDbType.Decimal));
            if (textBoxCantidadButacas.Text.Trim() != "")
                camposValores.Add("cantidad_butacas", new gdDataBase.ValorTipo(textBoxCantidadButacas.Text, SqlDbType.Int));
            camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltroAeronaveSinBajas", camposValores);

            bindingAeronaves.DataSource = ds;
            dataGridViewAeronave.DataSource = bindingAeronaves;
        }

        private void dataGridViewAeronave_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            senderGrid.CurrentRow.Selected = true;
            btnAceptar.Enabled = true;
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCantidadButacas.Clear();
            textBoxCapacidadEncomiendas.Clear();
            textBoxFabricante.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();
            comboBoxTipoServicio.Text = "";
        }

        public void setPadre(FormGenerarViaje padre)
        {
            miPadre = padre;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaAeronave = dataGridViewAeronave.CurrentRow;

            if (miPadre != null)
                miPadre.setMatricula(filaAeronave.Cells[2].FormattedValue.ToString());

            this.Close();
        }

        private void FormSeleccionarAeronave_Load(object sender, EventArgs e)
        {
            var ds = new gdDataBase().ExecAndGetDataSet("ÑUFLO.CiudadTipoServicio");

            DataTable servicios = ds.Tables[1];
            var filaExtraServicios = servicios.NewRow();
            filaExtraServicios["Tipo Servicio"] = "Cualquiera";
            servicios.Rows.InsertAt(filaExtraServicios, 0);

            tipoServicioBinding.DataSource = servicios;

            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
        }
    }
}
