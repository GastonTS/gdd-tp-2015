﻿namespace AerolineaFrba.Consulta_Millas
{
    partial class FormConsultaMillas
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
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelMillasAcumuladas = new System.Windows.Forms.Label();
            this.textBoxMillasAcumuladas = new System.Windows.Forms.TextBox();
            this.dataGridViewDetalleAcumulacion = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBoxDni = new AerolineaFrba.Abm.TextBoxDNI();
            this.groupBoxInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleAcumulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.Controls.Add(this.textBoxDni);
            this.groupBoxInfoCliente.Controls.Add(this.labelDni);
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(30, 24);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(504, 62);
            this.groupBoxInfoCliente.TabIndex = 9;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información de cliente";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(19, 33);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI:";
            // 
            // labelMillasAcumuladas
            // 
            this.labelMillasAcumuladas.AutoSize = true;
            this.labelMillasAcumuladas.Location = new System.Drawing.Point(27, 154);
            this.labelMillasAcumuladas.Name = "labelMillasAcumuladas";
            this.labelMillasAcumuladas.Size = new System.Drawing.Size(124, 13);
            this.labelMillasAcumuladas.TabIndex = 10;
            this.labelMillasAcumuladas.Text = "Total Millas Acumuladas:";
            // 
            // textBoxMillasAcumuladas
            // 
            this.textBoxMillasAcumuladas.Location = new System.Drawing.Point(157, 151);
            this.textBoxMillasAcumuladas.Name = "textBoxMillasAcumuladas";
            this.textBoxMillasAcumuladas.ReadOnly = true;
            this.textBoxMillasAcumuladas.Size = new System.Drawing.Size(80, 20);
            this.textBoxMillasAcumuladas.TabIndex = 11;
            // 
            // dataGridViewDetalleAcumulacion
            // 
            this.dataGridViewDetalleAcumulacion.AllowUserToAddRows = false;
            this.dataGridViewDetalleAcumulacion.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleAcumulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleAcumulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleAcumulacion.Location = new System.Drawing.Point(30, 186);
            this.dataGridViewDetalleAcumulacion.Name = "dataGridViewDetalleAcumulacion";
            this.dataGridViewDetalleAcumulacion.ReadOnly = true;
            this.dataGridViewDetalleAcumulacion.Size = new System.Drawing.Size(504, 174);
            this.dataGridViewDetalleAcumulacion.TabIndex = 12;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(450, 105);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(84, 23);
            this.btnVer.TabIndex = 19;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(30, 105);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBoxDni
            // 
            this.textBoxDni.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDni.ErrorText = "Por favor ingresa un DNI válido";
            this.textBoxDni.Location = new System.Drawing.Point(57, 29);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(211, 22);
            this.textBoxDni.TabIndex = 3;
            // 
            // FormConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 380);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridViewDetalleAcumulacion);
            this.Controls.Add(this.textBoxMillasAcumuladas);
            this.Controls.Add(this.labelMillasAcumuladas);
            this.Controls.Add(this.groupBoxInfoCliente);
            this.Name = "FormConsultaMillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Millas";
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleAcumulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelMillasAcumuladas;
        private System.Windows.Forms.TextBox textBoxMillasAcumuladas;
        private System.Windows.Forms.DataGridView dataGridViewDetalleAcumulacion;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnLimpiar;
        private Abm.TextBoxDNI textBoxDni;
    }
}