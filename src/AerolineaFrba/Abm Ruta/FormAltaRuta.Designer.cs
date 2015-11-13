namespace AerolineaFrba.Abm_Ruta
{
    partial class FormAltaRuta
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
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelPrecioBasePorPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.origenBinding = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.destinoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPrecioPasaje = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.tipoServicioBinding = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxCamposAltaRuta = new System.Windows.Forms.GroupBox();
            this.textBoxPrecioPeso = new AerolineaFrba.Abm.TextBoxNumeroDecimal();
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).BeginInit();
            this.groupBoxCamposAltaRuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(23, 54);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(95, 13);
            this.labelOrigen.TabIndex = 0;
            this.labelOrigen.Text = "Seleccione origen:";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(23, 93);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(100, 13);
            this.labelDestino.TabIndex = 2;
            this.labelDestino.Text = "Seleccione destino:";
            // 
            // labelPrecioBasePorPeso
            // 
            this.labelPrecioBasePorPeso.AutoSize = true;
            this.labelPrecioBasePorPeso.Location = new System.Drawing.Point(23, 210);
            this.labelPrecioBasePorPeso.Name = "labelPrecioBasePorPeso";
            this.labelPrecioBasePorPeso.Size = new System.Drawing.Size(111, 13);
            this.labelPrecioBasePorPeso.TabIndex = 6;
            this.labelPrecioBasePorPeso.Text = "Precio base por Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio base por Pasaje:";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.origenBinding;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(137, 51);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 1;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.destinoBinding;
            this.comboBoxDestino.DisplayMember = "N";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(137, 90);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 3;
            // 
            // destinoBinding
            // 
            this.destinoBinding.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // textBoxPrecioPasaje
            // 
            this.textBoxPrecioPasaje.Location = new System.Drawing.Point(148, 236);
            this.textBoxPrecioPasaje.Name = "textBoxPrecioPasaje";
            this.textBoxPrecioPasaje.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioPasaje.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(26, 289);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(363, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(23, 134);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 4;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.tipoServicioBinding;
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(137, 131);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipoServicio.TabIndex = 5;
            // 
            // groupBoxCamposAltaRuta
            // 
            this.groupBoxCamposAltaRuta.Controls.Add(this.textBoxPrecioPeso);
            this.groupBoxCamposAltaRuta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCamposAltaRuta.Name = "groupBoxCamposAltaRuta";
            this.groupBoxCamposAltaRuta.Size = new System.Drawing.Size(444, 270);
            this.groupBoxCamposAltaRuta.TabIndex = 12;
            this.groupBoxCamposAltaRuta.TabStop = false;
            this.groupBoxCamposAltaRuta.Text = "Campos Alta Ruta Aérea";
            this.groupBoxCamposAltaRuta.Enter += new System.EventHandler(this.groupBoxCamposAltaRuta_Enter);
            // 
            // textBoxPrecioPeso
            // 
            this.textBoxPrecioPeso.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxPrecioPeso.ErrorText = null;
            this.textBoxPrecioPeso.Location = new System.Drawing.Point(136, 196);
            this.textBoxPrecioPeso.Name = "textBoxPrecioPeso";
            this.textBoxPrecioPeso.Size = new System.Drawing.Size(211, 22);
            this.textBoxPrecioPeso.TabIndex = 0;
            
            // 
            // FormAltaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 329);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.labelTipoServicio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxPrecioPasaje);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrecioBasePorPeso);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.groupBoxCamposAltaRuta);
            this.Name = "FormAltaRuta";
            this.Text = "Alta Ruta Aérea";
            this.Load += new System.EventHandler(this.FormAltaRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).EndInit();
            this.groupBoxCamposAltaRuta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelPrecioBasePorPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.TextBox textBoxPrecioPasaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.GroupBox groupBoxCamposAltaRuta;
        private System.Windows.Forms.BindingSource origenBinding;
        private System.Windows.Forms.BindingSource destinoBinding;
        private System.Windows.Forms.BindingSource tipoServicioBinding;
        private Abm.TextBoxNumeroDecimal textBoxPrecioPeso;
    }
}