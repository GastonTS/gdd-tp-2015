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
    public partial class FormCompraEfectiva : Form, ICargaDatosCliente
    {
        List<FormSeleccionViaje.Pasaje> pasajesAComprar = new List<FormSeleccionViaje.Pasaje>();
        List<FormSeleccionViaje.Encomienda> encomiendasAComprar = new List<FormSeleccionViaje.Encomienda>();
        FormSeleccionViaje.Compra compraARealizar;

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
            fdc.Show(this);
        }

        public void setDNI(String dni)
        {
            textBoxDNI.Text = dni;
        }

        public void setCompras(FormSeleccionViaje.Compra compra, List<FormSeleccionViaje.Pasaje> pasajes,
            List<FormSeleccionViaje.Encomienda> encomiendas)
        {
            compraARealizar = compra;
            pasajesAComprar = pasajes;
            encomiendasAComprar = encomiendas;
        }
    }
}
