using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FormDatosPasajeroEncomienda : Abm.Alta
    {
        public FormDatosPasajeroEncomienda()
        {
            InitializeComponent();
        }

        private void checkBoxModificarDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificarDatos.Checked)
                habilitacionDatosCliente(true);
            else
                habilitacionDatosCliente(false);
        }

        private void habilitacionDatosCliente(bool estado)
        {
            textBoxNombre.Enabled = estado;
            textBoxTelefono.Enabled = estado;
            textBoxMail.Enabled = estado;
            textBoxApellido.Enabled = estado;
            dateTimeFechaNacimiento.Enabled = estado;
            textBoxDireccion.Enabled = estado;
            btnActualizar.Enabled = estado;
        }
    }
}
