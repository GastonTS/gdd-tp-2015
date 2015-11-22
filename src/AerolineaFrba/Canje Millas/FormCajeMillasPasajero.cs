using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class FormCajeMillasPasajero : Form
    {
        public FormCajeMillasPasajero()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDni.Text = "";
            textBoxCantidadProducto.Text = "";
            comboBoxProducto.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
