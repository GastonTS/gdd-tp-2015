using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba
{
    class gdDataBase
    {
        SqlConnection miConexion;

        public void conectar()
        {
            miConexion = new SqlConnection("localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=***********");
            miConexion.Open();
        }

        public void desconectar()
        {
            miConexion.Close();
        }

        public void ejecutarSql(String query)
        {
            SqlCommand comando = new SqlCommand(query, miConexion);

            int filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                //Salió bien (o al menos algo) de la query ejecutada
            }
            else
            {
                //falló la query
            }
        }

        public void actualizarDataGridView(DataGridView dataGrid, String nombreTabla, String query)
        {
            conectar();

            DataSet dataSet = new DataSet();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, miConexion);

            adaptador.Fill(dataSet, nombreTabla);

            dataGrid.DataSource = dataSet;
            dataGrid.DataMember = nombreTabla;

            desconectar();
        }
    }
}
