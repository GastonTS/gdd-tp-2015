namespace AerolineaFrba
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.btnAltaRuta.Location = new System.Drawing.Point(217, 265);
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
            this.btnAltaCiudad.Location = new System.Drawing.Point(217, 105);
            this.btnAltaCiudad.Name = "btnAltaCiudad";
            this.btnAltaCiudad.Size = new System.Drawing.Size(100, 23);
            this.btnAltaCiudad.TabIndex = 7;
            this.btnAltaCiudad.Text = "Ir a Alta Ciudades";
            this.btnAltaCiudad.UseVisualStyleBackColor = true;
            this.btnAltaCiudad.Click += new System.EventHandler(this.btnAltaCiudad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ir seleccion ciudades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ir Modificacion Rutas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ir seleccion aeronave";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

