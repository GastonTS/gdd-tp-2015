﻿namespace AerolineaFrba.Abm_Ruta
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
            this.labelPrecioBasePorPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.origenBinding = new System.Windows.Forms.BindingSource(this.components);
            this.destinoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tipoServicioBinding = new System.Windows.Forms.BindingSource(this.components);
            this.codRutaBinding = new System.Windows.Forms.BindingSource(this.components);
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.textBoxPrecioPeso = new AerolineaFrba.Abm.TextBoxDecimal();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.labelPrecioFinalPasaje = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.textBoxPrecioPasaje = new AerolineaFrba.Abm.TextBoxDecimal();
            this.labelPrecioFinalPeso = new System.Windows.Forms.Label();
            this.labelValorPrecioFinalPeso = new System.Windows.Forms.Label();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.labelValorPrecioFinalPasaje = new System.Windows.Forms.Label();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodRuta = new AerolineaFrba.Abm.TextBoxNumeros();
            this.groupBoxCamposAltaRuta = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codRutaBinding)).BeginInit();
            this.groupBoxCamposAltaRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrecioBasePorPeso
            // 
            this.labelPrecioBasePorPeso.AutoSize = true;
            this.labelPrecioBasePorPeso.Location = new System.Drawing.Point(6, 113);
            this.labelPrecioBasePorPeso.Name = "labelPrecioBasePorPeso";
            this.labelPrecioBasePorPeso.Size = new System.Drawing.Size(111, 13);
            this.labelPrecioBasePorPeso.TabIndex = 6;
            this.labelPrecioBasePorPeso.Text = "Precio base por Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio base por Pasaje:";
            // 
            // destinoBinding
            // 
            this.destinoBinding.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tipoServicioBinding
            // 
            this.tipoServicioBinding.CurrentChanged += new System.EventHandler(this.asignarPreciosFinalesALabels);
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(430, 222);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(83, 31);
            this.guardar1.TabIndex = 0;
            this.guardar1.TextBtn = "Guardar";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(265, 71);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(100, 13);
            this.labelDestino.TabIndex = 2;
            this.labelDestino.Text = "Seleccione destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(265, 32);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(95, 13);
            this.labelOrigen.TabIndex = 0;
            this.labelOrigen.Text = "Seleccione origen:";
            // 
            // textBoxPrecioPeso
            // 
            this.textBoxPrecioPeso.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxPrecioPeso.ErrorText = "Debe ingresar un valor";
            this.textBoxPrecioPeso.Location = new System.Drawing.Point(125, 111);
            this.textBoxPrecioPeso.Name = "textBoxPrecioPeso";
            this.textBoxPrecioPeso.Size = new System.Drawing.Size(135, 22);
            this.textBoxPrecioPeso.TabIndex = 4;
            this.textBoxPrecioPeso.Leave += new System.EventHandler(this.asignarPreciosFinalesALabels);
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.origenBinding;
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(379, 29);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(103, 21);
            this.comboBoxOrigen.TabIndex = 1;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // labelPrecioFinalPasaje
            // 
            this.labelPrecioFinalPasaje.AutoSize = true;
            this.labelPrecioFinalPasaje.Location = new System.Drawing.Point(269, 142);
            this.labelPrecioFinalPasaje.Name = "labelPrecioFinalPasaje";
            this.labelPrecioFinalPasaje.Size = new System.Drawing.Size(115, 13);
            this.labelPrecioFinalPasaje.TabIndex = 16;
            this.labelPrecioFinalPasaje.Text = "Precio final por Pasaje:";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.destinoBinding;
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(379, 68);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(103, 21);
            this.comboBoxDestino.TabIndex = 2;
            this.comboBoxDestino.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDestino_Validating);
            // 
            // textBoxPrecioPasaje
            // 
            this.textBoxPrecioPasaje.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxPrecioPasaje.ErrorText = "Debe ingresar un valor";
            this.textBoxPrecioPasaje.Location = new System.Drawing.Point(125, 139);
            this.textBoxPrecioPasaje.Name = "textBoxPrecioPasaje";
            this.textBoxPrecioPasaje.Size = new System.Drawing.Size(135, 22);
            this.textBoxPrecioPasaje.TabIndex = 5;
            this.textBoxPrecioPasaje.Leave += new System.EventHandler(this.asignarPreciosFinalesALabels);
            // 
            // labelPrecioFinalPeso
            // 
            this.labelPrecioFinalPeso.AutoSize = true;
            this.labelPrecioFinalPeso.Location = new System.Drawing.Point(269, 113);
            this.labelPrecioFinalPeso.Name = "labelPrecioFinalPeso";
            this.labelPrecioFinalPeso.Size = new System.Drawing.Size(107, 13);
            this.labelPrecioFinalPeso.TabIndex = 15;
            this.labelPrecioFinalPeso.Text = "Precio final por Peso:";
            // 
            // labelValorPrecioFinalPeso
            // 
            this.labelValorPrecioFinalPeso.AutoSize = true;
            this.labelValorPrecioFinalPeso.Location = new System.Drawing.Point(385, 113);
            this.labelValorPrecioFinalPeso.Name = "labelValorPrecioFinalPeso";
            this.labelValorPrecioFinalPeso.Size = new System.Drawing.Size(0, 13);
            this.labelValorPrecioFinalPeso.TabIndex = 17;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(11, 71);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 4;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // labelValorPrecioFinalPasaje
            // 
            this.labelValorPrecioFinalPasaje.AutoSize = true;
            this.labelValorPrecioFinalPasaje.Location = new System.Drawing.Point(385, 142);
            this.labelValorPrecioFinalPasaje.Name = "labelValorPrecioFinalPasaje";
            this.labelValorPrecioFinalPasaje.Size = new System.Drawing.Size(0, 13);
            this.labelValorPrecioFinalPasaje.TabIndex = 18;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.tipoServicioBinding;
            this.comboBoxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(125, 68);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(103, 21);
            this.comboBoxTipoServicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código de ruta:";
            // 
            // textBoxCodRuta
            // 
            this.textBoxCodRuta.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCodRuta.ErrorText = "Debe ingresar un valor";
            this.textBoxCodRuta.Location = new System.Drawing.Point(125, 32);
            this.textBoxCodRuta.Name = "textBoxCodRuta";
            this.textBoxCodRuta.Size = new System.Drawing.Size(139, 22);
            this.textBoxCodRuta.TabIndex = 0;
            // 
            // groupBoxCamposAltaRuta
            // 
            this.groupBoxCamposAltaRuta.Controls.Add(this.textBoxCodRuta);
            this.groupBoxCamposAltaRuta.Controls.Add(this.label2);
            this.groupBoxCamposAltaRuta.Controls.Add(this.label1);
            this.groupBoxCamposAltaRuta.Controls.Add(this.comboBoxTipoServicio);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelPrecioBasePorPeso);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelValorPrecioFinalPasaje);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelTipoServicio);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelValorPrecioFinalPeso);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelPrecioFinalPeso);
            this.groupBoxCamposAltaRuta.Controls.Add(this.textBoxPrecioPasaje);
            this.groupBoxCamposAltaRuta.Controls.Add(this.comboBoxDestino);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelPrecioFinalPasaje);
            this.groupBoxCamposAltaRuta.Controls.Add(this.comboBoxOrigen);
            this.groupBoxCamposAltaRuta.Controls.Add(this.textBoxPrecioPeso);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelOrigen);
            this.groupBoxCamposAltaRuta.Controls.Add(this.labelDestino);
            this.groupBoxCamposAltaRuta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCamposAltaRuta.Name = "groupBoxCamposAltaRuta";
            this.groupBoxCamposAltaRuta.Size = new System.Drawing.Size(501, 193);
            this.groupBoxCamposAltaRuta.TabIndex = 12;
            this.groupBoxCamposAltaRuta.TabStop = false;
            this.groupBoxCamposAltaRuta.Text = "Campos Alta Ruta Aérea";
            this.groupBoxCamposAltaRuta.Enter += new System.EventHandler(this.groupBoxCamposAltaRuta_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAltaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(533, 290);
            this.Controls.Add(this.guardar1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxCamposAltaRuta);
            this.Name = "FormAltaRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Ruta Aérea";
            this.Load += new System.EventHandler(this.FormAltaRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codRutaBinding)).EndInit();
            this.groupBoxCamposAltaRuta.ResumeLayout(false);
            this.groupBoxCamposAltaRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrecioBasePorPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.BindingSource origenBinding;
        private System.Windows.Forms.BindingSource destinoBinding;
        private System.Windows.Forms.BindingSource tipoServicioBinding;
        private System.Windows.Forms.BindingSource codRutaBinding;
        private Abm.Guardar guardar1;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private Abm.TextBoxDecimal textBoxPrecioPeso;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label labelPrecioFinalPasaje;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private Abm.TextBoxDecimal textBoxPrecioPasaje;
        private System.Windows.Forms.Label labelPrecioFinalPeso;
        private System.Windows.Forms.Label labelValorPrecioFinalPeso;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.Label labelValorPrecioFinalPasaje;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Label label2;
        private Abm.TextBoxNumeros textBoxCodRuta;
        private System.Windows.Forms.GroupBox groupBoxCamposAltaRuta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}