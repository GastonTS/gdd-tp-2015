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
    public partial class FormGenerarViaje : Form
    {
        public FormGenerarViaje(DataGridViewRow filaAeronave = null, DataGridViewRow filaRuta = null)
        {
            InitializeComponent();

            if (filaAeronave != null)
            {
                textBoxMatricula.Text = filaAeronave.Cells[2].FormattedValue.ToString();
            }

        }

        private void btnSeleccionAeronave_Click(object sender, EventArgs e)
        {
            FormSeleccionarAeronave fsa = new FormSeleccionarAeronave();
            fsa.Show();
        }
    }
}
