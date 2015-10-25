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
            this.labelFechaViaje = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxFechaYRuta = new System.Windows.Forms.GroupBox();
            this.labelViajesDisponibles = new System.Windows.Forms.Label();
            this.labelCantidadPasajes = new System.Windows.Forms.Label();
            this.labelCantidadEncomienda = new System.Windows.Forms.Label();
            this.textBoxCantidadPasajes = new System.Windows.Forms.TextBox();
            this.textBoxCantidadEncomienda = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFechaYRuta.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(451, 150);
            this.dataGridView1.TabIndex = 8;
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
            // labelCantidadPasajes
            // 
            this.labelCantidadPasajes.AutoSize = true;
            this.labelCantidadPasajes.Location = new System.Drawing.Point(25, 381);
            this.labelCantidadPasajes.Name = "labelCantidadPasajes";
            this.labelCantidadPasajes.Size = new System.Drawing.Size(156, 13);
            this.labelCantidadPasajes.TabIndex = 11;
            this.labelCantidadPasajes.Text = "Cantidad de pasajes a comprar:";
            // 
            // labelCantidadEncomienda
            // 
            this.labelCantidadEncomienda.AutoSize = true;
            this.labelCantidadEncomienda.Location = new System.Drawing.Point(25, 414);
            this.labelCantidadEncomienda.Name = "labelCantidadEncomienda";
            this.labelCantidadEncomienda.Size = new System.Drawing.Size(159, 13);
            this.labelCantidadEncomienda.TabIndex = 12;
            this.labelCantidadEncomienda.Text = "Cantidad de encomienda en Kg:";
            // 
            // textBoxCantidadPasajes
            // 
            this.textBoxCantidadPasajes.Location = new System.Drawing.Point(190, 378);
            this.textBoxCantidadPasajes.Name = "textBoxCantidadPasajes";
            this.textBoxCantidadPasajes.Size = new System.Drawing.Size(79, 20);
            this.textBoxCantidadPasajes.TabIndex = 13;
            // 
            // textBoxCantidadEncomienda
            // 
            this.textBoxCantidadEncomienda.Location = new System.Drawing.Point(190, 411);
            this.textBoxCantidadEncomienda.Name = "textBoxCantidadEncomienda";
            this.textBoxCantidadEncomienda.Size = new System.Drawing.Size(79, 20);
            this.textBoxCantidadEncomienda.TabIndex = 14;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(28, 463);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormSeleccionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 516);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxCantidadEncomienda);
            this.Controls.Add(this.textBoxCantidadPasajes);
            this.Controls.Add(this.labelCantidadEncomienda);
            this.Controls.Add(this.labelCantidadPasajes);
            this.Controls.Add(this.labelViajesDisponibles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFechaYRuta);
            this.Name = "FormSeleccionViaje";
            this.Text = "Selección del Viaje a Comprar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFechaYRuta.ResumeLayout(false);
            this.groupBoxFechaYRuta.PerformLayout();
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
        private System.Windows.Forms.Label labelCantidadPasajes;
        private System.Windows.Forms.Label labelCantidadEncomienda;
        private System.Windows.Forms.TextBox textBoxCantidadPasajes;
        private System.Windows.Forms.TextBox textBoxCantidadEncomienda;
        private System.Windows.Forms.Button btnLimpiar;
    }
}