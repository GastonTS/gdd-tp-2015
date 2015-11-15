using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class FormModificacionRuta : Form
    {
        public FormModificacionRuta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String rutasAereasQuery()
        {
            return "SELECT ra.codigo_ruta AS 'Código Ruta', co.nombre AS 'Ciudad Origen', cd.nombre AS 'Ciudad Destino', ra.precio_base_por_peso AS 'Precio base x peso', ra.precio_base_por_pasaje AS 'Precio base x pasaje' FROM [ÑUFLO].RutaAerea ra,[ÑUFLO].Ciudad co,[ÑUFLO].Ciudad cd,[ÑUFLO].ServicioPorRuta spr WHERE ra.id_ciudad_origen=co.id_ciudad AND ra.id_ciudad_destino=cd.id_ciudad AND spr.id_ruta = ra.id_ruta";
        }

        private void FormModificacionRuta_Load(object sender, EventArgs e)
        {

            var ds = new gdDataBase().GetDataQuery("ÑUFLO.DestinoOrigen SELECT id_tipo_servicio 'Id Tipo Servicio', tipo_servicio 'Tipo Servicio', porcentaje_recargo 'Porcentaje Recargo' FROM ÑUFLO.TipoServicio " + rutasAereasQuery());

            origenBindingSource.DataSource = ds.Tables[1];
            destinoBindingSource.DataSource = ds.Tables[1];
            tipoServicioBinding.DataSource = ds.Tables[2];
            rutaAereaBindingSource.DataSource = ds.Tables[3];
            

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
            dataGridView1.AutoGenerateColumns = true; 
            new List<String> { "Eliminar", "Modificar" }.ForEach(column =>
            {
                dataGridView1.Columns[column].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[column].Frozen = true;
            });
            
            
        }

        private String queryFiltros()
        {
            return "SELECT * FROM [ÑUFLO].RutaAerea "+"WHERE id_servicio = "+filtros()[0];
        }
        
        private List<String> filtros()
        {
            return new List<ComboBox>{ comboBoxTipoServicio, comboBoxDestino, comboBoxOrigen }.Select(control => "'"+control.SelectedValue.ToString()+"'").ToList();
        }

        private void queryFoo()
        {
            new gdDataBase().actualizarBindingSourceQuery(rutaAereaBindingSource, rutasAereasQuery() + " AND ra.id_ciudad_destino=" + "'" + comboBoxDestino.SelectedValue.ToString() + "'" + " AND ra.id_ciudad_origen=" + "'" + comboBoxOrigen.SelectedValue.ToString() + "'" + " AND spr.id_tipo_servicio=" + "'" + comboBoxTipoServicio.SelectedValue.ToString() + "'");
        }
        private void comboBoxOrigen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            queryFoo();
        }

        private void comboBoxDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            queryFoo();
        }

        private void comboBoxTipoServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            queryFoo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var index = e.ColumnIndex;


            if (senderGrid.Columns[index] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (index == senderGrid.Columns["Eliminar"].Index)
                {
                    MessageBox.Show("Eliminar columna" + senderGrid.CurrentRow.Cells["Ciudad Origen"].Value.ToString());
                }

                else if (index == senderGrid.Columns["Modificar"].Index)
                {
                    MessageBox.Show("Modificar columna" + senderGrid.CurrentRow.Cells["Ciudad Origen"].Value.ToString());
                    new FormAltaRuta().Show();
                }
                else ;
            }
        }


    }
}
