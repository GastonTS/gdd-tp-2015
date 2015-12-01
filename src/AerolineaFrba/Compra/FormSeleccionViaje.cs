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
    public partial class FormSeleccionViaje : Form
    {
        public struct Compra
        {
            int idViaje, dni, codigoDeCompra;
            decimal pesoDisponible;

            public Compra(int idViaje, int dni, int codigoDeCompra, decimal pesoDisponible)
            {
                this.idViaje = idViaje;
                this.dni = dni;
                this.codigoDeCompra = codigoDeCompra;
                this.pesoDisponible = pesoDisponible;
            }
        }

        public struct Pasaje
        {
            int codigoDeCompra, dni, numeroDeButaca;
            decimal precio;

            public Pasaje(int codigoDeCompra, int dni, int numeroDeButaca, decimal precio)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.numeroDeButaca = numeroDeButaca;
                this.precio = precio;
            }
        }

        public struct Encomienda
        {
            int codigoDeCompra, dni;
            decimal pesoEncomienda, precio;

            public Encomienda(int codigoDeCompra, int dni, decimal pesoEncomienda, decimal precio)
            {
                this.codigoDeCompra = codigoDeCompra;
                this.dni = dni;
                this.pesoEncomienda = pesoEncomienda;
                this.precio = precio;
            }
        }

        public FormSeleccionViaje()
        {
            InitializeComponent();
        }

        private void btnVerDisponibles_Click(object sender, EventArgs e)
        {
            Dictionary<String, gdDataBase.ValorTipo> camposValores = new Dictionary<string, gdDataBase.ValorTipo>();

            camposValores.Add("ciudad_origen", new gdDataBase.ValorTipo(comboBoxOrigen.Text, SqlDbType.VarChar));
            camposValores.Add("ciudad_destino", new gdDataBase.ValorTipo(comboBoxDestino.Text, SqlDbType.VarChar));
            camposValores.Add("fecha", new gdDataBase.ValorTipo(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.000"), SqlDbType.VarChar));

            var ds = new gdDataBase().GetDataWithParameters("ÑUFLO.ViajesDisponiblesPara", camposValores);

            dataGridView1.DataSource = ds;
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            irAComprar(true);
        }

        private void FormSeleccionViaje_Load(object sender, EventArgs e)
        {
            var dtOrigenDestino = new gdDataBase().GetDataWithParameters("ÑUFLO.TodasLasCiudades", null);

            origenBindingSource.DataSource = dtOrigenDestino;
            destinoBindingSource.DataSource = dtOrigenDestino;

            comboBoxOrigen.DataSource = origenBindingSource;
            comboBoxOrigen.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;

            comboBoxDestino.DataSource = destinoBindingSource;
            comboBoxDestino.DisplayMember = dtOrigenDestino.Columns[0].ColumnName;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                HabilitacionDeCompra(true);
            else
                HabilitacionDeCompra(false);
        }

        private void HabilitacionDeCompra(bool estado)
        {
            groupBoxPasajesEncomiendas.Enabled = estado;
        }

        private void btnAgregarEncomienda_Click(object sender, EventArgs e)
        {
            irAComprar(false);
        }

        private void irAComprar(bool esSoloPasaje)
        {
            FormDatosPasajeroEncomienda fdpe = new FormDatosPasajeroEncomienda();


            fdpe.indicarPasajeOEncomienda(esSoloPasaje);
            fdpe.Show();
        }
    }
}
