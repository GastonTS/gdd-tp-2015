using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FormCompraEfectiva : Abm.Alta, ICargaDatosCliente, Abm.IFormPadreDeDatosCliente
    {
        List<FormSeleccionViaje.Pasaje> pasajesAComprar = new List<FormSeleccionViaje.Pasaje>();
        List<FormSeleccionViaje.Encomienda> encomiendasAComprar = new List<FormSeleccionViaje.Encomienda>();
        FormSeleccionViaje.Compra compraARealizar;
        List<String> mediosDePagoDesarrollo = new List<String> { "Tarjeta de crédito", "Efectivo", "Bitcoins", "Pago en especias", "Cheques de Mumuki", "Fiar"};
        List<String> mediosDePagoKiosko = new List<String>{"Tarjeta de crédito"};
        List<String> mediosDePagoAdministrativa = new List<String>{"Tarjeta de crédito", "Efectivo"};
        Dictionary<String, List<String>> mediosDePagoSegunTerminal = new Dictionary<String, List<String>>();

        public override string MsgError
        {
            get
            {
                return "Error al realizar la compra";
            }
        }

        public FormCompraEfectiva()
        {
            InitializeComponent();
            mediosDePagoSegunTerminal.Add("desarrollo", mediosDePagoDesarrollo);
            mediosDePagoSegunTerminal.Add("kiosko",mediosDePagoKiosko);
            mediosDePagoSegunTerminal.Add("administrativa",mediosDePagoAdministrativa);
            comboBoxMedioDePago.DataSource = mediosDePagoSegunTerminal[Config.terminal];
            comboBoxTipoTarjeta.DataSource = new gdDataBase().ExecAndGetData("ÑUFLO.TarjetasDeCredito");
            comboBoxTipoTarjeta.DisplayMember = "nombre";
            comboBoxTipoTarjeta.ValueMember = "cantidad_de_cuotas";
            actualizarEstadoDatosTarjetaDeCredito();
        }

        private void checkBoxModificarDatos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatosCliente fdc = new FormDatosCliente();

            fdc.indicarSiEsPasajero(false);
            fdc.setPadre(this);
            fdc.Show();
        }

        public void setDNI(String dni)
        {
            textBoxDNI.Text = dni;
        }

        public void setCompras(FormSeleccionViaje.Compra compra, List<FormSeleccionViaje.Pasaje> pasajes,
            List<FormSeleccionViaje.Encomienda> encomiendas)
        {
            compraARealizar = compra;
            pasajesAComprar = pasajes;
            encomiendasAComprar = encomiendas;
        }

        override protected void guardarPosta() 
        {
            generarCompra();
            generarPasajes();
            generarEncomiendas();

            MessageBox.Show("Compra de pasajes y encomiendas realizada con éxito");
        }

        private void generarCompra()
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
            Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

            camposValores.Add("id_viaje", new gdDataBase.ValorTipo(compraARealizar.idViaje.ToString(), SqlDbType.Int));
            camposValores.Add("dni", new gdDataBase.ValorTipo(textBoxDNI.Text, SqlDbType.Int));
            camposValores.Add("hoy", new gdDataBase.ValorTipo(Config.fecha.ToString(), SqlDbType.DateTime));

            var dt = new gdDataBase().ExecAndGetData("ÑUFLO.CrearCompra", camposValores, null);

            compraARealizar = new FormSeleccionViaje.Compra(compraARealizar.idViaje,
                Convert.ToInt32(textBoxDNI.Text), Convert.ToInt32(dt.Rows[0].ItemArray[0]));
        }

        private void generarPasajes()
        {
            for (int i = 0; i < pasajesAComprar.Count; i++)
            {
                pasajesAComprar[i] = new FormSeleccionViaje.Pasaje(compraARealizar.codigoDeCompra,
                    pasajesAComprar[i].dni, pasajesAComprar[i].numeroDeButaca);

                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("codigo_compra", new gdDataBase.ValorTipo(pasajesAComprar[i].codigoDeCompra, SqlDbType.Int));
                camposValores.Add("dni", new gdDataBase.ValorTipo(pasajesAComprar[i].dni, SqlDbType.Int));
                camposValores.Add("numero_butaca", new gdDataBase.ValorTipo(pasajesAComprar[i].numeroDeButaca, SqlDbType.Int));

                errorMensaje.Add(60033, "Una de las butacas seleccionada en la compra no está disponible");

                new gdDataBase().Exec("ÑUFLO.CrearPasaje", camposValores, errorMensaje);
            }
        }

        private void generarEncomiendas()
        {
            for (int i = 0; i < encomiendasAComprar.Count; i++)
            {
                encomiendasAComprar[i] = new FormSeleccionViaje.Encomienda(compraARealizar.codigoDeCompra,
                    encomiendasAComprar[i].dni, encomiendasAComprar[i].pesoEncomienda);

                Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();
                Dictionary<int, String> errorMensaje = new Dictionary<int, string>();

                camposValores.Add("codigo_compra", new gdDataBase.ValorTipo(encomiendasAComprar[i].codigoDeCompra, SqlDbType.Int));
                camposValores.Add("dni", new gdDataBase.ValorTipo(encomiendasAComprar[i].dni, SqlDbType.Int));
                camposValores.Add("peso_encomienda", new gdDataBase.ValorTipo(encomiendasAComprar[i].pesoEncomienda, SqlDbType.Decimal));

                new gdDataBase().Exec("ÑUFLO.CrearEncomienda", camposValores, null);
            }
        }

        private void comboBoxMedioDePago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarEstadoDatosTarjetaDeCredito();
        }

        private void actualizarEstadoDatosTarjetaDeCredito()
        {
            var deberiaEstarActivo = (comboBoxMedioDePago.SelectedValue.ToString() == "Tarjeta de crédito");
            if (!deberiaEstarActivo)
            {
                foreach (Control control in groupBoxTarjetaCredito.Controls)
                {
                    if (control is Abm.TextBoxValidado ||
                        control is DateTimePicker) control.ResetText();
                    if (control is CheckBox) ((CheckBox)control).Checked = false;
                    if (control is ComboBox) ((ComboBox)control).SelectedIndex = 0;
                    control.CausesValidation = deberiaEstarActivo;
                }
                lblCantCuotas.ResetText();
            }
            else lblCantCuotas.Text = comboBoxTipoTarjeta.SelectedValue.ToString();
            groupBoxTarjetaCredito.Enabled = deberiaEstarActivo;
        }

        private void comboBoxMedioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerFechaVencimiento.Value > Config.fecha)
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(dateTimePickerFechaVencimiento, "La fecha debería ser posterior al día de la fecha");
                e.Cancel = true;
            }
        }

        private void comboBoxTipoTarjeta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxTipoTarjeta.SelectedValue == null) lblCantCuotas.Text = "";
            else lblCantCuotas.Text = comboBoxTipoTarjeta.SelectedValue.ToString();
        }

    }
}
