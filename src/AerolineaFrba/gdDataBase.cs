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
    public class gdDataBase
    {
        SqlConnection miConexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;User ID=gd;Password=gd2015");

        public static Dictionary<String, gdDataBase.ValorTipo> newParameters() { return new Dictionary<String, gdDataBase.ValorTipo>(); }

        public struct ValorTipo
        {
            String valor;
            SqlDbType tipo;

            public ValorTipo(object valor, SqlDbType tipo) 
            {
                this.valor = valor.ToString();
                this.tipo = tipo;
            }

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

        public DataTable GetDataWithParameters(String spName, Dictionary<String, ValorTipo> campoValor)
        {
            conectar();

            DataTable ds = new DataTable();

            using (var cmd = new SqlCommand(spName, miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

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

                da.SelectCommand = cmd;
                da.Fill(ds);
            }

            desconectar();

            return ds;
        }

        public void Exec(String spName, Dictionary<String, ValorTipo> campoValor, Dictionary<int, String> errorMensaje, String ejecucionCorrecta = null)
        {
            conectar();
            bool encontroErrorConocido = false;

            using (var cmd = new SqlCommand(spName, miConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < campoValor.Count; i++)
                {
                    var parametro = new SqlParameter("@" + campoValor.ElementAt(i).Key,
                        campoValor.ElementAt(i).Value.getTipo());
                    parametro.Precision = 18;
                    parametro.Scale = 0;
                    parametro.Value = campoValor.ElementAt(i).Value.getValor();
                    cmd.Parameters.Add(parametro);
                }

                //para ejecutar sp que devuelven algo, creo que hay que poner ExecuteReader or algún otro tipo

                try
                {
                    cmd.ExecuteNonQuery();
                    if (ejecucionCorrecta != null)
                        MessageBox.Show(ejecucionCorrecta);
                }
                catch (SqlException exception)
                {
                    if (errorMensaje != null)
                    {
                        for (int i = 0; i < errorMensaje.Count; i++)
                        {
                            if (exception.Number == errorMensaje.ElementAt(i).Key)
                            {
                                MessageBox.Show(errorMensaje.ElementAt(i).Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                encontroErrorConocido = true;
                            }
                        }
                        if(!encontroErrorConocido)
                            MessageBox.Show(exception.Message);
                    }
                }
            }

            desconectar();
        }

        //lo que hago acá es feo. Repito lógica con respecto a métodos anteriores. Pero lo hago para separar
        //los distintos casos de Stored Procedures que pueden haber y así saber que estoy haciendo en cada caso
        //al ejecutarlos y esas cosas.

        public DataTable ExecAndGetData(String spName, Dictionary<String, ValorTipo> campoValor, Dictionary<int, String> errorMensaje, String ejecucionCorrecta=null)


        {
            conectar();

            bool encontroErrorConocido = false;
            DataTable ds = new DataTable();

            using (var cmd = new SqlCommand(spName, miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < campoValor.Count; i++)
                {
                    var parametro = new SqlParameter("@" + campoValor.ElementAt(i).Key,
                        campoValor.ElementAt(i).Value.getTipo());
                    parametro.Precision = 18;
                    parametro.Scale = 0;
                    parametro.Value = campoValor.ElementAt(i).Value.getValor();
                    cmd.Parameters.Add(parametro);
                }

                try
                {

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ejecucionCorrecta != null)
                        MessageBox.Show(ejecucionCorrecta);
                }
                catch (SqlException exception)
                {
                    for (int i = 0; i < errorMensaje.Count; i++)
                    {
                        if (exception.Number == errorMensaje.ElementAt(i).Key)
                        {
                            MessageBox.Show(errorMensaje.ElementAt(i).Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            encontroErrorConocido = true;
                        }
                    }
                    if(!encontroErrorConocido)
                        MessageBox.Show(exception.Message);
                }
            }

            desconectar();

            return ds;
        }


        public DataSet ExecAndGetDataSet(String spName, Dictionary<String, ValorTipo> campoValor = null,
                                        Dictionary<int, String> errorMensaje = null, String ejecucionCorrecta = null)
        {
            conectar();

            bool encontroErrorConocido = false;
            DataSet ds = new DataSet();

            using (var cmd = new SqlCommand("ÑUFLO."+spName, miConexion))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

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

                try
                {

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    if (ejecucionCorrecta != null)
                        MessageBox.Show(ejecucionCorrecta);
                }
                catch (SqlException exception)
                {
                    if (errorMensaje != null)
                    {
                        for (int i = 0; i < errorMensaje.Count; i++)
                        {
                            if (exception.Number == errorMensaje.ElementAt(i).Key)
                            {
                                MessageBox.Show(errorMensaje.ElementAt(i).Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            encontroErrorConocido = true;
                            }
                        }
                        if(!encontroErrorConocido)
                            MessageBox.Show(exception.Message);
                    }
                    else MessageBox.Show("The impossible has happened");
                }
            }

            desconectar();

            return ds;
        }

    }
}
