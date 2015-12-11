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
    public partial class TextBoxMoneda : AerolineaFrba.Abm.TextBoxDecimal
    {
        public TextBoxMoneda()
        {
            InitializeComponent();
        }




        override protected Boolean criterioValidacion()
        {
            return textBox1.Text!="";
        }

        override public void formatear(){
    Double value;
    if (Double.TryParse(textBox1.Text, out value))
    {

        System.Globalization.NumberFormatInfo MyNFI = new System.Globalization.NumberFormatInfo();
        MyNFI.NegativeSign = "-";
        MyNFI.CurrencyDecimalSeparator = ",";
        MyNFI.CurrencyGroupSeparator = ".";
        MyNFI.CurrencySymbol = "$";
        textBox1.Text = String.Format(MyNFI, "{0:C2}", value);
    }
    else if (new Regex("^[$]" + this.validationRegexString()).IsMatch(textBox1.Text))
    {
        textBox1.Text = textBoxSinSignoPeso();
        formatear();
    }
    else
        textBox1.Text = String.Empty;

}

        private String textBoxSinSignoPeso()
        {
           return  textBox1.Text.Remove(0, 1);
        }



        public override Decimal DecimalValue()
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
