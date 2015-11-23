namespace AerolineaFrba.Generacion_Viaje
{
    partial class FormGenerarViaje
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
            this.labelFechaSalida = new System.Windows.Forms.Label();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.labelFechaLlegada = new System.Windows.Forms.Label();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEstimada = new System.Windows.Forms.Label();
            this.dateTimePickerEstimada = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFechasYHorarios = new System.Windows.Forms.GroupBox();
            this.groupBoxAeronave = new System.Windows.Forms.GroupBox();
            this.btnSeleccionAeronave = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionRuta = new System.Windows.Forms.Button();
            this.textBoxTipoServicio = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxFechasYHorarios.SuspendLayout();
            this.groupBoxAeronave.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFechaSalida
            // 
            this.labelFechaSalida.AutoSize = true;
            this.labelFechaSalida.Location = new System.Drawing.Point(29, 34);
            this.labelFechaSalida.Name = "labelFechaSalida";
            this.labelFechaSalida.Size = new System.Drawing.Size(87, 13);
            this.labelFechaSalida.TabIndex = 0;
            this.labelFechaSalida.Text = "Fecha de Salida:";
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(166, 28);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSalida.TabIndex = 1;
            // 
            // labelFechaLlegada
            // 
            this.labelFechaLlegada.AutoSize = true;
            this.labelFechaLlegada.Location = new System.Drawing.Point(29, 73);
            this.labelFechaLlegada.Name = "labelFechaLlegada";
            this.labelFechaLlegada.Size = new System.Drawing.Size(96, 13);
            this.labelFechaLlegada.TabIndex = 2;
            this.labelFechaLlegada.Text = "Fecha de Llegada:";
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(166, 67);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLlegada.TabIndex = 3;
            this.dateTimePickerLlegada.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerLlegada_Validating);
            // 
            // labelFechaEstimada
            // 
            this.labelFechaEstimada.AutoSize = true;
            this.labelFechaEstimada.Location = new System.Drawing.Point(29, 114);
            this.labelFechaEstimada.Name = "labelFechaEstimada";
            this.labelFechaEstimada.Size = new System.Drawing.Size(131, 13);
            this.labelFechaEstimada.TabIndex = 4;
            this.labelFechaEstimada.Text = "Fecha Estimada de Arribo:";
            // 
            // dateTimePickerEstimada
            // 
            this.dateTimePickerEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEstimada.Location = new System.Drawing.Point(166, 108);
            this.dateTimePickerEstimada.Name = "dateTimePickerEstimada";
            this.dateTimePickerEstimada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEstimada.TabIndex = 5;
            // 
            // groupBoxFechasYHorarios
            // 
            this.groupBoxFechasYHorarios.Controls.Add(this.dateTimePickerLlegada);
            this.groupBoxFechasYHorarios.Controls.Add(this.labelFechaSalida);
            this.groupBoxFechasYHorarios.Controls.Add(this.dateTimePickerEstimada);
            this.groupBoxFechasYHorarios.Controls.Add(this.dateTimePickerSalida);
            this.groupBoxFechasYHorarios.Controls.Add(this.labelFechaEstimada);
            this.groupBoxFechasYHorarios.Controls.Add(this.labelFechaLlegada);
            this.groupBoxFechasYHorarios.Location = new System.Drawing.Point(34, 17);
            this.groupBoxFechasYHorarios.Name = "groupBoxFechasYHorarios";
            this.groupBoxFechasYHorarios.Size = new System.Drawing.Size(475, 155);
            this.groupBoxFechasYHorarios.TabIndex = 8;
            this.groupBoxFechasYHorarios.TabStop = false;
            this.groupBoxFechasYHorarios.Text = "Fechas y Horarios Programados";
            // 
            // groupBoxAeronave
            // 
            this.groupBoxAeronave.Controls.Add(this.btnSeleccionAeronave);
            this.groupBoxAeronave.Controls.Add(this.textBoxMatricula);
            this.groupBoxAeronave.Controls.Add(this.labelMatricula);
            this.groupBoxAeronave.Location = new System.Drawing.Point(34, 196);
            this.groupBoxAeronave.Name = "groupBoxAeronave";
            this.groupBoxAeronave.Size = new System.Drawing.Size(475, 73);
            this.groupBoxAeronave.TabIndex = 9;
            this.groupBoxAeronave.TabStop = false;
            this.groupBoxAeronave.Text = "Selección de Aeronave";
            // 
            // btnSeleccionAeronave
            // 
            this.btnSeleccionAeronave.Location = new System.Drawing.Point(214, 28);
            this.btnSeleccionAeronave.Name = "btnSeleccionAeronave";
            this.btnSeleccionAeronave.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionAeronave.TabIndex = 2;
            this.btnSeleccionAeronave.Text = "Seleccionar";
            this.btnSeleccionAeronave.UseVisualStyleBackColor = true;
            this.btnSeleccionAeronave.Click += new System.EventHandler(this.btnSeleccionAeronave_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Enabled = false;
            this.textBoxMatricula.Location = new System.Drawing.Point(90, 30);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricula.TabIndex = 1;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(29, 33);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionRuta);
            this.groupBox1.Controls.Add(this.textBoxTipoServicio);
            this.groupBox1.Controls.Add(this.textBoxDestino);
            this.groupBox1.Controls.Add(this.textBoxOrigen);
            this.groupBox1.Controls.Add(this.labelTipoServicio);
            this.groupBox1.Controls.Add(this.labelDestino);
            this.groupBox1.Controls.Add(this.labelOrigen);
            this.groupBox1.Location = new System.Drawing.Point(34, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de Ruta Aérea";
            // 
            // btnSeleccionRuta
            // 
            this.btnSeleccionRuta.Location = new System.Drawing.Point(264, 93);
            this.btnSeleccionRuta.Name = "btnSeleccionRuta";
            this.btnSeleccionRuta.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionRuta.TabIndex = 3;
            this.btnSeleccionRuta.Text = "Seleccionar";
            this.btnSeleccionRuta.UseVisualStyleBackColor = true;
            this.btnSeleccionRuta.Click += new System.EventHandler(this.btnSeleccionRuta_Click);
            // 
            // textBoxTipoServicio
            // 
            this.textBoxTipoServicio.Enabled = false;
            this.textBoxTipoServicio.Location = new System.Drawing.Point(125, 95);
            this.textBoxTipoServicio.Name = "textBoxTipoServicio";
            this.textBoxTipoServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoServicio.TabIndex = 5;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Enabled = false;
            this.textBoxDestino.Location = new System.Drawing.Point(125, 66);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestino.TabIndex = 4;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Enabled = false;
            this.textBoxOrigen.Location = new System.Drawing.Point(125, 37);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrigen.TabIndex = 3;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(29, 98);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 2;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(29, 69);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(82, 13);
            this.labelDestino.TabIndex = 1;
            this.labelDestino.Text = "Ciudad Destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(29, 40);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(77, 13);
            this.labelOrigen.TabIndex = 0;
            this.labelOrigen.Text = "Ciudad Origen:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(434, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(34, 461);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 508);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxFechasYHorarios);
            this.Controls.Add(this.groupBoxAeronave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGenerarViaje";
            this.Text = "Creación de un Nuevo Viaje";
            this.Load += new System.EventHandler(this.FormGenerarViaje_Load);
            this.groupBoxFechasYHorarios.ResumeLayout(false);
            this.groupBoxFechasYHorarios.PerformLayout();
            this.groupBoxAeronave.ResumeLayout(false);
            this.groupBoxAeronave.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFechaSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.Label labelFechaLlegada;
        private System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
        private System.Windows.Forms.Label labelFechaEstimada;
        private System.Windows.Forms.DateTimePicker dateTimePickerEstimada;
        private System.Windows.Forms.GroupBox groupBoxFechasYHorarios;
        private System.Windows.Forms.GroupBox groupBoxAeronave;
        private System.Windows.Forms.Button btnSeleccionAeronave;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Button btnSeleccionRuta;
        private System.Windows.Forms.TextBox textBoxTipoServicio;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}