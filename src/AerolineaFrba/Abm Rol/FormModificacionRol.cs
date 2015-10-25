using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class FormModificacionRol : Form
    {
        List<String> registroSeleccionado;
        public FormModificacionRol(List<String> registroSeleccionado)
        {
            this.registroSeleccionado = registroSeleccionado;
            InitializeComponent();
        }

        private void FormModificacionRol_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = registroSeleccionado[0];
            comboBoxFuncionalidades.Text = registroSeleccionado[1];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            comboBoxFuncionalidades.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
