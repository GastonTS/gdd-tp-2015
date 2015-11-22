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
    public partial class FormGenerarViaje : Form, IFormulariosViaje
    {
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
            fra.Show();
        }

        public void setMatricula(String matricula)
        {
            textBoxMatricula.Text = matricula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePickerSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormGenerarViaje_Load(object sender, EventArgs e)
        {
            dateTimePickerSalida.MinDate = DateTime.Now.Date;
            dateTimePickerLlegada.MinDate = DateTime.Now.Date;
            dateTimePickerEstimada.MinDate = DateTime.Now.Date;
        }
    }
}
