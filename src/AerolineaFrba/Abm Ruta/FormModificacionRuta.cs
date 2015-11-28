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
            

            rutaAereaBindingSource.DataSource = new gdDataBase().ExecAndGetDataSet("FiltrosModificacionRutaAerea").Tables[0];
            

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

        
        private void consultarConFiltro()
        {
         
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            
            if(comboBoxOrigen.SelectedValue.ToString()!="")
            camposValores.Add("id_ciudad_origen", new gdDataBase.ValorTipo(comboBoxOrigen.SelectedValue.ToString(), SqlDbType.Int));

            if(comboBoxDestino.SelectedValue.ToString() != "")
            camposValores.Add("id_ciudad_destino", new gdDataBase.ValorTipo(comboBoxDestino.SelectedValue.ToString(), SqlDbType.Int));

            if (comboBoxTipoServicio.SelectedValue.ToString() != "")
            camposValores.Add("id_tipo_servicio", new gdDataBase.ValorTipo(comboBoxTipoServicio.SelectedValue.ToString(), SqlDbType.Int));

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
                    new FormAltaRuta(((DataRowView)rutaAereaBindingSource.Current)).Show();
                }
                else ;
            }
        }


    }
}
