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

        private void btnAltaRol_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormAltaRol formularioAltaRol = new Abm_Rol.FormAltaRol();
            formularioAltaRol.Show();
        }

        private void btnAltaRuta_Click(object sender, EventArgs e)
        {
            Abm_Ruta.FormAltaRuta formularioAltaRuta = new Abm_Ruta.FormAltaRuta();
            formularioAltaRuta.Show();
        }

        private void btnModRol_Click_1(object sender, EventArgs e)
        {
            Abm_Rol.FormSeleccionRol fsr = new Abm_Rol.FormSeleccionRol();
            fsr.Show();
        }

        private void btnBajaRol_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormBajaRol fbr = new Abm_Rol.FormBajaRol();
            fbr.Show();
        }

        private void btnAltaNave_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.FormAltaAeronave faa = new Abm_Aeronave.FormAltaAeronave();
            faa.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaCiudad_Click(object sender, EventArgs e)
        {
            //Abm_Ciudad.FormAltaCiudad formularioAltaCiudad = new Abm_Ciudad.FormAltaCiudad();
            //formularioAltaCiudad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Ciudad.FormSeleccionCiudad fsc = new Abm_Ciudad.FormSeleccionCiudad();
            fsc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.FormModificacionRuta().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.FormSeleccionAeronave().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Canje_Millas.FormCajeMillasPasajero().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Consulta_Millas.FormConsultaMillas().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Compra.FormSeleccionViaje().Show();
        }
    }
}
