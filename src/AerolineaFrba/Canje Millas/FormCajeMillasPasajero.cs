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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDni.Text = "";
            textBoxCantidadProducto.Text = "";
            comboBoxProducto.Text = "";

            comboBoxProducto.Enabled = false;
            textBoxCantidadProducto.Enabled = false;
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
        }

        private int cantidadProducto() 
        {
            if (textBoxCantidadProducto.Text.Trim() == "") return 0;
            else return int.Parse(textBoxCantidadProducto.Text);
        }

        private void actualizarDatosTransaccion()
        {
            if (comboBoxProducto.Items.Count != 0)
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("nombre",new gdDataBase.ValorTipo(comboBoxProducto.SelectedValue.ToString(),SqlDbType.NVarChar);
                var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.DatosDeProducto",camposValores);
                var precioUnitario = (int)dt.Rows[0]["Precio"];
                var stock = (int)dt.Rows[0]["Stock"];
                var precioTotal = precioUnitario * cantidadProducto();
                var millasRestantes = int.Parse(lblCantMillas.Text) - precioTotal;
                lblCostoProducto.Text = precioUnitario.ToString();
                lblStock.Text = stock.ToString();
                lblCostoTotal.Text = precioTotal.ToString();
                lblMillasRestantes.Text = precioTotal.ToString();
            }


        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            if (textBoxDni.Text.Trim() != "")
            {
                camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Decimal));

                var dt = new gdDataBase().GetDataWithParameters("ÑUFLO.ProductosDe", camposValores);
                comboBoxProducto.DataSource = dt;
                comboBoxProducto.DisplayMember = dt.Columns[0].ColumnName;

                comboBoxProducto.Enabled = true;
                textBoxCantidadProducto.Enabled = true;

                actualizarDatosTransaccion();
            }
        }

        private void textBoxDni_TextboxTextChanged(object sender, EventArgs e)
        {
            if (textBoxDni.Text.Trim() != "")
            {
                var camposValores = gdDataBase.newParameters();
                camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDni.Text, SqlDbType.Int));
                lblCantMillas.Text = new gdDataBase().ExecAndGetData("ÑUFLO.MillasTotalesDe", camposValores, new Dictionary<int, String>()).Rows[0].ItemArray[0].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
