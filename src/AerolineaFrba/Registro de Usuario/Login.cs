using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_de_Usuario
{
     public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ids_funcionalidades.Add(0,"ABM rol");
            ids_funcionalidades.Add(1, "ABM ciudades");
            ids_funcionalidades.Add(2, "ABM ruta aerea");
            ids_funcionalidades.Add(3, "ABM aeronave");
            ids_funcionalidades.Add(4, "generar viaje");
            ids_funcionalidades.Add(5, "registrar llegada");
            ids_funcionalidades.Add(6, "compra");
            ids_funcionalidades.Add(7, "cancelacion");
            ids_funcionalidades.Add(8, "consultar millas");
            ids_funcionalidades.Add(9, "canjear millas");
            ids_funcionalidades.Add(10, "listado estadistico");
            ids_funcionalidades.Add(11, "ABM productos");

        }

        public Dictionary<int, Object> ids_funcionalidades = new Dictionary<int, Object>();

        private void habilitarFunciones() {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("usuario", new gdDataBase.ValorTipo(textBoxUsername.Text, SqlDbType.NVarChar));
            var funciones = new gdDataBase().ExecAndGetData("ÑUFLO.FuncionesDeUsuario", camposValores, new Dictionary<int, String>()).Rows;
            foreach (var funcion in funciones) {
                MessageBox.Show(funcion.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("usuario", new gdDataBase.ValorTipo(textBoxUsername.Text,SqlDbType.NVarChar));
            camposValores.Add("password", new gdDataBase.ValorTipo(textBoxPassword.Text,SqlDbType.NVarChar));
            if (new gdDataBase().Exec("ÑUFLO.LogearUsuario", camposValores, new Dictionary<int, String>()))
                habilitarFunciones();//SP QUE DEVUELVA FUNCIONES DADO NOMBRE DE USUARIO
        }
    }
}
