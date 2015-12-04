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
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.textBoxCantidadProducto = new AerolineaFrba.Abm.TextBoxNumeros();
            this.labelVentanillaPasillo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new AerolineaFrba.Abm.Guardar();
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
            this.textBoxDni.Size = new System.Drawing.Size(104, 20);
            this.textBoxDni.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(43, 69);
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
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.Controls.Add(this.btnVerProductos);
            this.groupBoxInfoCliente.Controls.Add(this.textBoxDni);
            this.groupBoxInfoCliente.Controls.Add(this.labelDni);
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(36, 24);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(404, 62);
            this.groupBoxInfoCliente.TabIndex = 8;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información de cliente";
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(201, 27);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(121, 23);
            this.btnVerProductos.TabIndex = 2;
            this.btnVerProductos.Text = "Ver sus Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.textBoxCantidadProducto);
            this.groupBoxProducto.Controls.Add(this.labelProducto);
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(this.comboBoxProducto);
            this.groupBoxProducto.Location = new System.Drawing.Point(36, 110);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(404, 100);
            this.groupBoxProducto.TabIndex = 9;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto a canjear";
            // 
            // textBoxCantidadProducto
            // 
            this.textBoxCantidadProducto.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCantidadProducto.ErrorText = null;
            this.textBoxCantidadProducto.Location = new System.Drawing.Point(201, 69);
            this.textBoxCantidadProducto.Name = "textBoxCantidadProducto";
            this.textBoxCantidadProducto.Size = new System.Drawing.Size(101, 22);
            this.textBoxCantidadProducto.TabIndex = 6;
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
            this.btnLimpiar.Location = new System.Drawing.Point(36, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(357, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.TextBtn = "Guardar";
            // 
            // FormCajeMillasPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 281);
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
        private System.Windows.Forms.Button btnVerProductos;
        private Abm.Guardar btnGuardar;
        private Abm.TextBoxNumeros textBoxCantidadProducto;
    }
}