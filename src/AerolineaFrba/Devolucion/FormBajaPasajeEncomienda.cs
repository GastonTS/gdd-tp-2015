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
                var resultadoBusqueda = new gdDataBase().ExecAndGetData("ÑUFLO.PasajesYEncomiendasDe",camposValores, new Dictionary<int,string>());
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
          
            /*
            camposValores.Add("nombre_destino",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["Ciudad destino"].Value, SqlDbType.NVarChar));
            camposValores.Add("tipo_servicio",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["Tipo de servicio"].Value, SqlDbType.NVarChar));
            var selectedRowData = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltrosAltaRutaAerea", camposValores);
            */
            if (senderGrid.Columns[index] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                if (index == senderGrid.Columns["Baja"].Index)
                {
                    if ((bool)senderGrid.CurrentCell.Value)
                        senderGrid.CurrentCell.Value = false;
                    else
                        senderGrid.CurrentCell.Value = true;
                  //  MessageBox.Show("Eliminar columna" + senderGrid.CurrentRow.Cells["Ciudad Origen"].Value.ToString());
                }

                /*else if (index == senderGrid.Columns["Modificar"].Index)
                {
                    MessageBox.Show("Modificar columna" + senderGrid.CurrentRow.Cells["Ciudad Origen"].Value.ToString());
                    var formAltaRuta = new FormAltaRuta();
                    formAltaRuta.setId((int)senderGrid.CurrentRow.Cells["id ruta"].Value); 
                    formAltaRuta.setCodRuta(senderGrid.CurrentRow.Cells["Codigo de ruta"].Value.ToString());
                    formAltaRuta.setOrigen((int)senderGrid.CurrentRow.Cells["id origen"].Value - 1);
                    formAltaRuta.setDestino((int)senderGrid.CurrentRow.Cells["id destino"].Value - 1);
                    formAltaRuta.setServicio((int)senderGrid.CurrentRow.Cells["id servicio"].Value - 1);
                    formAltaRuta.setPrecioBasePeso(Double.Parse(senderGrid.CurrentRow.Cells["Precio base por peso"].Value.ToString()));
                    formAltaRuta.setPrecioBasePasaje(Double.Parse(senderGrid.CurrentRow.Cells["Precio base por pasaje"].Value.ToString()));
                    formAltaRuta.actualizarLabels();
                    formAltaRuta.esModificacion();
                    formAltaRuta.Show();
                    //((DataRowView)rutaAereaBindingSource.Current)
                }*/
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
           /* var camposValores = gdDataBase.newParameters();
            camposValores.Add("codigos_validos", new gdDataBase.ValorTipo(filasCheckBoxMarcados(), SqlDbType.Structured));
            camposValores.Add("codigo_de_compra", new gdDataBase.ValorTipo(textBoxPNR.Text, SqlDbType.NVarChar));
            new gdDataBase().Exec("Sarlomps", camposValores, new Dictionary<int, string>());*/

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
