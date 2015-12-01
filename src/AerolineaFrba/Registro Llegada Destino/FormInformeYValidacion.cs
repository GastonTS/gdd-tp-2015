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
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("matricula",new gdDataBase.ValorTipo(matricula,SqlDbType.NVarChar));
            DataRow aeronave = new gdDataBase().ExecAndGetData("ÑUFLO.AeronavePorMatricula",camposValores, new Dictionary<int,string>()).Rows[0];
            lblModelo.Text = aeronave["Modelo"].ToString();
            lblMatricula.Text = aeronave["Matricula"].ToString();
            lblFabricante.Text = aeronave["Fabricante"].ToString();
            lblTipoServicio.Text = aeronave["Tipo servicio"].ToString();
            lblCantButacas.Text = aeronave["Cantidad butacas"].ToString();
            lblCapacEncomiendas.Text = aeronave["Capacidad encomiendas"].ToString();
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
