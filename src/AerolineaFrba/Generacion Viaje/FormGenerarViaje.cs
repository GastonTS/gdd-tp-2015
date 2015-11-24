using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class FormGenerarViaje : Form, ISeleccionAeronave, ISeleccionRuta
    {
        private Control primerControlInvalido;

        public FormGenerarViaje()
        {
            InitializeComponent();
        }

        private void btnSeleccionAeronave_Click(object sender, EventArgs e)
        {
            FormSeleccionarAeronave fsa = new FormSeleccionarAeronave();
            fsa.Show(this);
        }

        private void btnSeleccionRuta_Click(object sender, EventArgs e)
        {
            FormSeleccionarRutaAerea fra = new FormSeleccionarRutaAerea();
            fra.Show(this);
        }

        public void setMatricula(String matricula)
        {
            textBoxMatricula.Text = matricula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Esta forma de validar, valida de a uno los errores. Como errores particulares
            //en este formulario tengo este por ahora. No lo veo mal. Habría que ver cómo se lleva
            //con los errores propios de los controles (validar campo obligatorio de user control texto y demás)
            primerControlInvalido = null;
            this.ValidateChildren();

            if (primerControlInvalido != null) primerControlInvalido.Focus();
            else
            {
                // lo que tiene que hacer el boton guardar (generar el viaje)     
            }
        }

        private void FormGenerarViaje_Load(object sender, EventArgs e)
        {
            dateTimePickerSalida.MinDate = DateTime.Now.Date;
            dateTimePickerLlegada.MinDate = DateTime.Now.Date;
            dateTimePickerEstimada.MinDate = DateTime.Now.Date;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDestino.Text = "";
            textBoxMatricula.Text = "";
            textBoxOrigen.Text = "";
            textBoxTipoServicio.Text = "";
            dateTimePickerEstimada.ResetText();
            dateTimePickerLlegada.ResetText();
            dateTimePickerSalida.ResetText();
        }

        private void asinarValidacion(object sender, bool validacion, string mensajeError)
        {
            var ctl = (Control)sender;
            if (validacion) errorProvider1.SetError(ctl, "");
            else
            {
                if (primerControlInvalido == null) primerControlInvalido = ctl;
                errorProvider1.SetError(ctl, mensajeError);
            }
        }

        private void dateTimePickerLlegada_Validating(object sender, CancelEventArgs e)
        {
            asinarValidacion(sender, dateTimePickerSalida.Value.CompareTo(dateTimePickerLlegada.Value) <= 0,
                "La fecha de llegada debe ser mayor a la fecha d salida");
        }

        public void setCiudadOrigen(String origen)
        {
            textBoxOrigen.Text = origen;
        }
        public void setCiudadDestino(String destino)
        {
            textBoxDestino.Text = destino;
        }
        public void setTipoServicio(String tipoServicio)
        {
            textBoxTipoServicio.Text = tipoServicio;
        }
    }
}
