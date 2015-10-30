using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class FormListadoEstadistico : Form
    {


        public FormListadoEstadistico()
        {
            InitializeComponent();
            numericUpDown1.Minimum = DateTime.Today.Year - 100;
            numericUpDown1.Maximum = DateTime.Today.Year + 100;
            numericUpDown1.Value = DateTime.Today.Year;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // new gdDataBase().cargarListadoEstadistico(binding);
        }
    }
}
