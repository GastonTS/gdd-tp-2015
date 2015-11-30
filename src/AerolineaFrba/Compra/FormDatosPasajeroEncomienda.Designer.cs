namespace AerolineaFrba.Compra
{
    partial class FormDatosPasajeroEncomienda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxButacaYEncomienda = new System.Windows.Forms.GroupBox();
            this.labelVentanillaOPasillo = new System.Windows.Forms.Label();
            this.textBoxCantidadAEncomendar = new System.Windows.Forms.TextBox();
            this.labelEncomienda = new System.Windows.Forms.Label();
            this.labelButaca = new System.Windows.Forms.Label();
            this.listBoxEleccionButaca = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxButacaYEncomienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxModificarDatos);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBox1.Controls.Add(this.labelFechaDeNacimiento);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pasajero";
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
            this.checkBoxModificarDatos.CheckedChanged += new System.EventHandler(this.checkBoxModificarDatos_CheckedChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(508, 163);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 404);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 31);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBoxButacaYEncomienda
            // 
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelVentanillaOPasillo);
            this.groupBoxButacaYEncomienda.Controls.Add(this.textBoxCantidadAEncomendar);
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelEncomienda);
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelButaca);
            this.groupBoxButacaYEncomienda.Controls.Add(this.listBoxEleccionButaca);
            this.groupBoxButacaYEncomienda.Location = new System.Drawing.Point(24, 232);
            this.groupBoxButacaYEncomienda.Name = "groupBoxButacaYEncomienda";
            this.groupBoxButacaYEncomienda.Size = new System.Drawing.Size(642, 166);
            this.groupBoxButacaYEncomienda.TabIndex = 17;
            this.groupBoxButacaYEncomienda.TabStop = false;
            this.groupBoxButacaYEncomienda.Text = "Elección Butaca (si accede desde agregar encomienda, por Y Encomienda de nombre)";
            // 
            // labelVentanillaOPasillo
            // 
            this.labelVentanillaOPasillo.AutoSize = true;
            this.labelVentanillaOPasillo.Location = new System.Drawing.Point(47, 140);
            this.labelVentanillaOPasillo.Name = "labelVentanillaOPasillo";
            this.labelVentanillaOPasillo.Size = new System.Drawing.Size(198, 13);
            this.labelVentanillaOPasillo.TabIndex = 4;
            this.labelVentanillaOPasillo.Text = "La butaca seleccionada corresponde a: ";
            // 
            // textBoxCantidadAEncomendar
            // 
            this.textBoxCantidadAEncomendar.Enabled = false;
            this.textBoxCantidadAEncomendar.Location = new System.Drawing.Point(489, 36);
            this.textBoxCantidadAEncomendar.Name = "textBoxCantidadAEncomendar";
            this.textBoxCantidadAEncomendar.Size = new System.Drawing.Size(78, 20);
            this.textBoxCantidadAEncomendar.TabIndex = 3;
            this.textBoxCantidadAEncomendar.TextChanged += new System.EventHandler(this.textBoxCantidadAEncomendar_TextChanged);
            // 
            // labelEncomienda
            // 
            this.labelEncomienda.AutoSize = true;
            this.labelEncomienda.Location = new System.Drawing.Point(359, 36);
            this.labelEncomienda.Name = "labelEncomienda";
            this.labelEncomienda.Size = new System.Drawing.Size(123, 13);
            this.labelEncomienda.TabIndex = 2;
            this.labelEncomienda.Text = "Cantidad a encomendar:";
            // 
            // labelButaca
            // 
            this.labelButaca.AutoSize = true;
            this.labelButaca.Location = new System.Drawing.Point(47, 36);
            this.labelButaca.Name = "labelButaca";
            this.labelButaca.Size = new System.Drawing.Size(44, 13);
            this.labelButaca.TabIndex = 1;
            this.labelButaca.Text = "Butaca:";
            // 
            // listBoxEleccionButaca
            // 
            this.listBoxEleccionButaca.FormattingEnabled = true;
            this.listBoxEleccionButaca.Location = new System.Drawing.Point(119, 36);
            this.listBoxEleccionButaca.Name = "listBoxEleccionButaca";
            this.listBoxEleccionButaca.Size = new System.Drawing.Size(120, 95);
            this.listBoxEleccionButaca.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(583, 404);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormDatosPasajeroEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 447);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxButacaYEncomienda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDatosPasajeroEncomienda";
            this.Text = "Ingrese los datos de un Pasajero y/o Encomienda";
            this.Load += new System.EventHandler(this.FormDatosPasajeroEncomienda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxButacaYEncomienda.ResumeLayout(false);
            this.groupBoxButacaYEncomienda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxButacaYEncomienda;
        private System.Windows.Forms.TextBox textBoxCantidadAEncomendar;
        private System.Windows.Forms.Label labelEncomienda;
        private System.Windows.Forms.Label labelButaca;
        private System.Windows.Forms.ListBox listBoxEleccionButaca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelVentanillaOPasillo;
        private System.Windows.Forms.CheckBox checkBoxModificarDatos;
        private System.Windows.Forms.Button btnActualizar;
    }
}