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
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.listBoxFuncionalidades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFuncionalidades = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(516, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.listBoxFuncionalidades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelFuncionalidades);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.comboBoxFuncionalidades);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos de Rol";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(477, 228);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(292, 77);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // listBoxFuncionalidades
            // 
            this.listBoxFuncionalidades.FormattingEnabled = true;
            this.listBoxFuncionalidades.Location = new System.Drawing.Point(409, 62);
            this.listBoxFuncionalidades.Name = "listBoxFuncionalidades";
            this.listBoxFuncionalidades.Size = new System.Drawing.Size(143, 160);
            this.listBoxFuncionalidades.TabIndex = 5;
            this.listBoxFuncionalidades.SelectedValueChanged += new System.EventHandler(this.listBoxFuncionalidades_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Funcionalidades del Rol:";
            // 
            // labelFuncionalidades
            // 
            this.labelFuncionalidades.AutoSize = true;
            this.labelFuncionalidades.Location = new System.Drawing.Point(17, 81);
            this.labelFuncionalidades.Name = "labelFuncionalidades";
            this.labelFuncionalidades.Size = new System.Drawing.Size(87, 13);
            this.labelFuncionalidades.TabIndex = 2;
            this.labelFuncionalidades.Text = "Funcionalidades:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 46);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(123, 78);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(163, 21);
            this.comboBoxFuncionalidades.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(123, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(319, 292);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(83, 31);
            this.guardar1.TabIndex = 4;
            // 
            // FormAltaRol
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(603, 332);
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
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListBox listBoxFuncionalidades;
        private System.Windows.Forms.Label label1;
    }
}