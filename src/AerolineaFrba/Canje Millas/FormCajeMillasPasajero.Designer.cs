namespace AerolineaFrba.Canje_Millas
{
    partial class FormCajeMillasPasajero
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
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new AerolineaFrba.Abm.TextBoxDNI();
            this.labelProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.lblCantMillas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMillasRestantes = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblCostoProducto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantidadProducto = new AerolineaFrba.Abm.TextBoxNumeros();
            this.labelVentanillaPasillo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new AerolineaFrba.Abm.Guardar();
            this.lblNoHaySuficientesMillas = new System.Windows.Forms.Label();
            this.groupBoxInfoCliente.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
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
            // textBoxDni
            // 
            this.textBoxDni.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDni.ErrorText = "I";
            this.textBoxDni.Location = new System.Drawing.Point(54, 30);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(143, 20);
            this.textBoxDni.TabIndex = 1;
            this.textBoxDni.TextboxTextChanged += new System.EventHandler(this.textBoxDni_TextboxTextChanged);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(6, 31);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(184, 13);
            this.labelProducto.TabIndex = 2;
            this.labelProducto.Text = "Productos Disponibles para el cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad del producto elegido:";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducto.Enabled = false;
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(201, 28);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducto.TabIndex = 4;
            this.comboBoxProducto.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProducto_SelectionChangeCommitted);
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.Controls.Add(this.lblCantMillas);
            this.groupBoxInfoCliente.Controls.Add(this.label8);
            this.groupBoxInfoCliente.Controls.Add(this.textBoxDni);
            this.groupBoxInfoCliente.Controls.Add(this.labelDni);
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(36, 24);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(458, 76);
            this.groupBoxInfoCliente.TabIndex = 8;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información de cliente";
            // 
            // lblCantMillas
            // 
            this.lblCantMillas.AutoSize = true;
            this.lblCantMillas.Location = new System.Drawing.Point(304, 34);
            this.lblCantMillas.Name = "lblCantMillas";
            this.lblCantMillas.Size = new System.Drawing.Size(0, 13);
            this.lblCantMillas.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Balance de millas:";
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.lblStock);
            this.groupBoxProducto.Controls.Add(this.label6);
            this.groupBoxProducto.Controls.Add(this.lblMillasRestantes);
            this.groupBoxProducto.Controls.Add(this.lblCostoTotal);
            this.groupBoxProducto.Controls.Add(this.lblCostoProducto);
            this.groupBoxProducto.Controls.Add(this.label4);
            this.groupBoxProducto.Controls.Add(this.label3);
            this.groupBoxProducto.Controls.Add(this.label2);
            this.groupBoxProducto.Controls.Add(this.textBoxCantidadProducto);
            this.groupBoxProducto.Controls.Add(this.labelProducto);
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(this.comboBoxProducto);
            this.groupBoxProducto.Location = new System.Drawing.Point(36, 125);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(458, 221);
            this.groupBoxProducto.TabIndex = 9;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto a canjear";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(200, 131);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 13);
            this.lblStock.TabIndex = 14;
            this.lblStock.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock disponible:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblMillasRestantes
            // 
            this.lblMillasRestantes.AutoSize = true;
            this.lblMillasRestantes.Location = new System.Drawing.Point(197, 192);
            this.lblMillasRestantes.Name = "lblMillasRestantes";
            this.lblMillasRestantes.Size = new System.Drawing.Size(0, 13);
            this.lblMillasRestantes.TabIndex = 12;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(198, 162);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblCostoTotal.TabIndex = 11;
            // 
            // lblCostoProducto
            // 
            this.lblCostoProducto.AutoSize = true;
            this.lblCostoProducto.Location = new System.Drawing.Point(197, 105);
            this.lblCostoProducto.Name = "lblCostoProducto";
            this.lblCostoProducto.Size = new System.Drawing.Size(0, 13);
            this.lblCostoProducto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Millas restantes luego del canje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Costo total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo unitario del producto:";
            // 
            // textBoxCantidadProducto
            // 
            this.textBoxCantidadProducto.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCantidadProducto.Enabled = false;
            this.textBoxCantidadProducto.ErrorText = null;
            this.textBoxCantidadProducto.Location = new System.Drawing.Point(197, 69);
            this.textBoxCantidadProducto.Name = "textBoxCantidadProducto";
            this.textBoxCantidadProducto.Size = new System.Drawing.Size(101, 22);
            this.textBoxCantidadProducto.TabIndex = 6;
            this.textBoxCantidadProducto.TextboxTextChanged += new System.EventHandler(this.textBoxCantidadProducto_TextboxTextChanged);
            // 
            // labelVentanillaPasillo
            // 
            this.labelVentanillaPasillo.AutoSize = true;
            this.labelVentanillaPasillo.Location = new System.Drawing.Point(181, -37);
            this.labelVentanillaPasillo.Name = "labelVentanillaPasillo";
            this.labelVentanillaPasillo.Size = new System.Drawing.Size(264, 13);
            this.labelVentanillaPasillo.TabIndex = 19;
            this.labelVentanillaPasillo.Text = "Seleccione Butaca con Ventanilla. El resto será Pasillo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(45, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(411, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.TextBtn = "Guardar";
            // 
            // lblNoHaySuficientesMillas
            // 
            this.lblNoHaySuficientesMillas.AutoSize = true;
            this.lblNoHaySuficientesMillas.Location = new System.Drawing.Point(111, 109);
            this.lblNoHaySuficientesMillas.Name = "lblNoHaySuficientesMillas";
            this.lblNoHaySuficientesMillas.Size = new System.Drawing.Size(285, 13);
            this.lblNoHaySuficientesMillas.TabIndex = 20;
            this.lblNoHaySuficientesMillas.Text = "No tenés suficientes millas para comprar ningun producto :(";
            // 
            // FormCajeMillasPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 445);
            this.Controls.Add(this.lblNoHaySuficientesMillas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelVentanillaPasillo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxInfoCliente);
            this.Controls.Add(this.groupBoxProducto);
            this.Name = "FormCajeMillasPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canje de Millas de Pasajero Frecuente";
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDni;
        private Abm.TextBoxDNI textBoxDni;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label labelVentanillaPasillo;
        private System.Windows.Forms.Button btnLimpiar;
        private Abm.Guardar btnGuardar;
        private Abm.TextBoxNumeros textBoxCantidadProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantMillas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMillasRestantes;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblCostoProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoHaySuficientesMillas;
    }
}