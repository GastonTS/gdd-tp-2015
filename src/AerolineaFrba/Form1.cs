﻿using System;
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

        public Dictionary<int, Object> ids_funcionalidades = new Dictionary<int, Object>();


        public Form1()
        {
            InitializeComponent();
            ids_funcionalidades.Add(0,btnAltaRol);
            ids_funcionalidades.Add(1, btnAltaCiudad);
            ids_funcionalidades.Add(2, btnAltaRuta);
            ids_funcionalidades.Add(3, btnAltaNave);
            ids_funcionalidades.Add(4, "generar viaje");
            ids_funcionalidades.Add(5, "registrar llegada");
            ids_funcionalidades.Add(6, "compra");
            ids_funcionalidades.Add(7, "cancelacion");
            ids_funcionalidades.Add(8, "consultar millas");
            ids_funcionalidades.Add(9, "canjear millas");
            ids_funcionalidades.Add(10, "listado estadistico");
            ids_funcionalidades.Add(11, "ABM productos");
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
            new Abm_Ciudad.FormAltaCiudad().Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            new Compra.FormCompraEfectiva().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Compra.FormDatosPasajeroEncomienda().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Registro_Llegada_Destino.FormRegistrarLlegadas().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Registro_Llegada_Destino.FormInformeYValidacion().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Generacion_Viaje.FormGenerarViaje().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Compra.FormDatosPasajeroEncomienda().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.FormListadoEstadistico().Show();
        }

        private void textBoxValidado1_Load(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new Devolucion.FormDevolucion().Show(); 
        }

              private void button15_Click(object sender, EventArgs e)
        {
            new Devolucion.FormBajaPasajeEncomienda().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            new Registro_de_Usuario.Login().Show();
        }

    }

}
