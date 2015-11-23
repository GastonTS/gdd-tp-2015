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
    public partial class FormSeleccionRol : Form
    {
        public FormSeleccionRol()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1) //la última columna sería la de "Seleccionar"
            {
                List<String> registroSeleccionado = new List<string>();

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    registroSeleccionado.Add(dataGridView.Rows[e.RowIndex].Cells[i].FormattedValue.ToString());
                }

                FormModificacionRol fmr = new FormModificacionRol(registroSeleccionado);
                fmr.Show();
            }
        }

        private void FormSeleccionRol_Load(object sender, EventArgs e)
        {
            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasFuncionalidades", null);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].DisplayIndex = 2;
            dataGridView.Columns[1].DisplayIndex = 1;
            dataGridView.Columns[2].DisplayIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
