using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AerolineaFrba.Abm
{
    public partial class TextBoxValidado : UserControl
    
{
        
        string _ErrorText;
        [Category("Wololo"), Description("Texto que se muestra en el error."), EditorBrowsable(EditorBrowsableState.Always)]
        public string ErrorText
        {
            get { return _ErrorText; }
            set { _ErrorText = value; }
        }

        public TextBoxValidado()
        {
            InitializeComponent();
        }

        protected virtual String validationRegexString()
        {
            return ".+";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {

            if (new Regex(this.validationRegexString()).IsMatch(textBox1.Text.Trim()))
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, ErrorText);
                e.Cancel = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
