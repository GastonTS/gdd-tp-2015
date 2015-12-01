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
            this.labelMedioDePago = new System.Windows.Forms.Label();
            this.comboBoxMedioDePago = new System.Windows.Forms.ComboBox();
            this.labelDNIComprador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptarCompradorPago = new System.Windows.Forms.Button();
            this.btnLimpiarCompradorPago = new System.Windows.Forms.Button();
            this.labelNumeroTarjeta = new System.Windows.Forms.Label();
            this.textBoxNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.labelCodigoSeguridad = new System.Windows.Forms.Label();
            this.textBoxCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxCompraCoutas = new System.Windows.Forms.CheckBox();
            this.comboBoxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.labelTipoTarjeta = new System.Windows.Forms.Label();
            this.btnFinalizarCarga = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxModificarDatos = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptarCompradorPago);
            this.groupBox1.Controls.Add(this.btnLimpiarCompradorPago);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelMedioDePago);
            this.groupBox1.Controls.Add(this.labelDNIComprador);
            this.groupBox1.Controls.Add(this.comboBoxMedioDePago);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medio de Pago y Comprador";
            // 
            // btnAceptarCompradorPago
            // 
            this.btnAceptarCompradorPago.Location = new System.Drawing.Point(192, 143);
            this.btnAceptarCompradorPago.Name = "btnAceptarCompradorPago";
            this.btnAceptarCompradorPago.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCompradorPago.TabIndex = 5;
            this.btnAceptarCompradorPago.Text = "Aceptar";
            this.btnAceptarCompradorPago.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCompradorPago
            // 
            this.btnLimpiarCompradorPago.Location = new System.Drawing.Point(6, 143);
            this.btnLimpiarCompradorPago.Name = "btnLimpiarCompradorPago";
            this.btnLimpiarCompradorPago.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCompradorPago.TabIndex = 4;
            this.btnLimpiarCompradorPago.Text = "Limpiar";
            this.btnLimpiarCompradorPago.UseVisualStyleBackColor = true;
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
            // textBoxNumeroTarjeta
            // 
            this.textBoxNumeroTarjeta.Location = new System.Drawing.Point(144, 31);
            this.textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            this.textBoxNumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroTarjeta.TabIndex = 5;
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
            // textBoxCodigoSeguridad
            // 
            this.textBoxCodigoSeguridad.Location = new System.Drawing.Point(144, 67);
            this.textBoxCodigoSeguridad.Name = "textBoxCodigoSeguridad";
            this.textBoxCodigoSeguridad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoSeguridad.TabIndex = 7;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxCompraCoutas);
            this.groupBox2.Controls.Add(this.comboBoxTipoTarjeta);
            this.groupBox2.Controls.Add(this.labelTipoTarjeta);
            this.groupBox2.Controls.Add(this.labelCodigoSeguridad);
            this.groupBox2.Controls.Add(this.dateTimePickerFechaVencimiento);
            this.groupBox2.Controls.Add(this.textBoxNumeroTarjeta);
            this.groupBox2.Controls.Add(this.labelNumeroTarjeta);
            this.groupBox2.Controls.Add(this.labelFechaVencimiento);
            this.groupBox2.Controls.Add(this.textBoxCodigoSeguridad);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(315, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 188);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Tarjeta de Crédito";
            // 
            // checkBoxCompraCoutas
            // 
            this.checkBoxCompraCoutas.AutoSize = true;
            this.checkBoxCompraCoutas.Location = new System.Drawing.Point(248, 147);
            this.checkBoxCompraCoutas.Name = "checkBoxCompraCoutas";
            this.checkBoxCompraCoutas.Size = new System.Drawing.Size(116, 17);
            this.checkBoxCompraCoutas.TabIndex = 12;
            this.checkBoxCompraCoutas.Text = "Comprar en Cuotas";
            this.checkBoxCompraCoutas.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(100, 145);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoTarjeta.TabIndex = 11;
            // 
            // labelTipoTarjeta
            // 
            this.labelTipoTarjeta.AutoSize = true;
            this.labelTipoTarjeta.Location = new System.Drawing.Point(12, 148);
            this.labelTipoTarjeta.Name = "labelTipoTarjeta";
            this.labelTipoTarjeta.Size = new System.Drawing.Size(82, 13);
            this.labelTipoTarjeta.TabIndex = 10;
            this.labelTipoTarjeta.Text = "Tipo de Tarjeta:";
            // 
            // btnFinalizarCarga
            // 
            this.btnFinalizarCarga.Location = new System.Drawing.Point(584, 439);
            this.btnFinalizarCarga.Name = "btnFinalizarCarga";
            this.btnFinalizarCarga.Size = new System.Drawing.Size(112, 38);
            this.btnFinalizarCarga.TabIndex = 11;
            this.btnFinalizarCarga.Text = "Finalizar Carga";
            this.btnFinalizarCarga.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 439);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 38);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxModificarDatos);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBox3.Controls.Add(this.labelFechaDeNacimiento);
            this.groupBox3.Controls.Add(this.labelMail);
            this.groupBox3.Controls.Add(this.textBoxMail);
            this.groupBox3.Controls.Add(this.labelTelefono);
            this.groupBox3.Controls.Add(this.textBoxTelefono);
            this.groupBox3.Controls.Add(this.labelDireccion);
            this.groupBox3.Controls.Add(this.textBoxDireccion);
            this.groupBox3.Controls.Add(this.labelDNI);
            this.groupBox3.Controls.Add(this.textBoxApellido);
            this.groupBox3.Controls.Add(this.labelApellido);
            this.groupBox3.Controls.Add(this.textBoxNombre);
            this.groupBox3.Controls.Add(this.labelNombre);
            this.groupBox3.Controls.Add(this.textBoxDNI);
            this.groupBox3.Location = new System.Drawing.Point(24, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 192);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del pasajero";
            // 
            // checkBoxModificarDatos
            // 
            this.checkBoxModificarDatos.AutoSize = true;
            this.checkBoxModificarDatos.Location = new System.Drawing.Point(374, 167);
            this.checkBoxModificarDatos.Name = "checkBoxModificarDatos";
            this.checkBoxModificarDatos.Size = new System.Drawing.Size(100, 17);
            this.checkBoxModificarDatos.TabIndex = 17;
            this.checkBoxModificarDatos.Text = "Modificar Datos";
            this.checkBoxModificarDatos.UseVisualStyleBackColor = true;
            this.checkBoxModificarDatos.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(508, 163);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Enabled = false;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(392, 112);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaNacimiento.TabIndex = 14;
            // 
            // labelFechaDeNacimiento
            // 
            this.labelFechaDeNacimiento.AutoSize = true;
            this.labelFechaDeNacimiento.Location = new System.Drawing.Point(264, 118);
            this.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            this.labelFechaDeNacimiento.Size = new System.Drawing.Size(108, 13);
            this.labelFechaDeNacimiento.TabIndex = 13;
            this.labelFechaDeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(264, 82);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(75, 13);
            this.labelMail.TabIndex = 11;
            this.labelMail.Text = "Mail (opcional)";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Enabled = false;
            this.textBoxMail.Location = new System.Drawing.Point(392, 79);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(195, 20);
            this.textBoxMail.TabIndex = 10;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(264, 47);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 9;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Enabled = false;
            this.textBoxTelefono.Location = new System.Drawing.Point(392, 43);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(17, 152);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 7;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Enabled = false;
            this.textBoxDireccion.Location = new System.Drawing.Point(92, 149);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(151, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(17, 46);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 5;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.Location = new System.Drawing.Point(92, 115);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(148, 20);
            this.textBoxApellido.TabIndex = 4;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(17, 118);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(92, 79);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(148, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 82);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(92, 43);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 0;
            // 
            // FormCompraEfectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFinalizarCarga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCompraEfectiva";
            this.Text = "Ingreso de datos para la compra efectiva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMedioDePago;
        private System.Windows.Forms.ComboBox comboBoxMedioDePago;
        private System.Windows.Forms.Label labelDNIComprador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNumeroTarjeta;
        private System.Windows.Forms.TextBox textBoxNumeroTarjeta;
        private System.Windows.Forms.Label labelCodigoSeguridad;
        private System.Windows.Forms.TextBox textBoxCodigoSeguridad;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVencimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxCompraCoutas;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.Label labelTipoTarjeta;
        private System.Windows.Forms.Button btnFinalizarCarga;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptarCompradorPago;
        private System.Windows.Forms.Button btnLimpiarCompradorPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxModificarDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
    }
}