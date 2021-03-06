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
    public partial class FormPrincipal : Form
    {
        public Dictionary<int, ToolStripMenuItem> ids_funcionalidades = new Dictionary<int, ToolStripMenuItem>();

        public FormPrincipal()
        {
            InitializeComponent();
            ids_funcionalidades.Add(1, aBMRolToolStripMenuItem);
            ids_funcionalidades.Add(2, aBMRutaToolStripMenuItem);
            ids_funcionalidades.Add(3, aBMAeronaveToolStripMenuItem);
            ids_funcionalidades.Add(4, generarViajeToolStripMenuItem);
            ids_funcionalidades.Add(5, registroDeLlegadaToolStripMenuItem);
            ids_funcionalidades.Add(6, comprarViajeToolStripMenuItem);
            ids_funcionalidades.Add(7, devoluciónToolStripMenuItem);
            ids_funcionalidades.Add(8, consultaMillasToolStripMenuItem);
            ids_funcionalidades.Add(9, canjeToolStripMenuItem);
            ids_funcionalidades.Add(10, listadoEstadísticoToolStripMenuItem);
        }

        public void resetearFuncionalidades() 
        {
            foreach (ToolStripMenuItem menuFuncion in menuStrip1.Items) 
            {
                
                menuFuncion.Visible = false;
            }
            loginToolStripMenuItem.Visible = true;
           
        }

        public void activarFuncionalidad(int idFuncion) 
        {
            if (idFuncion == 8 || idFuncion == 9) millasToolStripMenuItem.Visible = true;
            ids_funcionalidades[idFuncion].Visible = true;
        }

        private void activarFuncionalidadesDeKiosco()
        {
            var camposValores = gdDataBase.newParameters();

            camposValores.Add("nombre_rol", new gdDataBase.ValorTipo("Cliente", SqlDbType.NVarChar));

            var funciones = new gdDataBase().ExecAndGetData("ÑUFLO.FuncionalidadesDe", camposValores, new Dictionary<int, String>()).Rows;
            resetearFuncionalidades();

            foreach (DataRow funcion in funciones)
            {
                activarFuncionalidad((int)funcion["id_funcionalidad"]);
            }

            /*foreach (var funcionalidad in ids_funcionalidades)
            {
                if (funcionalidad.Key == 6 || funcionalidad.Key == 8 || funcionalidad.Key == 9)
                {
                    ToolStripMenuItem menuFuncion = funcionalidad.Value;
                    menuFuncion.Visible = true;
                }
            }*/
        }

        public void habilitarFormulario()
        {
            menuStrip1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (Config.terminal != "desarrollo")
            {
                if (Config.terminal == "administrativa")
                {
                    var login = new Registro_de_Usuario.Login();

                    menuStrip1.Enabled = false;

                    login.MdiParent = this;

                    login.setPadre(this);
                    login.Show();
                }
                else
                {
                    //funcionalidades de kiosco o autoservicio
                    resetearFuncionalidades();
                    activarFuncionalidadesDeKiosco();
                }
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormAltaRol formularioAltaRol = new Abm_Rol.FormAltaRol();

            formularioAltaRol.MdiParent = this;

            formularioAltaRol.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.FormSeleccionAeronave formularioSeleccionAeronave = new Abm_Aeronave.FormSeleccionAeronave();

            formularioSeleccionAeronave.MdiParent = this;

            formularioSeleccionAeronave.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormAltaRol formularioAltaRol = new Abm_Rol.FormAltaRol();

            formularioAltaRol.MdiParent = this;

            formularioAltaRol.Show();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.FormSeleccionRol fsr = new Abm_Rol.FormSeleccionRol();

            fsr.MdiParent = this;

            fsr.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Abm_Ruta.FormAltaRuta formularioAltaRuta = new Abm_Ruta.FormAltaRuta();

            formularioAltaRuta.MdiParent = this;

            formularioAltaRuta.Show();
        }

        private void modificaciónYBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Ruta.FormModificacionRuta formularioModificacionRuta = new Abm_Ruta.FormModificacionRuta();

            formularioModificacionRuta.MdiParent = this;

            formularioModificacionRuta.Show();
        }

        private void comprarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.FormSeleccionViaje formularioCompraViaje = new Compra.FormSeleccionViaje();

            formularioCompraViaje.MdiParent = this;

            formularioCompraViaje.Show();
        }

        private void canjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canje_Millas.FormCajeMillasPasajero formularioCanjeMillas = new Canje_Millas.FormCajeMillasPasajero();

            formularioCanjeMillas.MdiParent = this;

            formularioCanjeMillas.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Millas.FormConsultaMillas formularioConsultaMillas = new Consulta_Millas.FormConsultaMillas();

            formularioConsultaMillas.MdiParent = this;

            formularioConsultaMillas.Show();
        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.FormGenerarViaje formularioGenerarViaje = new Generacion_Viaje.FormGenerarViaje();

            formularioGenerarViaje.MdiParent = this;

            formularioGenerarViaje.Show();
        }

        private void registroDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Llegada_Destino.FormRegistrarLlegadas formularioRegistrarLlegadas = new Registro_Llegada_Destino.FormRegistrarLlegadas();

            formularioRegistrarLlegadas.MdiParent = this;

            formularioRegistrarLlegadas.Show();
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion.Devolucion formularioDevolucion = new Devolucion.Devolucion();

            formularioDevolucion.MdiParent = this;

            formularioDevolucion.Show();
        }

        private void bajaPasajeEncomiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion.Devolucion formularioBajaPasajeEncomienda = new Devolucion.Devolucion();

            formularioBajaPasajeEncomienda.MdiParent = this;

            formularioBajaPasajeEncomienda.Show();
        }

        private void listadoEstadísticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.FormListadoEstadistico formularioListadoEstadistico = new Listado_Estadistico.FormListadoEstadistico();

            formularioListadoEstadistico.MdiParent = this;

            formularioListadoEstadistico.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Registro_de_Usuario.Login();

            login.MdiParent = this;

            login.setPadre(this);
            login.Show();
        }

        private void altaAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.FormAltaAeronave formularioAltaAeronave = new Abm_Aeronave.FormAltaAeronave();

            formularioAltaAeronave.MdiParent = this;

            formularioAltaAeronave.Show();
        }
    }

}
