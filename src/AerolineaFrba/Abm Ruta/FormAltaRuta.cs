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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            
            var db = new gdDataBase();
            db.actualizarBindingSourceQuery(tipoServicioBinding,"SELECT * FROM [ÑUFLO].TipoServicio");
            comboBoxTipoServicio.DisplayMember = "tipo_servicio";
            db.actualizarBindingSourceQuery(origenBinding, "SELECT * FROM [ÑUFLO].Ciudad");
            comboBoxOrigen.DisplayMember = "nombre";
            db.actualizarBindingSourceQuery(destinoBinding, "SELECT * FROM [ÑUFLO].Ciudad");
            comboBoxDestino.DisplayMember = "nombre";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxOrigen.SelectedValue.ToString());
        }

        private void textBoxPrecioPeso_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(textBoxPrecioPeso.Text, out value))
                textBoxPrecioPeso.Text = String.Format(new System.Globalization.CultureInfo("es-AR"), "{0:C2}", value);
            else
                textBoxPrecioPeso.Text= String.Empty;

            System.Globalization.NumberFormatInfo MyNFI = new System.Globalization.NumberFormatInfo();
            MyNFI.NegativeSign = "-";
            MyNFI.CurrencyDecimalSeparator = ",";
            MyNFI.CurrencyGroupSeparator = ".";
            MyNFI.CurrencySymbol = "$";

            decimal d = decimal.Parse(textBoxPrecioPeso.Text, System.Globalization.NumberStyles.Currency, MyNFI);
            MessageBox.Show(d.ToString());
        }
    }
}
