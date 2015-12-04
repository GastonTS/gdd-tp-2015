using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm
{
    public partial class Alta : Form

    {

        string _MsgError="Hijo de puta implementa el mensaje de error";
        [Category("Mensajes"), Description("Texto que se muestra en caso de error."), EditorBrowsable(EditorBrowsableState.Always)]
        public virtual string MsgError
        {
            get { return _MsgError; }
            set { _MsgError = value; }
        }

        string _MsgExito = "Hijo de puta implementa el mensaje de exito";
        [Category("Mensajes"), Description("Texto que se muestra en caso de error."), EditorBrowsable(EditorBrowsableState.Always)]
        public virtual string MsgExito
        {
            get { return _MsgExito; }
            set { _MsgExito = value; }
        }

        protected virtual void guardarPosta() { throw new Exception("Implementa como guardar hijo de puta"); }

        public Alta()
        {
            InitializeComponent();
        }

        protected virtual Boolean validar() 
        {
            return ValidateChildren(ValidationConstraints.TabStop);
        }

        public void guardar()
        {
            if (this.validar())
            {
                this.guardarPosta();
            }
            else
            {
                foreach (Control unControl in Controls)
                {
                    unControl.Refresh();
                }
                MessageBox.Show(MsgError);
            }
        }

       
    }
}
