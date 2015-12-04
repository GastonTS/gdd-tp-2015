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
        FormPrincipal padre;

        public Login()
        {
            InitializeComponent();
            textBoxPassword.modoPassword();
        }

        public void setPadre(FormPrincipal unForm)
        {
            padre = unForm;
        }

        public Dictionary<int, Object> ids_funcionalidades = new Dictionary<int, Object>();

        private void habilitarFunciones() {
            var camposValores = gdDataBase.newParameters();

            camposValores.Add("nombre_usuario", new gdDataBase.ValorTipo(textBoxUsername.Text, SqlDbType.NVarChar));

            var funciones = new gdDataBase().ExecAndGetData("ÑUFLO.FuncionalidadesPorUsuario", camposValores, new Dictionary<int, String>()).Rows;
            padre.resetearFuncionalidades();

            foreach (DataRow funcion in funciones) {
                padre.activarFuncionalidad(idFuncion(funcion));
            }

            padre.habilitarFormulario();
        }

        public int idFuncion(DataRow funcion) {
            return (int)funcion["id_funcionalidad"];
        }

        private void btnLogin_Click(object sender, EventArgs e)//Esto debería ser guardar posta?
        {
            var camposValores = gdDataBase.newParameters();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("usuario", new gdDataBase.ValorTipo(textBoxUsername.Text,SqlDbType.NVarChar));
            camposValores.Add("password", new gdDataBase.ValorTipo(textBoxPassword.Text,SqlDbType.NVarChar));

            errorMensaje.Add(60000, "Usuario o contraseña incorrecta");
            errorMensaje.Add(60001, "Usuario no habilitado");

            var spExec = new SPPureExec("ÑUFLO.LogearUsuario", camposValores, errorMensaje);
            spExec.Exec();

            if (!spExec.huboError())
            {
                habilitarFunciones();
                this.Close();
            }
        }
    }
}
