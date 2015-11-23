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
            if (e.ColumnIndex == 0) //modificar rol
            {
                DataGridViewRow filaSeleccionada = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];

                String descripcion = filaSeleccionada.Cells[2].FormattedValue.ToString();

                FormAltaRol far = new FormAltaRol();

                far.setNombreRol(descripcion);
                far.Show();
            }
            else if (e.ColumnIndex == 1) //habilitar/deshabilitar rol
            {
 
            }
        }

        private void FormSeleccionRol_Load(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            camposValores.Add("nombre", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.RolDadoNombre", null);
            cargarDatosEnTabla(dt);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            camposValores.Add("nombre", new gdDataBase.ValorTipo(textBoxNombre.Text, SqlDbType.VarChar));

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.RolDadoNombre", camposValores);
            cargarDatosEnTabla(dt);
        }

        private void cargarDatosEnTabla(DataTable dt)
        {
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].DisplayIndex = 2;
            dataGridView.Columns[1].DisplayIndex = 1;
            dataGridView.Columns[2].DisplayIndex = 0;
        }
    }
}
