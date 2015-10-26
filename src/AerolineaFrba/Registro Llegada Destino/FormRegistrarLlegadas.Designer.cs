namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class FormRegistrarLlegadas
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
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.groupBoxDatosViaje = new System.Windows.Forms.GroupBox();
            this.labelFechaYHoraLlegada = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirmarLlegada = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxDatosViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DisplayMember = "nombre";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(164, 163);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 16;
            this.comboBoxDestino.ValueMember = "id_ciudad";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DisplayMember = "nombre";
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(164, 124);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 14;
            this.comboBoxOrigen.ValueMember = "id_ciudad";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(45, 166);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(100, 13);
            this.labelDestino.TabIndex = 15;
            this.labelDestino.Text = "Seleccione destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(50, 127);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(95, 13);
            this.labelOrigen.TabIndex = 13;
            this.labelOrigen.Text = "Seleccione origen:";
            // 
            // groupBoxDatosViaje
            // 
            this.groupBoxDatosViaje.Controls.Add(this.textBox1);
            this.groupBoxDatosViaje.Controls.Add(this.labelMatricula);
            this.groupBoxDatosViaje.Controls.Add(this.dateTimePicker1);
            this.groupBoxDatosViaje.Controls.Add(this.labelFechaYHoraLlegada);
            this.groupBoxDatosViaje.Controls.Add(this.comboBoxDestino);
            this.groupBoxDatosViaje.Controls.Add(this.comboBoxOrigen);
            this.groupBoxDatosViaje.Controls.Add(this.labelOrigen);
            this.groupBoxDatosViaje.Controls.Add(this.labelDestino);
            this.groupBoxDatosViaje.Location = new System.Drawing.Point(29, 21);
            this.groupBoxDatosViaje.Name = "groupBoxDatosViaje";
            this.groupBoxDatosViaje.Size = new System.Drawing.Size(435, 205);
            this.groupBoxDatosViaje.TabIndex = 17;
            this.groupBoxDatosViaje.TabStop = false;
            this.groupBoxDatosViaje.Text = "Campos Viaje a Registrar Llegada";
            // 
            // labelFechaYHoraLlegada
            // 
            this.labelFechaYHoraLlegada.AutoSize = true;
            this.labelFechaYHoraLlegada.Location = new System.Drawing.Point(26, 41);
            this.labelFechaYHoraLlegada.Name = "labelFechaYHoraLlegada";
            this.labelFechaYHoraLlegada.Size = new System.Drawing.Size(119, 13);
            this.labelFechaYHoraLlegada.TabIndex = 17;
            this.labelFechaYHoraLlegada.Text = "Fecha y Hora de Arribo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(90, 90);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 19;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 20;
            // 
            // btnConfirmarLlegada
            // 
            this.btnConfirmarLlegada.Location = new System.Drawing.Point(374, 250);
            this.btnConfirmarLlegada.Name = "btnConfirmarLlegada";
            this.btnConfirmarLlegada.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmarLlegada.TabIndex = 19;
            this.btnConfirmarLlegada.Text = "Confirmar Arribo";
            this.btnConfirmarLlegada.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(29, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarLlegadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 303);
            this.Controls.Add(this.btnConfirmarLlegada);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxDatosViaje);
            this.Name = "FormRegistrarLlegadas";
            this.Text = "Registro de viajes realizados";
            this.groupBoxDatosViaje.ResumeLayout(false);
            this.groupBoxDatosViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.GroupBox groupBoxDatosViaje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFechaYHoraLlegada;
        private System.Windows.Forms.Button btnConfirmarLlegada;
        private System.Windows.Forms.Button btnLimpiar;
    }
}