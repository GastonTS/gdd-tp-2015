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
    public partial class TextBoxDecimal : TextBoxValidado
    {
        public TextBoxDecimal()
        {
            InitializeComponent();
        }

        override protected void formatear(object sender, System.EventArgs e)
        {
            formatear();

            //decimal d = decimal.Parse(textBox1.Text, System.Globalization.NumberStyles.Currency, MyNFI);
        }

        public virtual void formatear()
        {
            Double value;
            if (Double.TryParse(textBox1.Text, out value))
                textBox1.Text = value.ToString("F");
        }

        protected override String validationRegexString()
        {
            return "[0-9]+[,|.]?[0-9]+";
        }

        virtual public Decimal DecimalValue()
        { // HACK
            var currencytextbox = new CurrencyTextBox();
            if (textBox1.Text == "")
                currencytextbox.Text = "0";
            return currencytextbox.DecimalValue;
        }

    }
}
