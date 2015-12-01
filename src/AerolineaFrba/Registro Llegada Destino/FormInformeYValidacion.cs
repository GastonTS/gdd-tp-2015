using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class FormInformeYValidacion : Form
    {
        public FormInformeYValidacion()
        {
            InitializeComponent();
        }

        public void setAeronave(String matricula) 
        {
            MessageBox.Show("QUIERO UN SP QUE DADA UNA MATRICULA ME DE LOS DATOS DE UN AVION");
        }

        public void setFecha(DateTime fecha)
        {
            lblFechaHora.Text = fecha.ToString();
        }

        public void setOrigen(String ciudad)
        {
            lblOrigen.Text = ciudad;
        }

        public void setDestino(String ciudad)
        {
            lblDestino.Text = ciudad;
        }

    }
}
