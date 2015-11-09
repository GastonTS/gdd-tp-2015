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


        public FormListadoEstadistico()
        {
            InitializeComponent();
            upDownAnio.Minimum = DateTime.Today.Year - 100;
            upDownAnio.Maximum = DateTime.Today.Year + 100;
            upDownAnio.Value = DateTime.Today.Year;
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
            dataGridViewListado.DataSource = bindingSourceListado;
            var fecha_inicio = fechaInicial().Date.ToString("yyyy/MM/dd");
            var fecha_fin = fechaFinal().Date.ToString("yyyy/MM/dd");
            MessageBox.Show("Select * from [Ñuflo].TOP5DestinoPasajesComprados(" + fecha_inicio + "," + @fecha_fin + ")");
            new gdDataBase().cargarListadoEstadistico(bindingSourceListado, "Select * from [Ñuflo].TOP5DestinoPasajesComprados("+fecha_inicio+","+ @fecha_fin+")");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
