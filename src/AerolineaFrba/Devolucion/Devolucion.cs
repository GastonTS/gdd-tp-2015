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
    public partial class Devolucion : Form
    {
        Deprecated padre;

        public void setPadre(Deprecated unForm)
        {
            padre=unForm;
        }

        public Devolucion()
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
            buscarPasajesYEncomiendas();

        }

        private void buscarPasajesYEncomiendas()
        {
            if (ValidateChildren())
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("codigo_compra", new gdDataBase.ValorTipo(textBoxPNR.Text, SqlDbType.Int));
                var errorMensaje = new Dictionary<int, string>();
                errorMensaje.Add(64001, "Los pasajes y/o encomiendas para el PNR seleccionado ya fueron realizados.");
                var executer = new SPExecGetData("ÑUFLO.PasajesYEncomiendasNoCanceladosDe", camposValores, errorMensaje);
                var resultadoBusqueda = (DataTable)executer.Exec();
                if (!executer.huboError() && resultadoBusqueda.Rows.Count == 0)
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

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un elemento a devolver.");
                return;
            }
            if (ValidateChildren())
            {
                var parametrosCancelarCompra = gdDataBase.newParameters();
                parametrosCancelarCompra.Add("pnr", new gdDataBase.ValorTipo(int.Parse(textBoxPNR.Text),SqlDbType.Int));
                parametrosCancelarCompra.Add("hoy", new gdDataBase.ValorTipo(Config.fecha,SqlDbType.DateTime));
                int codigoCancelacion = (int)new gdDataBase().ExecAndGetData("ÑUFLO.CrearCancelacion", parametrosCancelarCompra).Rows[0][0];

            foreach (DataGridViewRow fila in filasCheckBoxMarcados())
            {  
                        var camposValores = gdDataBase.newParameters();
                        camposValores.Add("id", new gdDataBase.ValorTipo(fila.Cells["Codigo"].Value, SqlDbType.Int));
                        camposValores.Add("tipo", new gdDataBase.ValorTipo(fila.Cells["Tipo"].Value, SqlDbType.NVarChar));
                        camposValores.Add("motivo", new gdDataBase.ValorTipo(richTextBox1.Text, SqlDbType.NVarChar));
                        camposValores.Add("id_cancelacion", new gdDataBase.ValorTipo(codigoCancelacion, SqlDbType.Int));
                        var exec = new SPPureExec("ÑUFLO.CancelarPasajeOEncomienda", camposValores, new Dictionary<int, string>(), "Cancelación de " + fila.Cells["Tipo"].Value + " con código " + fila.Cells["Codigo"].Value + " fue exitosa.");
                        exec.Exec(new gdDataBase());
                }
                                
            }
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
            limpiarTabla();
        }

        private void limpiarTabla()
        {
            dataGridView1.DataSource = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTabla();
        }
    }
}
