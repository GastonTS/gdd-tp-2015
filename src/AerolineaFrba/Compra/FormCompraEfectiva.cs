using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FormCompraEfectiva : Form
    {
        public FormCompraEfectiva()
        {
            InitializeComponent();
        }

        private void checkBoxModificarDatos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatosCliente fdc = new FormDatosCliente();

            fdc.indicarSiEsPasajero(false);
            fdc.Show();
        }
    }
}
