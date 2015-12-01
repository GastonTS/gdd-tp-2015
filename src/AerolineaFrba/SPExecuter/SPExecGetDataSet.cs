﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    public class SPExecGetDataSet : SPExecuter
    {
        public SPExecGetDataSet(String spName, Dictionary<String, gdDataBase.ValorTipo> campoValor = null, Dictionary<int, String> errorMensaje = null, String msgEjecucionCorrecta = null, gdDataBase db= null) : base(spName, campoValor, errorMensaje, msgEjecucionCorrecta, db) { }
        protected override void ejecutarSP(System.Data.SqlClient.SqlCommand cmd, object ds, SqlDataAdapter da)
        {
            da.SelectCommand = cmd;
            da.Fill((DataSet)ds);
        }

        protected override object instanciarTipoDato()
        {
            return new DataSet();
        }
    }
}
