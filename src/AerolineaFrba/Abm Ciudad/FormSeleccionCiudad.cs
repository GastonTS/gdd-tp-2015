using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class FormSeleccionCiudad : Form
    {
        public FormSeleccionCiudad()
        {
            InitializeComponent();
        }

        private void FormSeleccionCiudad_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new gdDataBase().GetDataQuery("SELECT * FROM [ÑUFLO].Ciudad"); ;
            ciudadBindingSource.DataSource = dataSet.Tables[0];
            //ciudadBindingSource.DataMember = dataSet.Tables[0].TableName;
            
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ruta_Aerea' Puede moverla o quitarla según sea necesario.
            //this.ruta_AereaTableAdapter.Fill(this.gD2C2015DataSet.Ruta_Aerea);
                                
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            //this.ciudadTableAdapter.Fill(this.gD2C2015DataSet.Ciudad);
            //new gdDataBase().actualizarDataGridView(dataGridView1, "Ciudad", "SELECT * FROM [ÑUFLO].Ciudad");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
