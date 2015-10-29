using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class TextBoxValidado : UserControl
    {
        public TextBoxValidado()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Debe ingresar un nombre de Rol");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
