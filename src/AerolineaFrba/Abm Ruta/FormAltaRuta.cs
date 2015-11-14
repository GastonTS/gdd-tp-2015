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

            var ds = new gdDataBase().GetDataSP("ÑUFLO.CiudadTipoServicio");
            
            origenBinding.DataSource = ds.Tables[0];
            destinoBinding.DataSource = ds.Tables[0];
            tipoServicioBinding.DataSource = ds.Tables[1];

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Decimal porcentajeRecargo() { return Decimal.Parse(((DataRowView)this.tipoServicioBinding.Current).Row["Porcentaje de recargo"].ToString()); }

        private Decimal precioPesoFinal() { return textBoxPrecioPeso.DecimalValue() * porcentajeRecargo(); }

        private Decimal precioPasajeFinal() { return textBoxPrecioPasaje.DecimalValue() * porcentajeRecargo(); }
    
        private void asignarPreciosFinalesALabels(object sender, EventArgs e)
        {
            labelValorPrecioFinalPeso.Text = "$"+precioPesoFinal().ToString() ;
            labelValorPrecioFinalPasaje.Text = "$"+precioPasajeFinal().ToString() ;
        }

    }
}
