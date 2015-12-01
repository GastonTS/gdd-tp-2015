using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class FormRegistrarLlegadas : Form
    {
        public FormRegistrarLlegadas()
        {
            InitializeComponent();
            var ds = new gdDataBase().ExecAndGetDataSet("CiudadTipoServicio").Tables[0];
            origenBindingSource.DataSource = ds;
            destinoBindingSource.DataSource = ds;
            comboBoxOrigen.DisplayMember = "Nombre";
            comboBoxDestino.DisplayMember = "Nombre";
            comboBoxOrigen.ValueMember = "Id ciudad";
            comboBoxDestino.ValueMember = "Id ciudad";
        }

        private void FormRegistrarLlegadas_Load(object sender, EventArgs e)
        {


            
        }
    }
}
