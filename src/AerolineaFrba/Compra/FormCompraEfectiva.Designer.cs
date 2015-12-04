namespace AerolineaFrba.Compra
{
    partial class FormCompraEfectiva
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
            this.labelMedioDePago = new System.Windows.Forms.Label();
            this.comboBoxMedioDePago = new System.Windows.Forms.ComboBox();
            this.labelDNIComprador = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNumeroTarjeta = new System.Windows.Forms.Label();
            this.labelCodigoSeguridad = new System.Windows.Forms.Label();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTarjetaCredito = new System.Windows.Forms.GroupBox();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoSeguridad = new AerolineaFrba.Abm.TextBoxNumeros();
            this.textBoxNumeroTarjeta = new AerolineaFrba.Abm.TextBoxNumeros();
            this.checkBoxCompraCoutas = new System.Windows.Forms.CheckBox();
            this.comboBoxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.labelTipoTarjeta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxDNI = new AerolineaFrba.Abm.TextBoxDNI();
            this.groupBox1.SuspendLayout();
            this.groupBoxTarjetaCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMedioDePago
            // 
            this.labelMedioDePago.AutoSize = true;
            this.labelMedioDePago.Location = new System.Drawing.Point(33, 47);
            this.labelMedioDePago.Name = "labelMedioDePago";
            this.labelMedioDePago.Size = new System.Drawing.Size(82, 13);
            this.labelMedioDePago.TabIndex = 0;
            this.labelMedioDePago.Text = "Medio de Pago:";
            // 
            // comboBoxMedioDePago
            // 
            this.comboBoxMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedioDePago.FormattingEnabled = true;
            this.comboBoxMedioDePago.Location = new System.Drawing.Point(121, 44);
            this.comboBoxMedioDePago.Name = "comboBoxMedioDePago";
            this.comboBoxMedioDePago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedioDePago.TabIndex = 1;
            this.comboBoxMedioDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedioDePago_SelectedIndexChanged);
            this.comboBoxMedioDePago.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMedioDePago_SelectionChangeCommitted);
            // 
            // labelDNIComprador
            // 
            this.labelDNIComprador.AutoSize = true;
            this.labelDNIComprador.Location = new System.Drawing.Point(15, 89);
            this.labelDNIComprador.Name = "labelDNIComprador";
            this.labelDNIComprador.Size = new System.Drawing.Size(100, 13);
            this.labelDNIComprador.TabIndex = 2;
            this.labelDNIComprador.Text = "DNI del Comprador:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelMedioDePago);
            this.groupBox1.Controls.Add(this.labelDNIComprador);
            this.groupBox1.Controls.Add(this.comboBoxMedioDePago);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medio de Pago y Comprador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar Datos del Comprador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNumeroTarjeta
            // 
            this.labelNumeroTarjeta.AutoSize = true;
            this.labelNumeroTarjeta.Location = new System.Drawing.Point(40, 34);
            this.labelNumeroTarjeta.Name = "labelNumeroTarjeta";
            this.labelNumeroTarjeta.Size = new System.Drawing.Size(98, 13);
            this.labelNumeroTarjeta.TabIndex = 4;
            this.labelNumeroTarjeta.Text = "Número de Tarjeta:";
            // 
            // labelCodigoSeguridad
            // 
            this.labelCodigoSeguridad.AutoSize = true;
            this.labelCodigoSeguridad.Location = new System.Drawing.Point(26, 70);
            this.labelCodigoSeguridad.Name = "labelCodigoSeguridad";
            this.labelCodigoSeguridad.Size = new System.Drawing.Size(112, 13);
            this.labelCodigoSeguridad.TabIndex = 6;
            this.labelCodigoSeguridad.Text = "Código de Serguridad:";
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Location = new System.Drawing.Point(96, 111);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(42, 13);
            this.labelFechaVencimiento.TabIndex = 8;
            this.labelFechaVencimiento.Text = "MMAA:";
            // 
            // dateTimePickerFechaVencimiento
            // 
            this.dateTimePickerFechaVencimiento.Location = new System.Drawing.Point(144, 105);
            this.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento";
            this.dateTimePickerFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaVencimiento.TabIndex = 9;
            this.dateTimePickerFechaVencimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerFechaVencimiento_Validating);
            // 
            // groupBoxTarjetaCredito
            // 
            this.groupBoxTarjetaCredito.Controls.Add(this.lblCantCuotas);
            this.groupBoxTarjetaCredito.Controls.Add(this.label1);
            this.groupBoxTarjetaCredito.Controls.Add(this.textBoxCodigoSeguridad);
            this.groupBoxTarjetaCredito.Controls.Add(this.textBoxNumeroTarjeta);
            this.groupBoxTarjetaCredito.Controls.Add(this.checkBoxCompraCoutas);
            this.groupBoxTarjetaCredito.Controls.Add(this.comboBoxTipoTarjeta);
            this.groupBoxTarjetaCredito.Controls.Add(this.labelTipoTarjeta);
            this.groupBoxTarjetaCredito.Controls.Add(this.labelCodigoSeguridad);
            this.groupBoxTarjetaCredito.Controls.Add(this.dateTimePickerFechaVencimiento);
            this.groupBoxTarjetaCredito.Controls.Add(this.labelNumeroTarjeta);
            this.groupBoxTarjetaCredito.Controls.Add(this.labelFechaVencimiento);
            this.groupBoxTarjetaCredito.Enabled = false;
            this.groupBoxTarjetaCredito.Location = new System.Drawing.Point(24, 182);
            this.groupBoxTarjetaCredito.Name = "groupBoxTarjetaCredito";
            this.groupBoxTarjetaCredito.Size = new System.Drawing.Size(519, 206);
            this.groupBoxTarjetaCredito.TabIndex = 10;
            this.groupBoxTarjetaCredito.TabStop = false;
            this.groupBoxTarjetaCredito.Text = "Datos de Tarjeta de Crédito";
            this.groupBoxTarjetaCredito.Visible = false;
            // 
            // lblCantCuotas
            // 
            this.lblCantCuotas.AutoSize = true;
            this.lblCantCuotas.Location = new System.Drawing.Point(384, 151);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(0, 13);
            this.lblCantCuotas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de cuotas:";
            // 
            // textBoxCodigoSeguridad
            // 
            this.textBoxCodigoSeguridad.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCodigoSeguridad.ErrorText = "El codigo de seguridad debe ser un numero";
            this.textBoxCodigoSeguridad.Location = new System.Drawing.Point(144, 67);
            this.textBoxCodigoSeguridad.Name = "textBoxCodigoSeguridad";
            this.textBoxCodigoSeguridad.Size = new System.Drawing.Size(211, 22);
            this.textBoxCodigoSeguridad.TabIndex = 14;
            // 
            // textBoxNumeroTarjeta
            // 
            this.textBoxNumeroTarjeta.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxNumeroTarjeta.ErrorText = "Debe ingresarse un numero valido";
            this.textBoxNumeroTarjeta.Location = new System.Drawing.Point(144, 31);
            this.textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            this.textBoxNumeroTarjeta.Size = new System.Drawing.Size(211, 22);
            this.textBoxNumeroTarjeta.TabIndex = 13;
            // 
            // checkBoxCompraCoutas
            // 
            this.checkBoxCompraCoutas.AutoSize = true;
            this.checkBoxCompraCoutas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompraCoutas.Location = new System.Drawing.Point(43, 178);
            this.checkBoxCompraCoutas.Name = "checkBoxCompraCoutas";
            this.checkBoxCompraCoutas.Size = new System.Drawing.Size(116, 17);
            this.checkBoxCompraCoutas.TabIndex = 12;
            this.checkBoxCompraCoutas.Text = "Comprar en Cuotas";
            this.checkBoxCompraCoutas.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(144, 145);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoTarjeta.TabIndex = 11;
            this.comboBoxTipoTarjeta.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTipoTarjeta_SelectionChangeCommitted);
            // 
            // labelTipoTarjeta
            // 
            this.labelTipoTarjeta.AutoSize = true;
            this.labelTipoTarjeta.Location = new System.Drawing.Point(56, 148);
            this.labelTipoTarjeta.Name = "labelTipoTarjeta";
            this.labelTipoTarjeta.Size = new System.Drawing.Size(82, 13);
            this.labelTipoTarjeta.TabIndex = 10;
            this.labelTipoTarjeta.Text = "Tipo de Tarjeta:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 38);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(429, 394);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(114, 38);
            this.guardar1.TabIndex = 13;
            this.guardar1.TextBtn = "Finalizar carga";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDNI.ErrorText = "Ingrese un DNI valido";
            this.textBoxDNI.Location = new System.Drawing.Point(121, 86);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(146, 22);
            this.textBoxDNI.TabIndex = 8;
            // 
            // FormCompraEfectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(569, 449);
            this.Controls.Add(this.guardar1);
            this.Controls.Add(this.groupBoxTarjetaCredito);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCompraEfectiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de datos para la compra efectiva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTarjetaCredito.ResumeLayout(false);
            this.groupBoxTarjetaCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMedioDePago;
        private System.Windows.Forms.ComboBox comboBoxMedioDePago;
        private System.Windows.Forms.Label labelDNIComprador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNumeroTarjeta;
        private System.Windows.Forms.Label labelCodigoSeguridad;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVencimiento;
        private System.Windows.Forms.GroupBox groupBoxTarjetaCredito;
        private System.Windows.Forms.CheckBox checkBoxCompraCoutas;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.Label labelTipoTarjeta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private Abm.TextBoxNumeros textBoxCodigoSeguridad;
        private Abm.TextBoxNumeros textBoxNumeroTarjeta;
        private Abm.Guardar guardar1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblCantCuotas;
        private System.Windows.Forms.Label label1;
        private Abm.TextBoxDNI textBoxDNI;
    }
}