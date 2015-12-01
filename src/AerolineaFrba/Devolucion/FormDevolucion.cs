﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class FormDevolucion : Form
    {
        public FormDevolucion()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Codigo", "Codigo");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Peso_Encomienda", "Peso_Encomienda");
            dataGridView1.Columns.Add("Butaca_numero", "Butaca_numero");
            dataGridView1.Columns.Add("Precio", "Precio");
        }

        private void FormSeleccionCompra_Load(object sender, EventArgs e)
        {

        }

        
        public void agregarPasaje(DataGridViewRow fila) 
        {

            var ultimaPosicion = dataGridView1.Rows.Count;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Rows.Add();
            for (int i = 0; i < fila.Cells.Count-1; i++)
            {
                dataGridView1.Rows[ultimaPosicion].Cells[i].Value = fila.Cells[i+1].Value;
            }
            
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            var formBaja = new FormBajaPasajeEncomienda();
            formBaja.setPadre(this);
            formBaja.Show();
        }

        public void adaptarTabla(DataTable grilla) 
        {
            dataGridView1.DataSource = grilla;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
        }

    }
}
