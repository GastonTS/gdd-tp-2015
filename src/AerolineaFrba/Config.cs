using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Config
    {
        public static string strConnection = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;
        public static DateTime fecha = DateTime.Parse(ConfigurationManager.AppSettings["Fecha"]);
        public static String terminal = ConfigurationManager.AppSettings["Terminal"];
    }
}
