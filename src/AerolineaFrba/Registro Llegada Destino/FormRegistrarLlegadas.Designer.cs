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
            this.components = new System.ComponentModel.Container();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.origenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.groupBoxDatosViaje = new System.Windows.Forms.GroupBox();
            this.textBoxMatricula = new AerolineaFrba.Abm.TextBoxValidado();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.fechaCoso = new System.Windows.Forms.DateTimePicker();
            this.labelFechaYHoraLlegada = new System.Windows.Forms.Label();
            this.btnConfirmarLlegada = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).BeginInit();
            this.groupBoxDatosViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.destinoBindingSource;
            this.comboBoxDestino.DisplayMember = "id_ciudad";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(164, 163);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 16;
            this.comboBoxDestino.ValueMember = "id_ciudad";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.origenBindingSource;
            this.comboBoxOrigen.DisplayMember = "id_ciudad";
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
            this.groupBoxDatosViaje.Controls.Add(this.textBoxMatricula);
            this.groupBoxDatosViaje.Controls.Add(this.labelMatricula);
            this.groupBoxDatosViaje.Controls.Add(this.fechaCoso);
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
            // textBoxMatricula
            // 
            this.textBoxMatricula.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxMatricula.ErrorText = "Debe ingresar la matricula";
            this.textBoxMatricula.Location = new System.Drawing.Point(164, 87);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(211, 22);
            this.textBoxMatricula.TabIndex = 21;
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
            // fechaCoso
            // 
            this.fechaCoso.Location = new System.Drawing.Point(164, 35);
            this.fechaCoso.MaxDate = new System.DateTime(2049, 12, 27, 0, 0, 0, 0);
            this.fechaCoso.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.fechaCoso.Name = "fechaCoso";
            this.fechaCoso.Size = new System.Drawing.Size(200, 20);
            this.fechaCoso.TabIndex = 18;
            this.fechaCoso.TabStop = false;
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
            // btnConfirmarLlegada
            // 
            this.btnConfirmarLlegada.Location = new System.Drawing.Point(374, 250);
            this.btnConfirmarLlegada.Name = "btnConfirmarLlegada";
            this.btnConfirmarLlegada.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmarLlegada.TabIndex = 19;
            this.btnConfirmarLlegada.Text = "Confirmar Arribo";
            this.btnConfirmarLlegada.UseVisualStyleBackColor = true;
            this.btnConfirmarLlegada.Click += new System.EventHandler(this.btnConfirmarLlegada_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(29, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.DateTimePicker fechaCoso;
        private System.Windows.Forms.Label labelFechaYHoraLlegada;
        private System.Windows.Forms.Button btnConfirmarLlegada;
        private System.Windows.Forms.Button btnLimpiar;
        private Abm.TextBoxValidado textBoxMatricula;
        private System.Windows.Forms.BindingSource origenBindingSource;
        private System.Windows.Forms.BindingSource destinoBindingSource;
    }
}