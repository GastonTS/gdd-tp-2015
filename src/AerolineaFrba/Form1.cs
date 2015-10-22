using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormAltaRol formularioAltaRol = new Abm_Rol.FormAltaRol();
            formularioAltaRol.Show();
        }

        private void btnAltaRuta_Click(object sender, EventArgs e)
        {
            Abm_Ruta.FormAltaRuta formularioAltaRuta = new Abm_Ruta.FormAltaRuta();
            formularioAltaRuta.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Abm_Rol.FormSeleccionRol fsr = new Abm_Rol.FormSeleccionRol();
            fsr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormBajaRol fbr = new Abm_Rol.FormBajaRol();
            fbr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.FormAltaAeronave faa = new Abm_Aeronave.FormAltaAeronave();
            faa.Show();
        }
    }
}
