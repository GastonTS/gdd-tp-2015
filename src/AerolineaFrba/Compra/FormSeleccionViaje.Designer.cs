﻿namespace AerolineaFrba.Compra
{
    partial class FormSeleccionViaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFechaViaje = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFechaYRuta = new System.Windows.Forms.GroupBox();
            this.labelViajesDisponibles = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregarPasaje = new System.Windows.Forms.Button();
            this.btnAgregarEncomienda = new System.Windows.Forms.Button();
            this.listBoxPasajesYEncomiendasComprados = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxPasajesEncomiendas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFechaYRuta.SuspendLayout();
            this.groupBoxPasajesEncomiendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFechaViaje
            // 
            this.labelFechaViaje.AutoSize = true;
            this.labelFechaViaje.Location = new System.Drawing.Point(32, 25);
            this.labelFechaViaje.Name = "labelFechaViaje";
            this.labelFechaViaje.Size = new System.Drawing.Size(80, 13);
            this.labelFechaViaje.TabIndex = 0;
            this.labelFechaViaje.Text = "Fecha de viaje:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DisplayMember = "nombre";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(118, 98);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 7;
            this.comboBoxDestino.ValueMember = "id_ciudad";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DisplayMember = "nombre";
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(118, 59);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 5;
            this.comboBoxOrigen.ValueMember = "id_ciudad";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(32, 101);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(80, 13);
            this.labelDestino.TabIndex = 6;
            this.labelDestino.Text = "Ciudad destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(37, 62);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(75, 13);
            this.labelOrigen.TabIndex = 4;
            this.labelOrigen.Text = "Ciudad origen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(22, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 131);
            this.dataGridView1.TabIndex = 8;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // groupBoxFechaYRuta
            // 
            this.groupBoxFechaYRuta.Controls.Add(this.dateTimePicker1);
            this.groupBoxFechaYRuta.Controls.Add(this.comboBoxDestino);
            this.groupBoxFechaYRuta.Controls.Add(this.labelFechaViaje);
            this.groupBoxFechaYRuta.Controls.Add(this.comboBoxOrigen);
            this.groupBoxFechaYRuta.Controls.Add(this.labelOrigen);
            this.groupBoxFechaYRuta.Controls.Add(this.labelDestino);
            this.groupBoxFechaYRuta.Location = new System.Drawing.Point(22, 21);
            this.groupBoxFechaYRuta.Name = "groupBoxFechaYRuta";
            this.groupBoxFechaYRuta.Size = new System.Drawing.Size(360, 139);
            this.groupBoxFechaYRuta.TabIndex = 9;
            this.groupBoxFechaYRuta.TabStop = false;
            this.groupBoxFechaYRuta.Text = "Fecha y ruta requeridas";
            // 
            // labelViajesDisponibles
            // 
            this.labelViajesDisponibles.AutoSize = true;
            this.labelViajesDisponibles.Location = new System.Drawing.Point(22, 187);
            this.labelViajesDisponibles.Name = "labelViajesDisponibles";
            this.labelViajesDisponibles.Size = new System.Drawing.Size(93, 13);
            this.labelViajesDisponibles.TabIndex = 10;
            this.labelViajesDisponibles.Text = "Viajes disponibles:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(25, 510);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPasaje
            // 
            this.btnAgregarPasaje.Location = new System.Drawing.Point(32, 39);
            this.btnAgregarPasaje.Name = "btnAgregarPasaje";
            this.btnAgregarPasaje.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarPasaje.TabIndex = 16;
            this.btnAgregarPasaje.Text = "Comprar Pasaje";
            this.btnAgregarPasaje.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEncomienda
            // 
            this.btnAgregarEncomienda.Location = new System.Drawing.Point(32, 79);
            this.btnAgregarEncomienda.Name = "btnAgregarEncomienda";
            this.btnAgregarEncomienda.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarEncomienda.TabIndex = 17;
            this.btnAgregarEncomienda.Text = "Comprar Encomienda";
            this.btnAgregarEncomienda.UseVisualStyleBackColor = true;
            // 
            // listBoxPasajesYEncomiendasComprados
            // 
            this.listBoxPasajesYEncomiendasComprados.FormattingEnabled = true;
            this.listBoxPasajesYEncomiendasComprados.Location = new System.Drawing.Point(243, 19);
            this.listBoxPasajesYEncomiendasComprados.Name = "listBoxPasajesYEncomiendasComprados";
            this.listBoxPasajesYEncomiendasComprados.Size = new System.Drawing.Size(199, 108);
            this.listBoxPasajesYEncomiendasComprados.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBoxPasajesEncomiendas
            // 
            this.groupBoxPasajesEncomiendas.Controls.Add(this.btnAgregarPasaje);
            this.groupBoxPasajesEncomiendas.Controls.Add(this.listBoxPasajesYEncomiendasComprados);
            this.groupBoxPasajesEncomiendas.Controls.Add(this.btnAgregarEncomienda);
            this.groupBoxPasajesEncomiendas.Enabled = false;
            this.groupBoxPasajesEncomiendas.Location = new System.Drawing.Point(25, 356);
            this.groupBoxPasajesEncomiendas.Name = "groupBoxPasajesEncomiendas";
            this.groupBoxPasajesEncomiendas.Size = new System.Drawing.Size(448, 140);
            this.groupBoxPasajesEncomiendas.TabIndex = 20;
            this.groupBoxPasajesEncomiendas.TabStop = false;
            this.groupBoxPasajesEncomiendas.Text = "Compra de Pasajes y/o Encomiendas";
            // 
            // FormSeleccionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.labelViajesDisponibles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFechaYRuta);
            this.Controls.Add(this.groupBoxPasajesEncomiendas);
            this.Name = "FormSeleccionViaje";
            this.Text = "Selección del Viaje a Comprar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFechaYRuta.ResumeLayout(false);
            this.groupBoxFechaYRuta.PerformLayout();
            this.groupBoxPasajesEncomiendas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFechaViaje;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
        private System.Windows.Forms.GroupBox groupBoxFechaYRuta;
        private System.Windows.Forms.Label labelViajesDisponibles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregarPasaje;
        private System.Windows.Forms.Button btnAgregarEncomienda;
        private System.Windows.Forms.ListBox listBoxPasajesYEncomiendasComprados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxPasajesEncomiendas;
    }
}