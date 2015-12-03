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
    public partial class FormPrincipal : Form
    {
        public Dictionary<int, ToolStripMenuItem> ids_funcionalidades = new Dictionary<int, ToolStripMenuItem>();

        public FormPrincipal()
        {
            //Con esto tengo líos. No se bien cómo y cuáles funcionalidades le corresponden a qué rol
            InitializeComponent();
            ids_funcionalidades.Add(0, altaRolToolStripMenuItem);
            //ids_funcionalidades.Add(1, null);
            ids_funcionalidades.Add(2, altaRutaToolStripMenuItem);
            ids_funcionalidades.Add(3, altaAeronaveToolStripMenuItem);
            ids_funcionalidades.Add(4, generarViajeToolStripMenuItem);
            ids_funcionalidades.Add(5, registroDeLlegadaToolStripMenuItem);
            //ids_funcionalidades.Add(6, null);
            ids_funcionalidades.Add(7, devoluciónToolStripMenuItem);
            ids_funcionalidades.Add(8, consultaMillasToolStripMenuItem);
            ids_funcionalidades.Add(9, canjeToolStripMenuItem);
            ids_funcionalidades.Add(10, listadoEstadísticoToolStripMenuItem);
            ids_funcionalidades.Add(11, bajaPasajeEncomiendaToolStripMenuItem);
            ids_funcionalidades.Add(12, loginToolStripMenuItem);
            ids_funcionalidades.Add(13, bajaModifAeronaveToolStripMenuItem);
            ids_funcionalidades.Add(14, BajaModifRolToolStripMenuItem);
            ids_funcionalidades.Add(15, BajaModifRutaToolStripMenuItem);
            ids_funcionalidades.Add(16, aBMAeronaveToolStripMenuItem);
            ids_funcionalidades.Add(17, aBMRolToolStripMenuItem);
            ids_funcionalidades.Add(18, aBMRutaToolStripMenuItem);
        }

        public void resetearFuncionalidades() 
        {
            //Falla con administrador porque sobran funcionalidades. Arreglar esto Urgente
            foreach (var funcionalidad in ids_funcionalidades) 
            {
                ToolStripMenuItem menuFuncion = funcionalidad.Value;
                menuFuncion.Visible = false;
            }
        }

        public void activarFuncionalidad(int idFuncion) 
        {
            ids_funcionalidades[idFuncion].Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Config.terminal == "administrativa")
            {
                var login = new Registro_de_Usuario.Login();

                login.setPadre(this);
                login.Show();
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
            Devolucion.FormDevolucion formularioDevolucion = new Devolucion.FormDevolucion();

            formularioDevolucion.MdiParent = this;

            formularioDevolucion.Show();
        }

        private void bajaPasajeEncomiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion.FormBajaPasajeEncomienda formularioBajaPasajeEncomienda = new Devolucion.FormBajaPasajeEncomienda();

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

            login.setPadre(this);
            login.Show();
        }
    }

}
