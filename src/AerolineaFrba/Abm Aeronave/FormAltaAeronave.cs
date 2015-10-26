using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormAltaAeronave : Form
    {
        public FormAltaAeronave()
        {
            InitializeComponent();
        }

        private void btnElegirTipoButaca_Click(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = true;
            checkedListBox1.Items.Clear();

            if (textBoxCantidadButacas.Text != "")
            {
                for (int i = 0; i < Convert.ToInt32(textBoxCantidadButacas.Text); i++)
                {
                    checkedListBox1.Items.Add("Butaca N°: " + (i + 1));
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCantidadButacas.Clear();
            btnElegirTipoButaca.Enabled = false;

            textBoxCapacidadEncomiendas.Clear();
            textBoxFabricante.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();

            checkedListBox1.Items.Clear();
            checkedListBox1.Enabled = false;

            comboBoxTipoServicio.ResetText();
        }

        private void textBoxCantidadButacas_TextChanged(object sender, EventArgs e)
        {
            btnElegirTipoButaca.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
