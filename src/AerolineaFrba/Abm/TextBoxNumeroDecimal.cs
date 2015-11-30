using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class TextBoxNumeroDecimal : AerolineaFrba.Abm.TextBoxValidado
    {
        public TextBoxNumeroDecimal()
        {
            InitializeComponent();
        }

        

        protected override String validationRegexString()
        {
            return "[0-9]+[,|.]?[0-9]+";
        }

        override protected void formatear(object sender, System.EventArgs e)
        {
            formatear();

            //decimal d = decimal.Parse(textBox1.Text, System.Globalization.NumberStyles.Currency, MyNFI);
        }

        public void formatear(){
    Double value;
            if (Double.TryParse(textBox1.Text, out value))
                textBox1.Text = String.Format(new System.Globalization.CultureInfo("es-AR"), "{0:C2}", value);
            else if (new Regex("^[$]" + this.validationRegexString()).IsMatch(textBox1.Text))
            {
                textBox1.Text = textBoxSinSignoPeso();
                formatear();
            }
            else
                textBox1.Text = String.Empty;

            System.Globalization.NumberFormatInfo MyNFI = new System.Globalization.NumberFormatInfo();
            MyNFI.NegativeSign = "-";
            MyNFI.CurrencyDecimalSeparator = ",";
            MyNFI.CurrencyGroupSeparator = ".";
            MyNFI.CurrencySymbol = "$";
}

        private String textBoxSinSignoPeso()
        {
           return  textBox1.Text.Remove(0, 1);
        }

        public Decimal DecimalValue()
        { // HACK
            var currencytextbox = new CurrencyTextBox();
            if (textBox1.Text == "")
                currencytextbox.Text = "0";
            else{
                formatear();
                currencytextbox.Text = textBoxSinSignoPeso();
            }
            return currencytextbox.DecimalValue;
        }


    }
}
