using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    abstract public class SPExecuter
    {
        protected String spName;
        protected Dictionary<String, gdDataBase.ValorTipo> campoValor;
        protected Dictionary<int, String> errorMensaje;
        protected String msgEjecucionCorrecta;
        protected SqlException excepcionAtrapada;
        protected gdDataBase database;

        public SPExecuter(String spName, Dictionary<String, gdDataBase.ValorTipo> campoValor = null, Dictionary<int, String> errorMensaje = null, String msgEjecucionCorrecta = null, gdDataBase unDB = null) 
        {
            this.spName = spName;
            this.campoValor = campoValor;
            this.errorMensaje = errorMensaje;
            this.msgEjecucionCorrecta = msgEjecucionCorrecta;
            this.excepcionAtrapada = null;
            this.database = unDB;
            if (database == null) database = new gdDataBase();
        }

        public void agregarParametrosAComando(SqlCommand cmd)
        {
            if (campoValor != null)
            {
                for (int i = 0; i < campoValor.Count; i++)
                {
                    var parametro = new SqlParameter("@" + campoValor.ElementAt(i).Key,
                        campoValor.ElementAt(i).Value.getTipo());
                    parametro.Precision = 18;
                    parametro.Scale = 0;
                    parametro.Value = campoValor.ElementAt(i).Value.getValor();
                    cmd.Parameters.Add(parametro);
                }

            }
        }


        public void mostrarErrorSqlProducido()
        {

            Boolean encontroErrorConocido = false;
            if (errorMensaje != null)
            {
                if (errorMensaje.ElementAt(0).Value == "Ignorar errores") return;
                for (int i = 0; i < errorMensaje.Count; i++)
                {
                    if (excepcionAtrapada.Number == errorMensaje.ElementAt(i).Key)
                    {
                        if (excepcionAtrapada.Number >= 64000)
                            MessageBox.Show(errorMensaje.ElementAt(i).Value, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            MessageBox.Show(errorMensaje.ElementAt(i).Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        encontroErrorConocido = true;
                    }
                }
            }
            if (!encontroErrorConocido)
                MessageBox.Show(excepcionAtrapada.Message);
        }

        protected virtual object instanciarTipoDato() { return null;}

        protected virtual void ejecutarSP(SqlCommand cmd, object ds, SqlDataAdapter da){;}

        public Boolean huboError() 
        {
            return excepcionAtrapada != null;
        }

        public int codError() 
        {
            if (excepcionAtrapada == null) throw new Exception("no habia ninguna excepcion");
            return excepcionAtrapada.Number;
        }

        protected void mostrarResultadoEjecucionCorrecta() {
            if (msgEjecucionCorrecta != null)
                MessageBox.Show(msgEjecucionCorrecta);
        }

        public object Exec() { return Exec(database); }

        public object Exec(gdDataBase unDB)
        {
            unDB.conectar();

            object ds = instanciarTipoDato();

            using (var cmd = new SqlCommand(spName, unDB.miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                agregarParametrosAComando(cmd);

                try
                {
                    ejecutarSP(cmd, ds, da);
                    //da.SelectCommand = cmd;
                    //da.Fill(ds);
                    mostrarResultadoEjecucionCorrecta();
                }
                catch (SqlException exception)
                {
                    excepcionAtrapada = exception;
                    mostrarErrorSqlProducido();
                }
            }

            unDB.desconectar();

            return ds;
        }


    }
}
