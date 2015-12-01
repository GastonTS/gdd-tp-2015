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
         Form padre;
        public Login()
        {
            InitializeComponent();


        }

        public void setPadre(Form unForm)
        {
            padre= unForm;
        }

        public Dictionary<int, Object> ids_funcionalidades = new Dictionary<int, Object>();

        private void habilitarFunciones() {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("usuario", new gdDataBase.ValorTipo(textBoxUsername.Text, SqlDbType.NVarChar));
            var funciones = new gdDataBase().ExecAndGetData("ÑUFLO.FuncionesDeUsuario", camposValores, new Dictionary<int, String>()).Rows;
            padre.resetearFuncionalidades();
            foreach (var funcion in funciones) {
                padre.activarFuncionalidad(idFuncion(funcion));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("usuario", new gdDataBase.ValorTipo(textBoxUsername.Text,SqlDbType.NVarChar));
            camposValores.Add("password", new gdDataBase.ValorTipo(textBoxPassword.Text,SqlDbType.NVarChar));
            var spExec = new SPPureExec("ÑUFLO.LogearUsuario", camposValores);
            spExec.Exec();
            if (! spExec.huboError())
                habilitarFunciones();//SP QUE DEVUELVA FUNCIONES DADO NOMBRE DE USUARIO
        }
    }
}
