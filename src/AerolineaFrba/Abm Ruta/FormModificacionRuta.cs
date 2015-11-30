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
    public partial class FormModificacionRuta : Abm.FormReloaded
    {
        public FormModificacionRuta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormModificacionRuta_Load(object sender, EventArgs e)
        {

            var ds = new gdDataBase().ExecAndGetDataSet("CiudadTipoServicio");

            DataTable ciudades = ds.Tables[0];
            var filaExtraCiudad = ciudades.NewRow();
            filaExtraCiudad["Nombre"] = " Cualquiera";
            ciudades.Rows.InsertAt(filaExtraCiudad,0);

            DataTable servicios = ds.Tables[1];
            var filaExtraServicios = servicios.NewRow();
            filaExtraServicios["Tipo Servicio"] = "Cualquiera";
            servicios.Rows.InsertAt(filaExtraServicios, 0);


            origenBindingSource.DataSource = ciudades;
            destinoBindingSource.DataSource = ciudades;            
            tipoServicioBinding.DataSource = servicios;

            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.ValueMember = "Id ciudad";
            comboBoxTipoServicio.DisplayMember = "Tipo Servicio";
            comboBoxTipoServicio.ValueMember = "Id Tipo Servicio";
            
            
            dataGridView1.AutoGenerateColumns = true; 
            rutaAereaBindingSource.DataSource = new gdDataBase().ExecAndGetDataSet("FiltrosModificacionRutaAerea").Tables[0];
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id ruta"].Visible = false;
            dataGridView1.Columns["id destino"].Visible = false;
            dataGridView1.Columns["id origen"].Visible = false;


            new List<String> { "Eliminar", "Modificar" }.ForEach(column =>
            {
                dataGridView1.Columns[column].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[column].Frozen = true;
            });
            
        }

        
        private void consultarConFiltro()
        {
         
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            agregarValorCBADiccionario(comboBoxOrigen, camposValores, "id_ciudad_origen", SqlDbType.Int);

            agregarValorCBADiccionario(comboBoxDestino, camposValores, "id_ciudad_destino", SqlDbType.Int);

            agregarValorCBADiccionario(comboBoxTipoServicio, camposValores, "id_tipo_servicio", SqlDbType.Int);

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltrosModificacionRutaAerea", camposValores);

            rutaAereaBindingSource.DataSource = ds;
            dataGridView1.DataSource = rutaAereaBindingSource;
        }

        private void cambioAlgunFiltro(object sender, EventArgs e)
        {
            consultarConFiltro();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var index = e.ColumnIndex;
            var camposValores = new Dictionary<String, gdDataBase.ValorTipo>();
            camposValores.Add("nombre_origen",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["Ciudad origen"].Value, SqlDbType.NVarChar));
            camposValores.Add("nombre_destino",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["Ciudad destino"].Value, SqlDbType.NVarChar));
            camposValores.Add("tipo_servicio",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["Tipo de servicio"].Value, SqlDbType.NVarChar));
            var selectedRowData = new gdDataBase().GetDataWithParameters("ÑUFLO.FiltrosAltaRutaAerea", camposValores);

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
                    var formAltaRuta = new FormAltaRuta();
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
                }
                else ;
            }
        }


    }
}
