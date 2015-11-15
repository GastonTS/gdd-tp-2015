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


        public event EventHandler TextboxTextChanged;


        protected void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextboxTextChanged != null)
            {
                TextboxTextChanged(this, e);
            }
        }

        new public event EventHandler Leave;


        protected void textBox1_Leave(object sender, EventArgs e)
        {
            formatear(sender, e);
            if (Leave != null)
            {
                Leave(this, e);
            }
        }

        virtual protected void formatear(object sender, System.EventArgs e)
        {

        }

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


        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {

            if (new Regex("^" + this.validationRegexString() + "$").IsMatch(textBox1.Text.Trim()))
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

        public void Clear()
        {
            textBox1.Clear();
        }

        override public string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_EnabledChanged(object sender, EventArgs e)
        {
            textBox1.CausesValidation = textBox1.Enabled;
        }

        private void TextBoxValidado_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
