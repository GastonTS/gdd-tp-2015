﻿namespace AerolineaFrba.Compra
{
    partial class FormDatosCliente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new AerolineaFrba.Abm.Guardar();
            this.textBoxMail = new AerolineaFrba.Abm.TextBoxMail();
            this.textBoxTelefono = new AerolineaFrba.Abm.TextBoxNumeros();
            this.textBoxDireccion = new AerolineaFrba.Abm.TextBoxValidado();
            this.textBoxApellido = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxNombre = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxDNI = new AerolineaFrba.Abm.TextBoxDNI();
            this.checkBoxModificarDatos = new System.Windows.Forms.CheckBox();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Controls.Add(this.textBoxMail);
            this.groupBox3.Controls.Add(this.textBoxTelefono);
            this.groupBox3.Controls.Add(this.textBoxDireccion);
            this.groupBox3.Controls.Add(this.textBoxApellido);
            this.groupBox3.Controls.Add(this.textBoxNombre);
            this.groupBox3.Controls.Add(this.textBoxDNI);
            this.groupBox3.Controls.Add(this.checkBoxModificarDatos);
            this.groupBox3.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBox3.Controls.Add(this.labelFechaDeNacimiento);
            this.groupBox3.Controls.Add(this.labelMail);
            this.groupBox3.Controls.Add(this.labelTelefono);
            this.groupBox3.Controls.Add(this.labelDireccion);
            this.groupBox3.Controls.Add(this.labelDNI);
            this.groupBox3.Controls.Add(this.labelApellido);
            this.groupBox3.Controls.Add(this.labelNombre);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 192);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del pasajero";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(504, 153);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.TextBtn = "Guardar";
            // 
            // textBoxMail
            // 
            this.textBoxMail.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxMail.Enabled = false;
            this.textBoxMail.ErrorText = "El mail debe ser vacio o con el formato \"ejemplo@ejemplo.dominio\"";
            this.textBoxMail.Location = new System.Drawing.Point(392, 80);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(211, 22);
            this.textBoxMail.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxTelefono.Enabled = false;
            this.textBoxTelefono.ErrorText = "Debe ingresar el Telefono (solo numeros)";
            this.textBoxTelefono.Location = new System.Drawing.Point(392, 43);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(161, 22);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDireccion.Enabled = false;
            this.textBoxDireccion.ErrorText = "Debe ingresar la Direccion";
            this.textBoxDireccion.Location = new System.Drawing.Point(92, 143);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(164, 22);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.ErrorText = "Debe ingresar el Apellido";
            this.textBoxApellido.Location = new System.Drawing.Point(92, 112);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(151, 22);
            this.textBoxApellido.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.ErrorText = "Debe ingresar el Nombre";
            this.textBoxNombre.Location = new System.Drawing.Point(92, 79);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(151, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDNI.ErrorText = "Debe ingresar un DNI valido (entre 7 y 8 digitos)";
            this.textBoxDNI.Location = new System.Drawing.Point(92, 43);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(135, 22);
            this.textBoxDNI.TabIndex = 0;
            this.textBoxDNI.TextboxTextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // checkBoxModificarDatos
            // 
            this.checkBoxModificarDatos.AutoSize = true;
            this.checkBoxModificarDatos.Location = new System.Drawing.Point(376, 158);
            this.checkBoxModificarDatos.Name = "checkBoxModificarDatos";
            this.checkBoxModificarDatos.Size = new System.Drawing.Size(100, 17);
            this.checkBoxModificarDatos.TabIndex = 8;
            this.checkBoxModificarDatos.Text = "Modificar Datos";
            this.checkBoxModificarDatos.UseVisualStyleBackColor = true;
            this.checkBoxModificarDatos.CheckedChanged += new System.EventHandler(this.checkBoxModificarDatos_CheckedChanged_1);
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Enabled = false;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(392, 112);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaNacimiento.TabIndex = 6;
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
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(264, 47);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 9;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(17, 146);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 7;
            this.labelDireccion.Text = "Dirección";
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
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(17, 116);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 80);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 31);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormDatosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese los Datos del Pasajero";
            this.Load += new System.EventHandler(this.FormDatosCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxModificarDatos;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private Abm.TextBoxDNI textBoxDNI;
        private Abm.TextBoxLetras textBoxNombre;
        private Abm.TextBoxValidado textBoxDireccion;
        private Abm.TextBoxLetras textBoxApellido;
        private Abm.TextBoxMail textBoxMail;
        private Abm.TextBoxNumeros textBoxTelefono;
        private Abm.Guardar btnAceptar;
    }
}