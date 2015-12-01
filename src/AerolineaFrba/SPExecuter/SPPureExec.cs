using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    public class SPPureExec : SPExecuter
    {
        override protected object instanciarTipoDato(){return null;}

        public SPPureExec(String spName, Dictionary<String, gdDataBase.ValorTipo> campoValor = null, Dictionary<int, String> errorMensaje = null, String msgEjecucionCorrecta = null) :base(spName,campoValor,errorMensaje,msgEjecucionCorrecta){}

        protected override void ejecutarSP(SqlCommand cmd, object ds,SqlDataAdapter da)
        {
            cmd.ExecuteNonQuery();
        }

    }
}
