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
        
        [Category("Apariencia"), Description("Texto del boton."), EditorBrowsable(EditorBrowsableState.Always)]
        public string TextBtn
        {
            get { return guardarBtn.Text; }
            set { guardarBtn.Text = value; }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            guardarBtn.Size = this.Size;
        }

        public Guardar(){
            
            InitializeComponent();
       }

        private Alta alta(){
            return (Alta)FindForm();
        }
        
        private void guardarBtn_Click(object sender, EventArgs e)
        {
                alta().guardar();
        }
    }
}
