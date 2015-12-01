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
    public partial class FormDatosPasajeroEncomienda : Abm.Alta, ICargaDatosCliente
    {
        bool soloPasaje = true;
        int idViaje = 16;

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

        private void FormDatosPasajeroEncomienda_Load(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("id_viaje", new gdDataBase.ValorTipo(idViaje.ToString(), SqlDbType.Decimal));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ButacasDisponibles", camposValores);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object[] fila = dt.Rows[i].ItemArray;

                if (fila.GetValue(1).ToString() == "Pasillo")
                    listBoxEleccionButacaPasillo.Items.Add("Butaca N°: " + fila.GetValue(0).ToString());
                else
                    listBoxEleccionButacaVentanilla.Items.Add("Butaca N°: " + fila.GetValue(0).ToString());
            }


        }

        private void textBoxCantidadAEncomendar_TextChanged(object sender, EventArgs e)
        {

        }


        private void listBoxEleccionButacaPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEleccionButacaVentanilla.ClearSelected();
        }

        private void listBoxEleccionButacaVentanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            fdc.Show(this);
        }

        public void setDNI(String dni)
        {
            textBoxDNI.Text = dni;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
