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
    public partial class FormBajaPasajeEncomienda : Form
    {
        FormDevolucion padre;

        public void setPadre(FormDevolucion unForm)
        {
            padre=unForm;
        }

        public FormBajaPasajeEncomienda()
        {
            InitializeComponent();
            dataGridView1.Columns["Baja"].ReadOnly = false;
        }

        private void inicializarColumnaCheckBox()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                {                
                        row.Cells["Baja"].Value = false;
                 }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("codigo_compra",new gdDataBase.ValorTipo(textBoxPNR.Text,SqlDbType.Int));
                var resultadoBusqueda = new gdDataBase().ExecAndGetData("ÑUFLO.PasajesYEncomiendasNoCanceladosDe",camposValores, new Dictionary<int,string>());
                if (resultadoBusqueda.Rows.Count == 0)
                    MessageBox.Show("No se encontraron resultados que satisfagan la búsqueda");
                else
                {
                    dataGridView1.DataSource = resultadoBusqueda;
                    inicializarColumnaCheckBox();
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var index = e.ColumnIndex;

            if (senderGrid.Columns[index] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                if (index == senderGrid.Columns["Baja"].Index)
                {
                    if ((bool)senderGrid.CurrentCell.Value)
                        senderGrid.CurrentCell.Value = false;
                    else
                        senderGrid.CurrentCell.Value = true;

                }


                else ;
            
        }
        }

        private List<DataGridViewRow> filasCheckBoxMarcados()
        {
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
                {                
            if((bool)fila.Cells["Baja"].Value) filas.Add(fila);
                }
            return filas;
        }

        private int cantCheckBoxMarcados()
        {
            return filasCheckBoxMarcados().Count;
        }

        private void cancelarPasajes() {

            foreach (DataGridViewRow fila in filasCheckBoxMarcados())
            {
                padre.agregarPasaje(fila);

                
            }
            Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || cantCheckBoxMarcados() == 0)
                MessageBox.Show("No hay ningún elemento seleccionado");
            else
            {
                var resultado = MessageBox.Show("Dar de baja los pasajes/encomiendas",
                        "¿Está seguro que quiere dar de baja los elementos seleccionados?", MessageBoxButtons.YesNo);
                if (resultado.CompareTo(DialogResult.Yes)==0) cancelarPasajes();
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
