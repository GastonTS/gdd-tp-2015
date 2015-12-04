using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class FormListadoEstadistico : Form
    {

        private Dictionary<int, String> mapIndicesNombresTop5 = new Dictionary<int,string>();
        private Dictionary<String,gdDataBase.ValorTipo> datosListadoActual = new Dictionary<String,gdDataBase.ValorTipo>();
        private Dictionary<int, String> mapIndicesDetallesTop5 = new Dictionary<int, string>();
        int indiceListadoActual;

        public FormListadoEstadistico()
        {
            InitializeComponent();
            var yearList = Enumerable.Range(DateTime.Today.Year - 15, 18).ToList();
            yearList.Reverse();
            comboBoxAño.DataSource = yearList;
            dataGridViewListado.DataSource = bindingSourceListado;
            mapIndicesNombresTop5.Add(0,"[ÑUFLO].TOP5DiasFueraDeServicio");
            mapIndicesNombresTop5.Add(1,"[Ñuflo].TOP5DestinoPasajesComprados");
            mapIndicesNombresTop5.Add(2,"[ÑUFLO].TOP5DestinoAeronavesVacias");
            mapIndicesNombresTop5.Add(3,"[ÑUFLO].TOP5DestinoCancelaciones");
            mapIndicesNombresTop5.Add(4, "[ÑUFLO].TOP5MillasDeClientes");
            mapIndicesDetallesTop5.Add(0, "[ÑUFLO].DetallePasajePara");
            mapIndicesDetallesTop5.Add(1, "[ÑUFLO].DetallePasajePara");
            mapIndicesDetallesTop5.Add(2, "[ÑUFLO].DetallePasajePara");
            mapIndicesDetallesTop5.Add(3, "[ÑUFLO].DetallePasajePara");
            mapIndicesDetallesTop5.Add(4, "[ÑUFLO].DetallePasajePara");
            comboBoxListado.SelectedIndex = 0;
            
            datosListadoActual.Add("id",new gdDataBase.ValorTipo());
            datosListadoActual.Add("fecha_inicio",new gdDataBase.ValorTipo());
            datosListadoActual.Add("fecha_fin", new gdDataBase.ValorTipo());
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private DateTime calcularFecha(int anio, int semestre)
        {
            return new DateTime(anio, semestre * 6 + 1, 1);
        }

        private int semestre()
        {
            if (radioBtnPrimerSemestre.Checked) return 0;
            else return 1;
        }

        private int anio() {
            return Convert.ToInt32(comboBoxAño.SelectedValue);
        }

        private DateTime fechaInicial(){
            return calcularFecha(this.anio(), this.semestre());
        }
        private DateTime fechaFinal()
        {
            return fechaInicial().AddMonths(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fecha_inicio = fechaInicial().Date.ToString("yyyy-MM-dd hh:mm:ss.000");
            var fecha_fin = fechaFinal().Date.ToString("yyyy-MM-dd hh:mm:ss.000");
            datosListadoActual["fecha_inicio"] = new gdDataBase.ValorTipo(fecha_inicio, SqlDbType.DateTime);
            datosListadoActual["fecha_fin"] = new gdDataBase.ValorTipo(fecha_fin, SqlDbType.DateTime);
            indiceListadoActual = comboBoxListado.SelectedIndex;
            var nombre_sp = mapIndicesNombresTop5[comboBoxListado.SelectedIndex];
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(fecha_inicio, SqlDbType.DateTime));
            camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(fecha_fin, SqlDbType.DateTime));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            dataGridViewListado.DataSource = new gdDataBase().ExecAndGetData(nombre_sp, camposValores, errorMensaje);

            this.dataGridViewListado_RowEnter(sender, new DataGridViewCellEventArgs(0,0));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void actualizarDetalle(DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada;
            if (dataGridViewListado.Rows.Count == 0) return;
            filaSeleccionada = dataGridViewListado.Rows[e.RowIndex];
            datosListadoActual["id"] = new gdDataBase.ValorTipo(filaSeleccionada.Cells[0].Value, SqlDbType.NVarChar);
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("ciudad", datosListadoActual["id"]);
            camposValores.Add("fecha_inicio", datosListadoActual["fecha_inicio"]);
            camposValores.Add("fecha_fin", datosListadoActual["fecha_fin"]);
            dataGridView1.DataSource = new gdDataBase().ExecAndGetData(mapIndicesDetallesTop5[indiceListadoActual], camposValores); 
        }

        private void dataGridViewListado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            actualizarDetalle(e);
        }



    }
}
