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
        private int idRuta;

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
                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("fecha_salida", new gdDataBase.ValorTipo(dateTimePickerSalida.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));
                camposValores.Add("fecha_llegada_estimada", new gdDataBase.ValorTipo(dateTimePickerEstimada.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));
                camposValores.Add("hoy", new gdDataBase.ValorTipo(DateTime.Now.Date.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.DateTime));
                camposValores.Add("matricula", new gdDataBase.ValorTipo(textBoxMatricula.Text, SqlDbType.VarChar));
                camposValores.Add("id_ruta", new gdDataBase.ValorTipo(idRuta.ToString(), SqlDbType.VarChar));

                errorMensaje.Add(60007,  "La matricula ingresada no pertenece a ninguna Aeronave");
                errorMensaje.Add(600012, "La ruta ingresada no existe");
                errorMensaje.Add(600015, "El servicio brindado por la aeronave no coincide con el de la ruta");
                errorMensaje.Add(600016, "La aeronave ya posee un viaje en esas fechas");

                new gdDataBase().Exec("ÑUFLO.GenerarViaje", camposValores, errorMensaje, "Viaje registrado correctamente");
            }
        }

        private void FormGenerarViaje_Load(object sender, EventArgs e)
        {
            dateTimePickerSalida.MinDate = DateTime.Now.Date;
            dateTimePickerEstimada.MinDate = DateTime.Now.Date;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDestino.Text = "";
            textBoxMatricula.Text = "";
            textBoxOrigen.Text = "";
            textBoxTipoServicio.Text = "";
            dateTimePickerEstimada.ResetText();
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
        public void setIdRuta(int idRuta)
        {
            this.idRuta = idRuta;
        }

        private void dateTimePickerEstimada_Validating(object sender, CancelEventArgs e)
        {
            asinarValidacion(sender, dateTimePickerSalida.Value.CompareTo(dateTimePickerEstimada.Value) <= 0,
                "La fecha de llegada estimada debe ser mayor a la fecha de salida");
        }
    }
}
