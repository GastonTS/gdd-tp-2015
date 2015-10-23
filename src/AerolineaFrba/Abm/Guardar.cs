using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class Guardar : UserControl
    {
        
        public Guardar(){
            InitializeComponent();            
       }

        private Alta alta(){
            return (Alta)FindForm();
        }
        
        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (alta().ValidateChildren(ValidationConstraints.TabStop))
            {
                MessageBox.Show(alta().MsgExito);
            }
            else
            {
                foreach (Control unControl in Controls)
                {
                    unControl.Refresh();
                }
                MessageBox.Show(alta().MsgError);
            }
        }
    }
}
