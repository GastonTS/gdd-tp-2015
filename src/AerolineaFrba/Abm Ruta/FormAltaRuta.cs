using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class FormAltaRuta : Form
    {
        public FormAltaRuta()
        {
            InitializeComponent();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxOrigen.ResetText();
            comboBoxDestino.ResetText();
            comboBoxTipoServicio.ResetText();
            textBoxPrecioPasaje.Clear();
            textBoxPrecioPeso.Clear();
        }

        private void groupBoxCamposAltaRuta_Enter(object sender, EventArgs e)
        {

        }

        private void FormAltaRuta_Load(object sender, EventArgs e)
        {
            
            var ds = new gdDataBase().GetDataQuery("SELECT id_ciudad, nombre FROM ÑUFLO.Ciudad SELECT id_tipo_servicio, tipo_servicio FROM ÑUFLO.TipoServicio");
            
            origenBinding.DataSource = ds.Tables[0];
            destinoBinding.DataSource = ds.Tables[0];
            tipoServicioBinding.DataSource = ds.Tables[1];

            comboBoxOrigen.DisplayMember = "nombre";
            comboBoxOrigen.ValueMember = "id_ciudad";
            comboBoxDestino.DisplayMember = "nombre";
            comboBoxDestino.ValueMember = "id_ciudad";
            comboBoxTipoServicio.DisplayMember = "tipo_servicio";
            comboBoxTipoServicio.ValueMember = "id_tipo_servicio";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
