using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Usuario
    {
        public void sarasa()
        {
            foreach (Control control in Controls)
            {
                Message.Show(control.text);
            }
        }
    }
}
