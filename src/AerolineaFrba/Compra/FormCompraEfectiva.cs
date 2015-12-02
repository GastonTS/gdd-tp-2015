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
        List<int> butacasCompradas = new List<int>();

        public struct Compra
        {
            int idViaje, dni, codigoDeCompra;
            decimal pesoDisponible;

            public Compra(int idViaje, int dni, int codigoDeCompra, decimal pesoDisponible)
            {
                this.idViaje = idViaje;
                this.dni = dni;
                this.codigoDeCompra = codigoDeCompra;
                this.pesoDisponible = pesoDisponible;
            }
        }

        public struct Pasaje
        {
            int codigoDeCompra, dni, numeroDeButaca;
            decimal precio;

            public Pasaje(int codigoDeCompra, int dni, int numeroDeButaca, decimal precio)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.numeroDeButaca = numeroDeButaca;
                this.precio = precio;
            }
        }

        public struct Encomienda
        {
            int codigoDeCompra, dni;
            decimal pesoEncomienda, precio;

            public Encomienda(int codigoDeCompra, int dni, decimal pesoEncomienda, decimal precio)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.pesoEncomienda = pesoEncomienda;
                this.precio = precio;
            }
        }

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

        public void setButacasCompradas(List<int> butacasCompradas)
        {
            this.butacasCompradas = butacasCompradas;
        }

        public void setPasajes(List<Pasaje> pasajes)
        {

        }
    }
}
