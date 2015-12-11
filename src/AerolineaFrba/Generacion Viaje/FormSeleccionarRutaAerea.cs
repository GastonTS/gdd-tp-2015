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
    public partial class FormSeleccionarRutaAerea : Abm.FormReloaded
    {
        FormGenerarViaje miPadre;

        public FormSeleccionarRutaAerea()
        {
            InitializeComponent();
        }

        public void setPadre(FormGenerarViaje padre)
        {
            miPadre = padre;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaAeronave = dataGridView1.CurrentRow;

            if (miPadre != null)
            {
                miPadre.setCiudadOrigen(filaAeronave.Cells[3].FormattedValue.ToString());
                miPadre.setCiudadDestino(filaAeronave.Cells[5].FormattedValue.ToString());
                miPadre.setTipoServicio(filaAeronave.Cells[9].FormattedValue.ToString());
                miPadre.setIdRuta(Convert.ToInt32(filaAeronave.Cells[0].FormattedValue.ToString()));
            }

            this.Close();
        }

        private void FormSeleccionarRutaAerea_Load(object sender, EventArgs e)
        {
            var ds = new gdDataBase().ExecAndGetDataSet("ÑUFLO.CiudadTipoServicio");

            DataTable ciudades = ds.Tables[0];
            var filaExtraCiudad = ciudades.NewRow();
            filaExtraCiudad["Nombre"] = " Cualquiera";
            ciudades.Rows.InsertAt(filaExtraCiudad, 0);

            DataTable servicios = ds.Tables[1];
            var filaExtraServicios = servicios.NewRow();
            filaExtraServicios["Tipo Servicio"] = "Cualquiera";
            servicios.Rows.InsertAt(filaExtraServicios, 0);


            origenBindingSource.DataSource = ciudades;
            destinoBindingSource.DataSource = ciudades;
            tipoServicioBinding.DataSource = servicios;

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";

            dataGridView1.AutoGenerateColumns = true;
            rutaAereaBindingSource.DataSource = new gdDataBase().ExecAndGetDataSet("ÑUFLO.FiltrosModificacionRutaAerea").Tables[0];
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id ruta"].Visible = false;
            dataGridView1.Columns["id destino"].Visible = false;
            dataGridView1.Columns["id origen"].Visible = false;
            dataGridView1.Columns["id servicio"].Visible = false;
            btnAceptar.Enabled = false;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["Ciudad origen"];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            agregarValorCBADiccionario(comboBoxOrigen, camposValores, "id_ciudad_origen", SqlDbType.Int);

            agregarValorCBADiccionario(comboBoxDestino, camposValores, "id_ciudad_destino", SqlDbType.Int);

            agregarValorCBADiccionario(comboBoxTipoServicio, camposValores, "id_tipo_servicio", SqlDbType.Int);

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltrosModificacionRutaAerea", camposValores);

            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;

            var senderGrid = (DataGridView)sender;
            senderGrid.CurrentRow.Selected = true;
        }
    }
}
