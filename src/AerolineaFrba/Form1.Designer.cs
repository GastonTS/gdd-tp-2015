﻿namespace AerolineaFrba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaRuta = new System.Windows.Forms.Button();
            this.btnModRol = new System.Windows.Forms.Button();
            this.btnBajaRol = new System.Windows.Forms.Button();
            this.btnAltaNave = new System.Windows.Forms.Button();
            this.btnAltaCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaRol
            // 
            this.btnAltaRol.Location = new System.Drawing.Point(26, 105);
            this.btnAltaRol.Name = "btnAltaRol";
            this.btnAltaRol.Size = new System.Drawing.Size(92, 23);
            this.btnAltaRol.TabIndex = 0;
            this.btnAltaRol.Text = "Ir a Alta Rol";
            this.btnAltaRol.UseVisualStyleBackColor = true;
            this.btnAltaRol.Click += new System.EventHandler(this.btnAltaRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario principal de la aplicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para ir probando los distintos formularios, los llamo desde acá";
            // 
            // btnAltaRuta
            // 
            this.btnAltaRuta.Location = new System.Drawing.Point(217, 105);
            this.btnAltaRuta.Name = "btnAltaRuta";
            this.btnAltaRuta.Size = new System.Drawing.Size(100, 23);
            this.btnAltaRuta.TabIndex = 3;
            this.btnAltaRuta.Text = "Ir a Alta Ruta";
            this.btnAltaRuta.UseVisualStyleBackColor = true;
            this.btnAltaRuta.Click += new System.EventHandler(this.btnAltaRuta_Click);
            // 
            // btnModRol
            // 
            this.btnModRol.Location = new System.Drawing.Point(26, 146);
            this.btnModRol.Name = "btnModRol";
            this.btnModRol.Size = new System.Drawing.Size(92, 23);
            this.btnModRol.TabIndex = 4;
            this.btnModRol.Text = "Ir modificar a rol";
            this.btnModRol.UseVisualStyleBackColor = true;
            this.btnModRol.Click += new System.EventHandler(this.btnModRol_Click_1);
            // 
            // btnBajaRol
            // 
            this.btnBajaRol.Location = new System.Drawing.Point(26, 186);
            this.btnBajaRol.Name = "btnBajaRol";
            this.btnBajaRol.Size = new System.Drawing.Size(92, 23);
            this.btnBajaRol.TabIndex = 5;
            this.btnBajaRol.Text = "Ir a Baja Rol";
            this.btnBajaRol.UseVisualStyleBackColor = true;
            this.btnBajaRol.Click += new System.EventHandler(this.btnBajaRol_Click);
            // 
            // btnAltaNave
            // 
            this.btnAltaNave.Location = new System.Drawing.Point(217, 186);
            this.btnAltaNave.Name = "btnAltaNave";
            this.btnAltaNave.Size = new System.Drawing.Size(100, 23);
            this.btnAltaNave.TabIndex = 6;
            this.btnAltaNave.Text = "Ir Alta Aeronave";
            this.btnAltaNave.UseVisualStyleBackColor = true;
            this.btnAltaNave.Click += new System.EventHandler(this.btnAltaNave_Click);
            // 
            // btnAltaCiudad
            // 
            this.btnAltaCiudad.Location = new System.Drawing.Point(217, 146);
            this.btnAltaCiudad.Name = "btnAltaCiudad";
            this.btnAltaCiudad.Size = new System.Drawing.Size(100, 23);
            this.btnAltaCiudad.TabIndex = 7;
            this.btnAltaCiudad.Text = "Ir a Alta Ciudades";
            this.btnAltaCiudad.UseVisualStyleBackColor = true;
            this.btnAltaCiudad.Click += new System.EventHandler(this.btnAltaCiudad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 328);
            this.Controls.Add(this.btnAltaCiudad);
            this.Controls.Add(this.btnAltaNave);
            this.Controls.Add(this.btnBajaRol);
            this.Controls.Add(this.btnModRol);
            this.Controls.Add(this.btnAltaRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaRol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAltaRuta;
        private System.Windows.Forms.Button btnModRol;
        private System.Windows.Forms.Button btnBajaRol;
        private System.Windows.Forms.Button btnAltaNave;
        private System.Windows.Forms.Button btnAltaCiudad;
    }
}

