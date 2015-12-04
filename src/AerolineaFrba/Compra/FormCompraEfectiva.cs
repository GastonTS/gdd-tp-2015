﻿using System;
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
    public partial class FormCompraEfectiva : Form, ICargaDatosCliente
    {
        List<FormSeleccionViaje.Pasaje> pasajesAComprar = new List<FormSeleccionViaje.Pasaje>();
        List<FormSeleccionViaje.Encomienda> encomiendasAComprar = new List<FormSeleccionViaje.Encomienda>();
        FormSeleccionViaje.Compra compraARealizar;
        List<String> mediosDePagoDesarrollo = new List<String> { "Tarjeta de crédito", "Efectivo", "Bitcoins", "Pago en especias", "Cheques de Mumuki", "Fiar"};
        List<String> mediosDePagoKiosko = new List<String>{"Tarjeta de crédito"};
        List<String> mediosDePagoAdministrativa = new List<String>{"Tarjeta de crédito", "Efectivo"};
        Dictionary<String, List<String>> mediosDePagoSegunTerminal = new Dictionary<String, List<String>>();


        public FormCompraEfectiva()
        {
            InitializeComponent();
            mediosDePagoSegunTerminal.Add("desarrollo", mediosDePagoDesarrollo);
            mediosDePagoSegunTerminal.Add("kiosko",mediosDePagoKiosko);
            mediosDePagoSegunTerminal.Add("administrativa",mediosDePagoAdministrativa);
            comboBoxMedioDePago.DataSource = mediosDePagoSegunTerminal[Config.terminal];
        }

        private void checkBoxModificarDatos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatosCliente fdc = new FormDatosCliente();

            fdc.indicarSiEsPasajero(false);
            fdc.Show(this);
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

        private void btnFinalizarCarga_Click(object sender, EventArgs e)
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
    }
}
