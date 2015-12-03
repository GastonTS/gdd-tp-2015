using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class TextBoxMail : AerolineaFrba.Abm.TextBoxValidado
    {
        public TextBoxMail()
        {
            InitializeComponent();
        }

        protected override String validationRegexString()
        {
            return "(.+@.+[.].+)?";
        }
    }
}
