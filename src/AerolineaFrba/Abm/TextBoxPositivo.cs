using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm
{
    class TextBoxPositivo : TextBoxNumeros
    {
        protected override bool criterioValidacion()
        {
            if (base.criterioValidacion())
                return Convert.ToInt32(textBox1.Text) > 0;
            else
                return false;
        }
    }
}
