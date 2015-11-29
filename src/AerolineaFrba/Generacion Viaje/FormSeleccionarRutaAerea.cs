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
    public partial class FormSeleccionarRutaAerea : Form
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
                formInterface.setTipoServicio(filaAeronave.Cells[8].FormattedValue.ToString());
                formInterface.setIdRuta(Convert.ToInt32(filaAeronave.Cells[0].FormattedValue.ToString()));
            }

            this.Close();
        }

        private void FormSeleccionarRutaAerea_Load(object sender, EventArgs e)
        {
            DataRow filaExtraCiudad, filaExtraServicio;
            var dtOrigenDestino = new gdDataBase().GetDataWithParameters("ÑUFLO.Ciudades", null);

            filaExtraCiudad = dtOrigenDestino.NewRow();
            filaExtraCiudad["nombre"] = "Cualquiera";
            dtOrigenDestino.Rows.InsertAt(filaExtraCiudad, 0);

            origenBindingSource.DataSource = dtOrigenDestino;
            destinoBindingSource.DataSource = dtOrigenDestino;

            comboBoxOrigen.DataSource = origenBindingSource;
            comboBoxOrigen.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;

            comboBoxDestino.DataSource = destinoBindingSource;
            comboBoxDestino.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;

            var dtTipoServicio = new gdDataBase().GetDataWithParameters("ÑUFLO.TiposDeServicio", null);

            filaExtraServicio = dtTipoServicio.NewRow();
            filaExtraServicio["Tipo Servicio"] = "Cualquiera";
            dtTipoServicio.Rows.InsertAt(filaExtraServicio, 0);
            
            comboBoxTipoServicio.DataSource = dtTipoServicio;
            comboBoxTipoServicio.DisplayMember = dtTipoServicio.Columns[0].ColumnName;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            if (comboBoxOrigen.Text.Trim() != "Cualquiera")
                camposValores.Add("nombre_origen", new gdDataBase.ValorTipo(comboBoxOrigen.Text, SqlDbType.VarChar));
            if (comboBoxDestino.Text.Trim() != "Cualquiera")
                camposValores.Add("nombre_destino", new gdDataBase.ValorTipo(comboBoxDestino.Text, SqlDbType.VarChar));
            if (comboBoxTipoServicio.Text.Trim() != "Cualquiera")
                camposValores.Add("tipo_servicio", new gdDataBase.ValorTipo(comboBoxTipoServicio.Text, SqlDbType.VarChar));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltrosAltaRutaAerea", camposValores);

            dataGridView1.DataSource = dt;
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
