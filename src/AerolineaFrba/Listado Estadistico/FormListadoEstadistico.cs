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
            upDownAnio.Minimum = DateTime.Today.Year - 100;
            upDownAnio.Maximum = DateTime.Today.Year + 100;
            upDownAnio.Value = DateTime.Today.Year;
            dataGridViewListado.DataSource = bindingSourceListado;
            mapIndicesNombresTop5.Add(0,"[ÑUFLO].TOP5DiasFueraDeServicio");
            mapIndicesNombresTop5.Add(1,"[Ñuflo].TOP5DestinoPasajesComprados");
            mapIndicesNombresTop5.Add(2,"[ÑUFLO].TOP5DestinoAeronavesVacias");
            mapIndicesNombresTop5.Add(3,"[ÑUFLO].TOP5DestinoCancelaciones");
            mapIndicesNombresTop5.Add(4,"[ÑUFLO].MillasDeClientes");
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
            return Convert.ToInt32(upDownAnio.Value);
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
            var nombre_funcion = mapIndicesNombresTop5[comboBoxListado.SelectedIndex];
            new gdDataBase().cargarListadoEstadistico(bindingSourceListado, "Select * from "+nombre_funcion+"(\'" + fecha_inicio + "\',\'" + fecha_fin + "\')");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
