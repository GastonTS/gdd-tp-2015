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

            var ds = new gdDataBase().ExecAndGetDataSet("ÑUFLO.CiudadTipoServicio");

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
            rutaAereaBindingSource.DataSource = new gdDataBase().ExecAndGetDataSet("ÑUFLO.FiltrosModificacionRutaAerea").Tables[0];
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id ruta"].Visible = false;
            dataGridView1.Columns["id destino"].Visible = false;
            dataGridView1.Columns["id origen"].Visible = false;
            dataGridView1.Columns["id servicio"].Visible = false;


            new List<String> { "Eliminar", "Modificar" }.ForEach(column =>
            {
                dataGridView1.Columns[column].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns[column].Frozen = true;
            });
            
        }

        
        public void consultarConFiltro()
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

            if (senderGrid.Columns[index] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (index == senderGrid.Columns["Eliminar"].Index)
                {
                    var camposValores = gdDataBase.newParameters();
                    Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                    camposValores.Add("id_ruta",new gdDataBase.ValorTipo(senderGrid.CurrentRow.Cells["id ruta"].Value,SqlDbType.Int));
                    camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

                    errorMensaje.Add(0, "Ignorar errores");

                    var resultadoEjecucion = new gdDataBase().Exec("ÑUFLO.DeleteRutaAerea",camposValores,errorMensaje,"El registro ha sido eliminado correctamente");

                    if (resultadoEjecucion.huboError())
                    {
                        if (resultadoEjecucion.codError() == 60035)
                            MessageBox.Show("Algunos vuelos de la Ruta ya fueron realizados, dichos vuelos no seran cancelados", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                            resultadoEjecucion.mostrarErrorSqlProducido();
                    }

                    consultarConFiltro();
                }

                else if (index == senderGrid.Columns["Modificar"].Index)
                {
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
                    formAltaRuta.setPadre(this);
                    formAltaRuta.Show();
                    //((DataRowView)rutaAereaBindingSource.Current)
                }
                else ;
            }
        }


    }
}
