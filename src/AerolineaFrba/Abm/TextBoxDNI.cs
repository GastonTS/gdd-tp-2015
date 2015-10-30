using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class TextBoxDNI : AerolineaFrba.Abm.TextBoxValidado
    {
        public TextBoxDNI()
        {
            InitializeComponent();
        }

        protected override String validationRegexString()
        {
            return "[0-9]{7,8}";
        }
    }
}
