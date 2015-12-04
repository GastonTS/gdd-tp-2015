namespace AerolineaFrba.Compra
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
            this.components = new System.ComponentModel.Container();
            this.labelFechaViaje = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxFechaYRuta = new System.Windows.Forms.GroupBox();
            this.btnVerDisponibles = new System.Windows.Forms.Button();
            this.labelViajesDisponibles = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregarPasaje = new System.Windows.Forms.Button();
            this.btnAgregarEncomienda = new System.Windows.Forms.Button();
            this.listBoxPasajesYEncomiendasComprados = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBoxPasajesEncomiendas = new System.Windows.Forms.GroupBox();
            this.origenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFechaYRuta.SuspendLayout();
            this.groupBoxPasajesEncomiendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
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
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DisplayMember = "nombre";
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(118, 98);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 2;
            this.comboBoxDestino.ValueMember = "id_ciudad";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DisplayMember = "nombre";
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(118, 59);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 1;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 154);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // groupBoxFechaYRuta
            // 
            this.groupBoxFechaYRuta.Controls.Add(this.btnVerDisponibles);
            this.groupBoxFechaYRuta.Controls.Add(this.dateTimePicker1);
            this.groupBoxFechaYRuta.Controls.Add(this.comboBoxDestino);
            this.groupBoxFechaYRuta.Controls.Add(this.labelFechaViaje);
            this.groupBoxFechaYRuta.Controls.Add(this.comboBoxOrigen);
            this.groupBoxFechaYRuta.Controls.Add(this.labelOrigen);
            this.groupBoxFechaYRuta.Controls.Add(this.labelDestino);
            this.groupBoxFechaYRuta.Location = new System.Drawing.Point(22, 21);
            this.groupBoxFechaYRuta.Name = "groupBoxFechaYRuta";
            this.groupBoxFechaYRuta.Size = new System.Drawing.Size(566, 139);
            this.groupBoxFechaYRuta.TabIndex = 9;
            this.groupBoxFechaYRuta.TabStop = false;
            this.groupBoxFechaYRuta.Text = "Fecha y ruta requeridas";
            // 
            // btnVerDisponibles
            // 
            this.btnVerDisponibles.Location = new System.Drawing.Point(441, 96);
            this.btnVerDisponibles.Name = "btnVerDisponibles";
            this.btnVerDisponibles.Size = new System.Drawing.Size(110, 23);
            this.btnVerDisponibles.TabIndex = 3;
            this.btnVerDisponibles.Text = "Ver disponibles";
            this.btnVerDisponibles.UseVisualStyleBackColor = true;
            this.btnVerDisponibles.Click += new System.EventHandler(this.btnVerDisponibles_Click);
            // 
            // labelViajesDisponibles
            // 
            this.labelViajesDisponibles.AutoSize = true;
            this.labelViajesDisponibles.Location = new System.Drawing.Point(22, 187);
            this.labelViajesDisponibles.Name = "labelViajesDisponibles";
            this.labelViajesDisponibles.Size = new System.Drawing.Size(83, 13);
            this.labelViajesDisponibles.TabIndex = 10;
            this.labelViajesDisponibles.Text = "Viaje disponible:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(25, 498);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 32);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Cancelar Compra";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregarPasaje
            // 
            this.btnAgregarPasaje.Location = new System.Drawing.Point(32, 38);
            this.btnAgregarPasaje.Name = "btnAgregarPasaje";
            this.btnAgregarPasaje.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarPasaje.TabIndex = 0;
            this.btnAgregarPasaje.Text = "Comprar Pasaje";
            this.btnAgregarPasaje.UseVisualStyleBackColor = true;
            this.btnAgregarPasaje.Click += new System.EventHandler(this.btnAgregarPasaje_Click);
            // 
            // btnAgregarEncomienda
            // 
            this.btnAgregarEncomienda.Location = new System.Drawing.Point(32, 79);
            this.btnAgregarEncomienda.Name = "btnAgregarEncomienda";
            this.btnAgregarEncomienda.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarEncomienda.TabIndex = 1;
            this.btnAgregarEncomienda.Text = "Comprar Encomienda";
            this.btnAgregarEncomienda.UseVisualStyleBackColor = true;
            this.btnAgregarEncomienda.Click += new System.EventHandler(this.btnAgregarEncomienda_Click);
            // 
            // listBoxPasajesYEncomiendasComprados
            // 
            this.listBoxPasajesYEncomiendasComprados.FormattingEnabled = true;
            this.listBoxPasajesYEncomiendasComprados.Location = new System.Drawing.Point(278, 19);
            this.listBoxPasajesYEncomiendasComprados.Name = "listBoxPasajesYEncomiendasComprados";
            this.listBoxPasajesYEncomiendasComprados.Size = new System.Drawing.Size(270, 95);
            this.listBoxPasajesYEncomiendasComprados.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(484, 498);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 32);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Confirmar Compra";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBoxPasajesEncomiendas
            // 
            this.groupBoxPasajesEncomiendas.Controls.Add(this.btnAgregarPasaje);
            this.groupBoxPasajesEncomiendas.Controls.Add(this.listBoxPasajesYEncomiendasComprados);
            this.groupBoxPasajesEncomiendas.Controls.Add(this.btnAgregarEncomienda);
            this.groupBoxPasajesEncomiendas.Enabled = false;
            this.groupBoxPasajesEncomiendas.Location = new System.Drawing.Point(25, 363);
            this.groupBoxPasajesEncomiendas.Name = "groupBoxPasajesEncomiendas";
            this.groupBoxPasajesEncomiendas.Size = new System.Drawing.Size(563, 129);
            this.groupBoxPasajesEncomiendas.TabIndex = 20;
            this.groupBoxPasajesEncomiendas.TabStop = false;
            this.groupBoxPasajesEncomiendas.Text = "Compra de Pasajes y/o Encomiendas";
            // 
            // FormSeleccionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 542);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.labelViajesDisponibles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFechaYRuta);
            this.Controls.Add(this.groupBoxPasajesEncomiendas);
            this.Name = "FormSeleccionViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección del Viaje a Comprar";
            this.Load += new System.EventHandler(this.FormSeleccionViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFechaYRuta.ResumeLayout(false);
            this.groupBoxFechaYRuta.PerformLayout();
            this.groupBoxPasajesEncomiendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxFechaYRuta;
        private System.Windows.Forms.Label labelViajesDisponibles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregarPasaje;
        private System.Windows.Forms.Button btnAgregarEncomienda;
        private System.Windows.Forms.ListBox listBoxPasajesYEncomiendasComprados;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBoxPasajesEncomiendas;
        private System.Windows.Forms.Button btnVerDisponibles;
        private System.Windows.Forms.BindingSource origenBindingSource;
        private System.Windows.Forms.BindingSource destinoBindingSource;
    }
}