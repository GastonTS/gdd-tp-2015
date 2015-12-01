using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class FormDevolucion : Form
    {
        public FormDevolucion()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("1", "");
            dataGridView1.Columns.Add("2", "");
            dataGridView1.Columns.Add("3", "");
            dataGridView1.Columns.Add("4", "");
            dataGridView1.Columns.Add("5", "");
            dataGridView1.Columns.Add("6", "");
            dataGridView1.Columns.Add("7", "");
            dataGridView1.Columns.Add("8", "");
        }

        private void FormSeleccionCompra_Load(object sender, EventArgs e)
        {

        }

        
        public void agregarPasaje(DataGridViewRow fila) 
        {

            var ultimaPosicion = dataGridView1.Rows.Count;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Rows.Add();
            for (int i = 0; i < fila.Cells.Count-1; i++)
            {
                dataGridView1.Rows[ultimaPosicion].Cells[i].Value = fila.Cells[i+1].Value;
            }
            
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            var formBaja = new FormBajaPasajeEncomienda();
            formBaja.setPadre(this);
            formBaja.Show();
        }

        public void adaptarTabla(DataTable grilla) 
        {
            dataGridView1.DataSource = grilla;
        }

    }
}
