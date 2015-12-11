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
    public partial class FormDatosPasajeroEncomienda : Abm.Alta, ICargaDatosCliente, Abm.IFormPadreDeDatosCliente
    {
        public override string MsgError
        {
            get { return "Porfavor revise que todos los datos sean correctos"; }
        }

        bool soloPasaje = true;
        int idViaje, numeroDeButacaSeleccionada;
        List<int> butacasEnCompra = new List<int>();
        public FormSeleccionViaje miPadre;

        public FormDatosPasajeroEncomienda()
        {
            InitializeComponent();
        }

        public void indicarPasajeOEncomienda(bool soloPasaje)
        {
            this.soloPasaje = soloPasaje;
            if (soloPasaje)
                this.Text = "Ingrese datos del Pasajero";
            else
            {
                this.Text = "Ingrese datos del Pasajero y su Encomienda";

                textBoxCantidadAEncomendar.Visible = true;
                labelEncomienda.Visible = true;
                labelPasillo.Visible = false;
                labelVentanilla.Visible = false;
                labelButaca.Visible = false;
                listBoxEleccionButacaPasillo.Visible = false;
                listBoxEleccionButacaVentanilla.Visible = false;
            }
        }

        public void setIDViaje(int idViaje)
        {
            this.idViaje = idViaje;
        }

        public void setPadre(FormSeleccionViaje padre)
        {
            miPadre = padre;
        }

        private void FormDatosPasajeroEncomienda_Load(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("id_viaje", new gdDataBase.ValorTipo(idViaje.ToString(), SqlDbType.Decimal));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ButacasDisponibles", camposValores);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object[] fila = dt.Rows[i].ItemArray;

                if (fila.GetValue(1).ToString() == "Pasillo")
                    listBoxEleccionButacaPasillo.Items.Add(fila.GetValue(0).ToString());
                else
                    listBoxEleccionButacaVentanilla.Items.Add(fila.GetValue(0).ToString());
            }

            eliminarEnCompra(listBoxEleccionButacaPasillo);
            eliminarEnCompra(listBoxEleccionButacaVentanilla);
        }

        private void eliminarEnCompra(ListBox listadoButacas)
        {
            for (int i = 0; i < listadoButacas.Items.Count; i++)
            {
                if (butacasEnCompra.Contains(Convert.ToInt32(listadoButacas.Items[i])))
                    listadoButacas.Items.RemoveAt(i);
            }
        }

        private void textBoxCantidadAEncomendar_TextChanged(object sender, EventArgs e)
        {

        }


        private void listBoxEleccionButacaPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroDeButacaSeleccionada = Convert.ToInt32(listBoxEleccionButacaPasillo.SelectedItem);

            listBoxEleccionButacaVentanilla.ClearSelected();
        }

        private void listBoxEleccionButacaVentanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroDeButacaSeleccionada = Convert.ToInt32(listBoxEleccionButacaVentanilla.SelectedItem);

            listBoxEleccionButacaPasillo.ClearSelected();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNI.Clear();
            textBoxCantidadAEncomendar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Previo, de debe validar que se acepta un cliente que existe
            FormDatosCliente fdc = new FormDatosCliente();

            fdc.indicarSiEsPasajero(true);
            fdc.setPadre(this);
            fdc.Show(this);
        }

        public void setDNI(String dni)
        {
            textBoxDNI.Text = dni;
        }

        public void setButacasEnCompra(List<int> butacasEnCompra)
        {
            this.butacasEnCompra = butacasEnCompra;
        }

        protected override void guardarPosta()
        {
            if (miPadre != null)
            {
                miPadre.setConViaje();

                if (soloPasaje)
                    if (listBoxEleccionButacaPasillo.SelectedIndex != -1 || listBoxEleccionButacaVentanilla.SelectedIndex != -1)
                        miPadre.setPasaje(Convert.ToInt32(textBoxDNI.Text), numeroDeButacaSeleccionada, this);
                    else
                        MessageBox.Show("Seleccione una butaca para terminar la operación");
                else
                    miPadre.setEncomienda(Convert.ToInt32(textBoxDNI.Text), Convert.ToDecimal(textBoxCantidadAEncomendar.Text), this);
            }
        }

        private void btnAceptar_Load(object sender, EventArgs e)
        {

        }

       
    }
}
