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
        public FormSeleccionarRutaAerea()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaAeronave = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];

            ISeleccionRuta formInterface = this.Owner as ISeleccionRuta;

            if (formInterface != null)
            {
                formInterface.setCiudadOrigen(filaAeronave.Cells[3].FormattedValue.ToString());
                formInterface.setCiudadDestino(filaAeronave.Cells[5].FormattedValue.ToString());
                formInterface.setTipoServicio(filaAeronave.Cells[9].FormattedValue.ToString());
                formInterface.setIdRuta(Convert.ToInt32(filaAeronave.Cells[0].FormattedValue.ToString()));
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
