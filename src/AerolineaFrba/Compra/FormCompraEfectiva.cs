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

        private void btnFinalizarCarga_Click(object sender, EventArgs e)
        {
            generarCompra();

        }

        private void generarCompra()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_viaje", new gdDataBase.ValorTipo(compraARealizar.idViaje.ToString(), SqlDbType.VarChar));
            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDNI.Text, SqlDbType.VarChar));
            camposValores.Add("hoy", new gdDataBase.ValorTipo(DateTime.Now.Date.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            var dt = new gdDataBase().ExecAndGetData("ÑUFLO.CrearCompra", camposValores, null);

            compraARealizar = new FormSeleccionViaje.Compra(compraARealizar.idViaje,
                Convert.ToInt32(textBoxDNI.Text), Convert.ToInt32(dt.Rows[0].ItemArray[0]));
        }
    }
}
