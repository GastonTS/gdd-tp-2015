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

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNombre.Text.Trim() == "")
            {
                errorProvider.SetError(textBoxNombre, "Debe ingresar un nombre de Ciudad");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.TabStop))
            {
                MessageBox.Show("Crea Ciudad correctamente");
            }
            else
            {
                foreach (Control unControl in Controls)
                {
                    unControl.Refresh();
                }
                MessageBox.Show("Error al crear Ciudad. Ingresar los campos correctamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
