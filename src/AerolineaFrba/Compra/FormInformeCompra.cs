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
    public partial class FormInformeCompra : Form
    {
        int pnr;
        List<FormSeleccionViaje.Pasaje> pasajes;
        List<FormSeleccionViaje.Encomienda> encomiendas;

        public FormInformeCompra()
        {
            InitializeComponent();
        }

        private void FormInformeCompra_Load(object sender, EventArgs e)
        {
            labelPNR.Text = labelPNR.Text + pnr.ToString();

            mostrarPasajesYEncomiendas();
        }

        public void setPNR(int pnr)
        {
            this.pnr = pnr;
        }

        public void setPasajes(List<FormSeleccionViaje.Pasaje> pasajes)
        {
            this.pasajes = pasajes;
        }

        public void setEncomiendas(List<FormSeleccionViaje.Encomienda> encomiendas)
        {
            this.encomiendas = encomiendas;
        }

        private void mostrarPasajesYEncomiendas()
        {
            listBox1.Items.Add("----Pasajes-----");
            foreach (FormSeleccionViaje.Pasaje unPasaje in pasajes)
            {
                listBox1.Items.Add("DNI: " + unPasaje.dni.ToString() + " Número de butaca: " + unPasaje.numeroDeButaca.ToString());
            }
            listBox1.Items.Add("----Encomiendas-----");
            foreach (FormSeleccionViaje.Encomienda unaEncomienda in encomiendas)
            {
                listBox1.Items.Add("DNI: " + unaEncomienda.dni.ToString() + " Peso de encomienda: " + unaEncomienda.pesoEncomienda.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
