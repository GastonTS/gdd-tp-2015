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
            dataGridView1.Columns.Add("Codigo", "Codigo");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Peso_Encomienda", "Peso de encomienda");
            dataGridView1.Columns.Add("Butaca_numero", "Número de butaca");
            dataGridView1.Columns.Add("Precio", "Precio");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dateTimePicker1.ResetText();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un elemento a devolver.");
                    return;
                }
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    var camposValores = gdDataBase.newParameters();
                    camposValores.Add("id", new gdDataBase.ValorTipo(fila.Cells["Codigo"].Value, SqlDbType.Int));
                    camposValores.Add("tipo", new gdDataBase.ValorTipo(fila.Cells["Tipo"].Value, SqlDbType.NVarChar));
                    camposValores.Add("motivo", new gdDataBase.ValorTipo(richTextBox1.Text, SqlDbType.NVarChar));
                    camposValores.Add("hoy", new gdDataBase.ValorTipo(dateTimePicker1.Value, SqlDbType.DateTime));
                    var exec = new SPPureExec("ÑUFLO.CancelarPasajeOEncomienda", camposValores, new Dictionary<int, string>(), "Cancelación de " + fila.Cells["Tipo"].Value + " con código " + fila.Cells["Codigo"].Value + " fue exitosa.");
                    exec.Exec(new gdDataBase());
                }
                dataGridView1.Rows.Clear();
            }
        }

    }
}
