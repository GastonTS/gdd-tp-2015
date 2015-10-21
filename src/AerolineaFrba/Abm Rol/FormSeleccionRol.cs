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
            comboBoxFuncionalidad.ResetText();
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
            //Datos de prueba, ya que no tengo la BD todavía. Quiero ver si puedo
            //pasar estos datos al formulario Modificacion, como tendría que hacer la aplicación
            //con los datos de la tabla verdadera de roles
            dataGridView.Rows.Add(1);
            dataGridView.Rows[0].Cells[0].Value = "Nombre de Rol";
            dataGridView.Rows[0].Cells[1].Value = "Una Funcionalidad de Rol";
            dataGridView.Rows[1].Cells[0].Value = "Otro nombre de Rol";
            dataGridView.Rows[1].Cells[1].Value = "Una Funcionalidad de Otro Rol";
        }
    }
}
