using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class FormAltaCiudad : Form
    {
        public FormAltaCiudad()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreCiudad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void setNombreCiudad(String nombreCiudad)
        {
            textBoxNombreCiudad.Text = nombreCiudad;
        }
    }
}
