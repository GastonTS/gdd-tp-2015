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
            return "SELECT ra.codigo_ruta AS 'Código Ruta', co.nombre AS 'Ciudad Origen', cd.nombre AS 'Ciudad Destino', ra.precio_base_por_peso AS 'Precio base x peso', ra.precio_base_por_pasaje AS 'Precio base x pasaje' FROM [ÑUFLO].RutaAerea ra,[ÑUFLO].Ciudad co,[ÑUFLO].Ciudad cd WHERE ra.id_ciudad_origen=co.id_ciudad AND ra.id_ciudad_destino=cd.id_ciudad";
        }

        private void FormModificacionRuta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.RutaAerea' Puede moverla o quitarla según sea necesario.
            dataGridView1.DataSource = rutaAereaBindingSource;
            new gdDataBase().actualizarBindingSourceQuery(rutaAereaBindingSource,rutasAereasQuery());
            new List<String> { "Eliminar", "Modificar" }.ForEach(column =>
            {
                dataGridView1.Columns[column].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[column].Frozen = true;
            });
            

            //new gdDataBase().actualizarDataGridView(dataGridView1, "SELECT * FROM [ÑUFLO].RutaAerea");
            
            new gdDataBase().actualizarComboBox(comboBoxTipoServicio, "SELECT tipo_servicio FROM [ÑUFLO].TipoServicio");
            
            
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.gD2C2015DataSet.Ciudad);
            

        }

        private String queryFiltros()
        {
            return "SELECT * FROM [ÑUFLO].RutaAerea "+"WHERE id_servicio = "+filtros()[0];
        }
        
        private List<String> filtros()
        {
            return new List<ComboBox>{ comboBoxTipoServicio, comboBoxDestino, comboBoxOrigen }.Select(control => "'"+control.SelectedValue.ToString()+"'").ToList();
        }

        private void comboBoxOrigen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            new gdDataBase().actualizarBindingSourceQuery(rutaAereaBindingSource, rutasAereasQuery() + " AND ra.id_ciudad_origen=" + "'" + comboBoxOrigen.SelectedValue.ToString() + "'");
        }

        


    }
}
