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

            comboBoxProducto.Enabled = false;
            textBoxCantidadProducto.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            if (textBoxDni.Text.Trim() != "")
            {
                camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Decimal));

                var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ProductosDe", camposValores);
                comboBoxProducto.DataSource = dt;
                comboBoxProducto.DisplayMember = dt.Columns[0].ColumnName;

                comboBoxProducto.Enabled = true;
                textBoxCantidadProducto.Enabled = true;
            }
        }
    }
}
