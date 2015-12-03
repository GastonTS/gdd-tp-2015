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
            dateTimePicker1.Text = "";

            comboBoxProducto.Enabled = false;
            textBoxCantidadProducto.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        protected override void guardarPosta()
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
            }
        }
    }
}
