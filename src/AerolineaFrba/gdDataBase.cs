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

        public struct ValorTipo
        {
            String valor;
            SqlDbType tipo;

            public ValorTipo(String valor, SqlDbType tipo)
            {
                this.valor = valor;
                this.tipo = tipo;
            }

            public String getValor()
            {
                return valor;
            }
            public SqlDbType getTipo()
            {
                return tipo;
            }
        }

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


        public void cargarListadoEstadistico(BindingSource binding, String spName)
        {
            DataSet ds = null;
            using (var cmd = new SqlCommand(spName, miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                
                da.Fill(ds = new DataSet());
            }
            binding.DataSource = ds.Tables[0];
            
        }


        //Actualizar superador

        public void actualizarBindingSourceFiltrosQuery(BindingSource binding, String tableName, Dictionary<String,String> map){
            
            var unfilteredQuery = "SELECT * FROM " + "'" + tableName + "'" + "WHERE 3.14=3.14 ";

            map.Where(par => par.Value != "").Aggregate(unfilteredQuery, ((query, par) => query + "AND '" + par.Key + "' = '" + par.Value + "' "));

        }

        public void actualizarBindingSourceSP(BindingSource binding, String spName){
            actualizarBindingSource(binding, spName, CommandType.StoredProcedure);
        }
        public void actualizarBindingSourceQuery(BindingSource binding,String query){
            actualizarBindingSource(binding, query, CommandType.Text);
        }

        public void actualizarBindingSource(BindingSource binding, String sqlCommand, CommandType commandType)
        {
            DataSet dataSet = GetData(sqlCommand,commandType);

            binding.DataSource = dataSet.Tables[0];
        }

        public void actualizarDataGridView(DataGridView dataGrid, String query)
        {
            conectar();

            DataSet dataSet = new DataSet();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, miConexion);

            adaptador.Fill(dataSet);

            BindingSource dataBinding = new BindingSource();

            dataBinding.DataSource = dataSet.Tables[0];

            dataGrid.DataSource = dataBinding;
            //dataGrid.DataMember = nombreTabla;

            desconectar();
        }
        
        public void actualizarComboBox(ComboBox comboBox, String query)
        {
            conectar();

            DataSet dataSet = new DataSet();

            SqlDataAdapter adaptador = new SqlDataAdapter(query, miConexion);

            adaptador.Fill(dataSet);

            BindingSource dataBinding = new BindingSource();

            dataBinding.DataSource = dataSet.Tables[0];


            comboBox.DataSource = dataBinding;
            //dataGrid.DataMember = nombreTabla;

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

        public void Exec(String spName, Dictionary<String, ValorTipo> campoValor, Dictionary<int, String> errorMensaje)
        {
            conectar();

            using (var cmd = new SqlCommand(spName, miConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < campoValor.Count; i++)
                {
                    cmd.Parameters.Add("@" + campoValor.ElementAt(i).Key, 
                        campoValor.ElementAt(i).Value.getTipo()).Value = campoValor.ElementAt(i).Value.getValor();
                }

                //para ejecutar sp que devuelven algo, creo que hay que poner ExecuteReader or algún otro tipo

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aeronave registrada correctamente");
                }
                catch (SqlException exception)
                {
                    for (int i = 0; i < errorMensaje.Count; i++)
                    {
                        if (exception.Number == errorMensaje.ElementAt(i).Key)
                        {
                            MessageBox.Show(errorMensaje.ElementAt(i).Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }

            desconectar();
        }
    }
}
