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
            
            new gdDataBase().actualizarComboBox(comboBoxTipoServicio, "SELECT DISTINCT tipo_servicio FROM [ÑUFLO].Ruta_Aerea");
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ruta_Aerea' Puede moverla o quitarla según sea necesario.
            this.ruta_AereaTableAdapter.Fill(this.gD2C2015DataSet.Ruta_Aerea);
            
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.gD2C2015DataSet.Ciudad);

            new gdDataBase().actualizarDataGridView(dataGridRuta,this.queryFiltros());

        }

        private String queryFiltros()
        {
            return "SELECT * FROM [ÑUFLO].Ruta_Aerea "+"WHERE tipo_servicio = "+filtros()[0];
        }

        private List<String> filtros()
        {
            return new List<ComboBox>{ comboBoxTipoServicio, comboBoxDestino, comboBoxOrigen }.Select(control => "'"+control.SelectedValue.ToString()+"'").ToList();
        }

        private void comboBoxTipoServicio_MouseClick(object sender, MouseEventArgs e)
        {
            new gdDataBase().actualizarDataGridView(dataGridRuta, this.queryFiltros());
        }

        private void comboBoxTipoServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            new gdDataBase().actualizarDataGridView(dataGridRuta, this.queryFiltros());
        }


    }
}
