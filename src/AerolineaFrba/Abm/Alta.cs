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

        string _MsgError="";
        [Category("Mensajes"), Description("Texto que se muestra en caso de error."), EditorBrowsable(EditorBrowsableState.Always)]
        public virtual string MsgError
        {
            get { return _MsgError; }
            set { _MsgError = value; }
        }

        string _MsgExito="";
        [Category("Mensajes"), Description("Texto que se muestra en caso de error."), EditorBrowsable(EditorBrowsableState.Always)]
        public virtual string MsgExito
        {
            get { return _MsgExito; }
            set { _MsgExito = value; }
        }


        public Alta()
        {
            InitializeComponent();
        }

        protected void guardar()
        {
            if (this.ValidateChildren(ValidationConstraints.TabStop))
            {
                MessageBox.Show("Crea Rol correctamente");
            }
            else
            {
                foreach (Control unControl in Controls)
                {
                    unControl.Refresh();
                }
                MessageBox.Show("Error al crear Rol. Ingresar los campos correctamente");
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

       
    }
}
