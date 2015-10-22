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
    public partial class FormBajaRol : Form
    {
        public FormBajaRol()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            comboBoxFuncionalidad.ResetText();
        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
