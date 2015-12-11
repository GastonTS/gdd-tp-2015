using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm
{
    class TextBoxPositivo : TextBoxDecimal
    {
        protected override bool criterioValidacion()
        {
            if (base.criterioValidacion())
                return Double.Parse(textBox1.Text) > 0;
            else
                return false;
        }
    }
}
