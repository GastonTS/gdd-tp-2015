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
    public partial class FormDatosPasajeroEncomienda : Abm.Alta
    {
        bool soloPasaje = true;
        int idViaje = 16;

        public FormDatosPasajeroEncomienda()
        {
            InitializeComponent();
        }

        private void checkBoxModificarDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificarDatos.Checked)
                habilitacionDatosCliente(true);
            else
                habilitacionDatosCliente(false);
        }

        private void habilitacionDatosCliente(bool estado)
        {
            textBoxNombre.Enabled = estado;
            textBoxTelefono.Enabled = estado;
            textBoxMail.Enabled = estado;
            textBoxApellido.Enabled = estado;
            dateTimeFechaNacimiento.Enabled = estado;
            textBoxDireccion.Enabled = estado;
            btnActualizar.Enabled = estado;
        }

        public void indicarPasajeOEncomienda(bool soloPasaje)
        {
            this.soloPasaje = soloPasaje;
            if (soloPasaje)
                this.Text = "Ingrese datos del Pasajero";
            else
            {
                this.Text = "Ingrese datos del Pasajero y su Encomienda";
                textBoxCantidadAEncomendar.Enabled = true;
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

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            //este texto sólo debe permitir ingreso de números
            if (textBoxDNI.Text.Length >= 7)
            {
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

                camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDNI.Text, SqlDbType.Decimal));

                var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ConsultaCliente", camposValores);

                if (dt.Rows.Count == 1)
                {
                    object[] fila = dt.Rows[0].ItemArray;

                    textBoxNombre.Text = fila.GetValue(0).ToString();
                    textBoxApellido.Text = fila.GetValue(1).ToString();
                    textBoxDireccion.Text = fila.GetValue(2).ToString();
                    textBoxTelefono.Text = fila.GetValue(3).ToString();
                    textBoxMail.Text = fila.GetValue(4).ToString();
                    dateTimeFechaNacimiento.Text = fila.GetValue(5).ToString();
                }
                else
                    limpiarDatosCliente();
            }
        }

        public void limpiarDatosCliente()
        {
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxMail.Clear();
            textBoxDireccion.Clear();
            textBoxApellido.Clear();
            dateTimeFechaNacimiento.ResetText();
        }

        private void textBoxCantidadAEncomendar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDNI.Text, SqlDbType.Decimal));
            camposValores.Add("nombre", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));
            camposValores.Add("apellido", new gdDataBase.ValorTipo(textBoxApellido.Text, SqlDbType.VarChar));
            camposValores.Add("direccion", new gdDataBase.ValorTipo(textBoxDireccion.Text, SqlDbType.VarChar));
            camposValores.Add("telefono", new gdDataBase.ValorTipo(textBoxTelefono.Text, SqlDbType.Decimal));
            camposValores.Add("mail", new gdDataBase.ValorTipo(textBoxMail.Text, SqlDbType.VarChar));
            camposValores.Add("fecha_de_nacimiento", new gdDataBase.ValorTipo(dateTimeFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            new gdDataBase().Exec("ÑUFLO.ModificarCliente", camposValores, null, "Datos del cliente actualizados exitosamente");

            habilitacionDatosCliente(false);
            checkBoxModificarDatos.Checked = false;
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
            textBoxDireccion.Clear();
            textBoxMail.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxCantidadAEncomendar.Clear();
            textBoxApellido.Clear();
            dateTimeFechaNacimiento.ResetText();
        }
    }
}
