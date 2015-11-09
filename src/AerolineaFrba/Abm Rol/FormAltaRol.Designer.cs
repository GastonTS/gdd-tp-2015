namespace AerolineaFrba.Abm_Rol
{
    partial class FormAltaRol
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFuncionalidades = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.textBoxDNI1 = new AerolineaFrba.Abm.TextBoxDNI();
            this.textBoxMail1 = new AerolineaFrba.Abm.TextBoxMail();
            this.textBoxLetras1 = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxNumeroDecimal1 = new AerolineaFrba.Abm.TextBoxNumeroDecimal();
            this.textBoxValidado1 = new AerolineaFrba.Abm.TextBoxValidado();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(338, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(32, 360);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDNI1);
            this.groupBox1.Controls.Add(this.textBoxMail1);
            this.groupBox1.Controls.Add(this.textBoxLetras1);
            this.groupBox1.Controls.Add(this.textBoxNumeroDecimal1);
            this.groupBox1.Controls.Add(this.textBoxValidado1);
            this.groupBox1.Controls.Add(this.labelFuncionalidades);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.comboBoxFuncionalidades);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos de Rol";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelFuncionalidades
            // 
            this.labelFuncionalidades.AutoSize = true;
            this.labelFuncionalidades.Location = new System.Drawing.Point(17, 93);
            this.labelFuncionalidades.Name = "labelFuncionalidades";
            this.labelFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.labelFuncionalidades.TabIndex = 2;
            this.labelFuncionalidades.Text = "Funcionalidades";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 49);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(123, 90);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuncionalidades.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(123, 46);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(239, 352);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(83, 31);
            this.guardar1.TabIndex = 4;
            // 
            // textBoxDNI1
            // 
            this.textBoxDNI1.ErrorText = "Ingrese un DNI";
            this.textBoxDNI1.Location = new System.Drawing.Point(123, 297);
            this.textBoxDNI1.Name = "textBoxDNI1";
            this.textBoxDNI1.Size = new System.Drawing.Size(211, 22);
            this.textBoxDNI1.TabIndex = 8;
            // 
            // textBoxMail1
            // 
            this.textBoxMail1.ErrorText = "Ingrese un mail";
            this.textBoxMail1.Location = new System.Drawing.Point(123, 266);
            this.textBoxMail1.Name = "textBoxMail1";
            this.textBoxMail1.Size = new System.Drawing.Size(211, 22);
            this.textBoxMail1.TabIndex = 7;
            // 
            // textBoxLetras1
            // 
            this.textBoxLetras1.ErrorText = "Debe tener letras";
            this.textBoxLetras1.Location = new System.Drawing.Point(123, 220);
            this.textBoxLetras1.Name = "textBoxLetras1";
            this.textBoxLetras1.Size = new System.Drawing.Size(211, 22);
            this.textBoxLetras1.TabIndex = 6;
            // 
            // textBoxNumeroDecimal1
            // 
            this.textBoxNumeroDecimal1.ErrorText = "Debe ingresar un numero decimal";
            this.textBoxNumeroDecimal1.Location = new System.Drawing.Point(123, 171);
            this.textBoxNumeroDecimal1.Name = "textBoxNumeroDecimal1";
            this.textBoxNumeroDecimal1.Size = new System.Drawing.Size(211, 22);
            this.textBoxNumeroDecimal1.TabIndex = 5;
            // 
            // textBoxValidado1
            // 
            this.textBoxValidado1.ErrorText = "Este campo no puede estar vacío.";
            this.textBoxValidado1.Location = new System.Drawing.Point(123, 132);
            this.textBoxValidado1.Name = "textBoxValidado1";
            this.textBoxValidado1.Size = new System.Drawing.Size(211, 22);
            this.textBoxValidado1.TabIndex = 4;
            this.textBoxValidado1.Load += new System.EventHandler(this.textBoxValidado1_Load);
            // 
            // FormAltaRol
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.guardar1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.MsgError = "Error al crear Rol. Ingresar los campos correctamente";
            this.MsgExito = "Crea Rol correctamente";
            this.Name = "FormAltaRol";
            this.Text = "Alta Rol";
            this.Load += new System.EventHandler(this.FormAltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelFuncionalidades;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Abm.Guardar guardar1;
        private Abm.TextBoxValidado textBoxValidado1;
        private Abm.TextBoxNumeroDecimal textBoxNumeroDecimal1;
        private Abm.TextBoxLetras textBoxLetras1;
        private Abm.TextBoxMail textBoxMail1;
        private Abm.TextBoxDNI textBoxDNI1;
    }
}