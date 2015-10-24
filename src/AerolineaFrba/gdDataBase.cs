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
        SqlConnection miConexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");

        public void conectar()
        {
            //miConexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");
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

        public DataSet GetDataSP(String spName) {
            return GetData(spName, CommandType.StoredProcedure);
        }

        public DataSet GetDataQuery(String query){
            return GetData(query, CommandType.Text);
        }
        
        public DataSet GetData(String command, CommandType commandType)
        {
            DataSet ds = null;
            using (var cmd = new SqlCommand(command, miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = commandType;
                da.Fill(ds = new DataSet());
            }
            return ds;
        }

        public void Exec(String spName)
        {
            using (var cmd = new SqlCommand(spName, miConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter(
                //cmd.Parameters.AddRange(new SqlParameter[]{
                //    new SqlParameter("@sarasa", 666),
                //});
                cmd.ExecuteNonQuery();
            }
        }
    }
}
