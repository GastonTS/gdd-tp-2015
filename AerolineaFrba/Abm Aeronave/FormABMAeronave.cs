using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormABMAeronave : Form
    {
        public FormABMAeronave()
        {
            InitializeComponent();
        }

        private void aeronaveBox_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("AeronaveBox ENTER");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("boton LIMPIAR");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("boton GUARDAR");
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("textbox TEXTOCAMBIADO");
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nombre CLICK");
        }
    }
}
