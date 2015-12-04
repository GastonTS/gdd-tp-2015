using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class FormCajeMillasPasajero : Abm.Alta
    {
        public FormCajeMillasPasajero()
        {
            InitializeComponent();
            lblNoHaySuficientesMillas.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDni.Text = "";
            textBoxCantidadProducto.Text = "";
            comboBoxProducto.Text = "";
            lblNoHaySuficientesMillas.Visible = false;
            lblCantMillas.ResetText();

            comboBoxProducto.Enabled = false;
            textBoxCantidadProducto.Enabled = false;

        }

        public override string MsgError
        {
            get
            {
                return "Hubo un problema al tratar de canjear las millas.";
            }
        }

        protected override void guardarPosta()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Decimal));
            camposValores.Add("cantidad", new gdDataBase.ValorTipo(textBoxCantidadProducto.Text, SqlDbType.Int));
            camposValores.Add("descripcion", new gdDataBase.ValorTipo(comboBoxProducto.Text, SqlDbType.VarChar));
            camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            errorMensaje.Add(60008, "El cliente no posee suficientes millas para realizar el canje");
            errorMensaje.Add(60009, "No hay suficiente stock del producto deseado para realizar el canje");

            new gdDataBase().Exec("ÑUFLO.CanjearProductoA", camposValores, errorMensaje, "Canje realizado con éxito");

            if(esClienteValido(textBoxDni.Text))
                actualizarDatosCliente();
        }

        private int cantidadProducto() 
        {
            if (textBoxCantidadProducto.Text.Trim() == "") return 0;
            else return int.Parse(textBoxCantidadProducto.Text);
        }

        private void actualizarDatosCliente() 
        {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Int));
            lblCantMillas.Text = new gdDataBase().ExecAndGetData("ÑUFLO.MillasTotalesDe", camposValores, new Dictionary<int, String>()).Rows[0].ItemArray[0].ToString();

            var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ProductosDe", camposValores);
            comboBoxProducto.DataSource = dt;
            comboBoxProducto.DisplayMember = dt.Columns[0].ColumnName;

            var hayAlgunProductoDisponible = comboBoxProducto.Items.Count != 0;

            comboBoxProducto.Enabled = hayAlgunProductoDisponible;
            textBoxCantidadProducto.Enabled = hayAlgunProductoDisponible;
            lblNoHaySuficientesMillas.Visible = !hayAlgunProductoDisponible;
            
            actualizarDatosTransaccion();
        }

        private void actualizarDatosTransaccion()
        {
            if (comboBoxProducto.Items.Count != 0)
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("nombre",new gdDataBase.ValorTipo(comboBoxProducto.Text.ToString(),SqlDbType.NVarChar));
                var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.DatosDeProducto",camposValores);
                var precioUnitario = (int)dt.Rows[0]["millas_necesarias"];
                var stock = (int)dt.Rows[0]["stock"];
                var precioTotal = precioUnitario * cantidadProducto();
                var millasRestantes = int.Parse(lblCantMillas.Text) - precioTotal;
                lblCostoProducto.Text = precioUnitario.ToString();
                lblStock.Text = stock.ToString();
                lblCostoTotal.Text = precioTotal.ToString();
                lblMillasRestantes.Text = millasRestantes.ToString();
            }


        }

        private bool esClienteValido(String dni) 
        {
            var camposValores = gdDataBase.newParameters();
            camposValores.Add("dni",new gdDataBase.ValorTipo(dni,SqlDbType.Int));
            return new gdDataBase().ExecAndGetData("ÑUFLO.ConsultaCliente", camposValores).Rows.Count > 0;
        }

        

        private void textBoxDni_TextboxTextChanged(object sender, EventArgs e)
        {
            if (textBoxDni.Text.Trim() != "")
            {
                if (esClienteValido(textBoxDni.Text))
                {
                    actualizarDatosCliente();

                    
                }
                else
                {
                    comboBoxProducto.DataSource = null;
                    comboBoxProducto.Enabled = false;
                    textBoxCantidadProducto.Enabled = false;
                    textBoxCantidadProducto.ResetText();
                    lblCantMillas.ResetText();
                    lblCostoProducto.ResetText();
                    lblCostoTotal.ResetText();
                    lblMillasRestantes.ResetText();
                    lblStock.ResetText();
                    lblNoHaySuficientesMillas.Visible = false;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadProducto_TextboxTextChanged(object sender, EventArgs e)
        {
            actualizarDatosTransaccion();
        }

        private void comboBoxProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarDatosTransaccion();

        }
    }
}
