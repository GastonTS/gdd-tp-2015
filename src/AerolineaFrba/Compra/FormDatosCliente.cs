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
    public partial class FormDatosCliente : Abm.Alta
    {
        bool esPasajero;
        Abm.IFormPadreDeDatosCliente miPadre;

        public override string MsgError
        {
            get { return "Porfavor revise que todos los datos sean correctos"; }
        }

        public FormDatosCliente()
        {
            InitializeComponent();
        }

        private void FormDatosCliente_Load(object sender, EventArgs e)
        {
            if (esPasajero)
                this.Text = "Ingrese los Datos del Pasajero";
            else
                this.Text = "Ingrese los Datos del Comprador";
        }

        public void indicarSiEsPasajero(bool esPasajero)
        {
            this.esPasajero = esPasajero;
        }

        private void habilitacionDatosCliente(bool estado)
        {
            textBoxNombre.Enabled = estado;
            textBoxTelefono.Enabled = estado;
            textBoxMail.Enabled = estado;
            textBoxApellido.Enabled = estado;
            dateTimeFechaNacimiento.Enabled = estado;
            textBoxDireccion.Enabled = estado;
            btnAceptar.Enabled = estado;
            button1.Enabled = !estado;
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

                    btnAceptar.Text = "Actualizar";
                    checkBoxModificarDatos.Visible = true;
                    habilitacionDatosCliente(false);
                }
                else
                {
                    limpiarDatosCliente();
                    checkBoxModificarDatos.Visible = false;
                    btnAceptar.Text = "Guardar";
                    habilitacionDatosCliente(true);
                }
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

        private void checkBoxModificarDatos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxModificarDatos.Checked)
                habilitacionDatosCliente(true);
            else
                habilitacionDatosCliente(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNI.Clear();
            textBoxMail.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();
            textBoxApellido.Clear();
        }

        protected override void guardarPosta()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDNI.Text, SqlDbType.Decimal));
            camposValores.Add("nombre", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));
            camposValores.Add("apellido", new gdDataBase.ValorTipo(textBoxApellido.Text, SqlDbType.VarChar));
            camposValores.Add("direccion", new gdDataBase.ValorTipo(textBoxDireccion.Text, SqlDbType.VarChar));
            camposValores.Add("telefono", new gdDataBase.ValorTipo(textBoxTelefono.Text, SqlDbType.Decimal));
            camposValores.Add("mail", new gdDataBase.ValorTipo(textBoxMail.Text, SqlDbType.VarChar));
            camposValores.Add("fecha_de_nacimiento", new gdDataBase.ValorTipo(dateTimeFechaNacimiento.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));

            new gdDataBase().Exec("ÑUFLO.ModificarCliente", camposValores, null, "Datos del cliente actualizados exitosamente");

            habilitacionDatosCliente(false);
            checkBoxModificarDatos.Checked = false;
        }

        public void setPadre(Abm.IFormPadreDeDatosCliente padre)
        {
            miPadre = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.TabStop))
            {
                if (miPadre != null)
                    miPadre.setDNI(textBoxDNI.Text);

                this.Close();
            }

        }

    }
}
