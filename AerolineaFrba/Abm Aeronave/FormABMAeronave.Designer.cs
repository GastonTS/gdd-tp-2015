namespace AerolineaFrba.Abm_Aeronave
{
    partial class FormABMAeronave
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
            this.aeronaveBox = new System.Windows.Forms.GroupBox();
            this.labelFuncionalidades = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.aeronaveBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(329, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(23, 251);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // aeronaveBox
            // 
            this.aeronaveBox.Controls.Add(this.labelFuncionalidades);
            this.aeronaveBox.Controls.Add(this.labelNombre);
            this.aeronaveBox.Controls.Add(this.comboBoxFuncionalidades);
            this.aeronaveBox.Controls.Add(this.textBoxNombre);
            this.aeronaveBox.Location = new System.Drawing.Point(23, 24);
            this.aeronaveBox.Name = "aeronaveBox";
            this.aeronaveBox.Size = new System.Drawing.Size(384, 200);
            this.aeronaveBox.TabIndex = 3;
            this.aeronaveBox.TabStop = false;
            this.aeronaveBox.Text = "Aeronave";
            this.aeronaveBox.Enter += new System.EventHandler(this.aeronaveBox_Enter);
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
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
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
            // 
            // FormABMAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 360);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.aeronaveBox);
            this.Name = "FormABMAeronave";
            this.Text = "ABM Aeronave";
            this.aeronaveBox.ResumeLayout(false);
            this.aeronaveBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox aeronaveBox;
        private System.Windows.Forms.Label labelFuncionalidades;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}