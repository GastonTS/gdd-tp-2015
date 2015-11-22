namespace AerolineaFrba.Abm_Ciudad
{
    partial class FormAltaCiudad
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
            this.textBoxNombreCiudad = new System.Windows.Forms.TextBox();
            this.labelNombreCiudad = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxCiudad = new System.Windows.Forms.GroupBox();
            this.groupBoxCiudad.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombreCiudad
            // 
            this.textBoxNombreCiudad.Location = new System.Drawing.Point(121, 34);
            this.textBoxNombreCiudad.Name = "textBoxNombreCiudad";
            this.textBoxNombreCiudad.Size = new System.Drawing.Size(133, 20);
            this.textBoxNombreCiudad.TabIndex = 0;
            // 
            // labelNombreCiudad
            // 
            this.labelNombreCiudad.AutoSize = true;
            this.labelNombreCiudad.Location = new System.Drawing.Point(18, 37);
            this.labelNombreCiudad.Name = "labelNombreCiudad";
            this.labelNombreCiudad.Size = new System.Drawing.Size(97, 13);
            this.labelNombreCiudad.TabIndex = 1;
            this.labelNombreCiudad.Text = "Nombre de ciudad:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(277, 149);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxCiudad
            // 
            this.groupBoxCiudad.Controls.Add(this.labelNombreCiudad);
            this.groupBoxCiudad.Controls.Add(this.textBoxNombreCiudad);
            this.groupBoxCiudad.Location = new System.Drawing.Point(27, 25);
            this.groupBoxCiudad.Name = "groupBoxCiudad";
            this.groupBoxCiudad.Size = new System.Drawing.Size(325, 80);
            this.groupBoxCiudad.TabIndex = 4;
            this.groupBoxCiudad.TabStop = false;
            this.groupBoxCiudad.Text = "Datos de ciudad a incorporar";
            // 
            // FormAltaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 209);
            this.Controls.Add(this.groupBoxCiudad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "FormAltaCiudad";
            this.Text = "Alta de Ciudad";
            this.groupBoxCiudad.ResumeLayout(false);
            this.groupBoxCiudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreCiudad;
        private System.Windows.Forms.Label labelNombreCiudad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBoxCiudad;
    }
}