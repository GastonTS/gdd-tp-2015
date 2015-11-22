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
    public partial class FormSeleccionCiudad : Form
    {
        public FormSeleccionCiudad()
        {
            InitializeComponent();
        }

        private void FormSeleccionCiudad_Load(object sender, EventArgs e)
        {
            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasCiudades", null);

            ciudadBindingSource.DataSource = ds;
            dataGridViewCiudades.DataSource = ciudadBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewCiudades.Rows[dataGridViewCiudades.SelectedCells[0].RowIndex];

                FormAltaCiudad fac = new FormAltaCiudad();

                fac.setNombreCiudad(filaSeleccionada.Cells[1].FormattedValue.ToString());
                fac.Show();
            }
        }

       

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
