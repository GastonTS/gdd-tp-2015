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
            var nombre_sp = mapIndicesNombresTop5[comboBoxListado.SelectedIndex];
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("fecha_inicio", new gdDataBase.ValorTipo(fecha_inicio, SqlDbType.DateTime));
            camposValores.Add("fecha_fin", new gdDataBase.ValorTipo(fecha_fin, SqlDbType.DateTime));

            errorMensaje.Add(2627, "Ingresó una matrícula de aeronave ya registrada. Intente nuevamente...");

            dataGridViewListado.DataSource = new gdDataBase().ExecAndGetData(nombre_sp, camposValores, errorMensaje);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
