namespace AerolineaFrba.Abm_Aeronave
{
    partial class FormAltaAeronave
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
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelCapacidadEncomiendas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFabricante = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxMatricula = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxModelo = new AerolineaFrba.Abm.TextBoxLetras();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidadButacas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.textBoxCapacidadEncomiendas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.btnElegirTipoButaca = new System.Windows.Forms.Button();
            this.labelVentanillaPasillo = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelCantidadButacas = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(54, 31);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(44, 63);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(39, 97);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(60, 13);
            this.labelFabricante.TabIndex = 3;
            this.labelFabricante.Text = "Fabricante:";
            // 
            // labelCapacidadEncomiendas
            // 
            this.labelCapacidadEncomiendas.AutoSize = true;
            this.labelCapacidadEncomiendas.Location = new System.Drawing.Point(25, 55);
            this.labelCapacidadEncomiendas.Name = "labelCapacidadEncomiendas";
            this.labelCapacidadEncomiendas.Size = new System.Drawing.Size(74, 26);
            this.labelCapacidadEncomiendas.TabIndex = 6;
            this.labelCapacidadEncomiendas.Text = "Capacidad de\r\nEncomiendas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFabricante);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.labelMatricula);
            this.groupBox1.Controls.Add(this.labelFabricante);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación de Aeronave";
            // 
            // textBoxFabricante
            // 
            this.textBoxFabricante.ErrorText = "Debe ingresar el fabricante";
            this.textBoxFabricante.Location = new System.Drawing.Point(105, 94);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(211, 22);
            this.textBoxFabricante.TabIndex = 6;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.ErrorText = "Debe ingresar la matrícula";
            this.textBoxMatricula.Location = new System.Drawing.Point(105, 62);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(211, 22);
            this.textBoxMatricula.TabIndex = 5;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.ErrorText = "Debe ingresar el modelo";
            this.textBoxModelo.Location = new System.Drawing.Point(105, 30);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(211, 22);
            this.textBoxModelo.TabIndex = 4;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(105, 25);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipoServicio.TabIndex = 0;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(12, 28);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 10;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCantidadButacas);
            this.groupBox2.Controls.Add(this.textBoxCapacidadEncomiendas);
            this.groupBox2.Controls.Add(this.btnElegirTipoButaca);
            this.groupBox2.Controls.Add(this.labelVentanillaPasillo);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.labelCantidadButacas);
            this.groupBox2.Controls.Add(this.labelTipoServicio);
            this.groupBox2.Controls.Add(this.comboBoxTipoServicio);
            this.groupBox2.Controls.Add(this.labelCapacidadEncomiendas);
            this.groupBox2.Location = new System.Drawing.Point(21, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 279);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características de la Aeronave";
            // 
            // textBoxCantidadButacas
            // 
            this.textBoxCantidadButacas.ErrorText = "Debe ingresar una cantidad de butacas";
            this.textBoxCantidadButacas.Location = new System.Drawing.Point(120, 149);
            this.textBoxCantidadButacas.Name = "textBoxCantidadButacas";
            this.textBoxCantidadButacas.Size = new System.Drawing.Size(124, 22);
            this.textBoxCantidadButacas.TabIndex = 20;
            // 
            // textBoxCapacidadEncomiendas
            // 
            this.textBoxCapacidadEncomiendas.Enabled = false;
            this.textBoxCapacidadEncomiendas.ErrorText = "Debe ingresar la cantidad de encomiendas";
            this.textBoxCapacidadEncomiendas.Location = new System.Drawing.Point(105, 59);
            this.textBoxCapacidadEncomiendas.Name = "textBoxCapacidadEncomiendas";
            this.textBoxCapacidadEncomiendas.Size = new System.Drawing.Size(211, 22);
            this.textBoxCapacidadEncomiendas.TabIndex = 19;
            // 
            // btnElegirTipoButaca
            // 
            this.btnElegirTipoButaca.Enabled = false;
            this.btnElegirTipoButaca.Location = new System.Drawing.Point(16, 177);
            this.btnElegirTipoButaca.Name = "btnElegirTipoButaca";
            this.btnElegirTipoButaca.Size = new System.Drawing.Size(189, 23);
            this.btnElegirTipoButaca.TabIndex = 17;
            this.btnElegirTipoButaca.Text = "Elegir Ventana/Pasillo";
            this.btnElegirTipoButaca.UseVisualStyleBackColor = true;
            this.btnElegirTipoButaca.Click += new System.EventHandler(this.btnElegirTipoButaca_Click);
            // 
            // labelVentanillaPasillo
            // 
            this.labelVentanillaPasillo.AutoSize = true;
            this.labelVentanillaPasillo.Location = new System.Drawing.Point(205, 95);
            this.labelVentanillaPasillo.Name = "labelVentanillaPasillo";
            this.labelVentanillaPasillo.Size = new System.Drawing.Size(264, 13);
            this.labelVentanillaPasillo.TabIndex = 16;
            this.labelVentanillaPasillo.Text = "Seleccione Butaca con Ventanilla. El resto será Pasillo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(253, 111);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(179, 154);
            this.checkedListBox1.TabIndex = 3;
            // 
            // labelCantidadButacas
            // 
            this.labelCantidadButacas.AutoSize = true;
            this.labelCantidadButacas.Location = new System.Drawing.Point(12, 154);
            this.labelCantidadButacas.Name = "labelCantidadButacas";
            this.labelCantidadButacas.Size = new System.Drawing.Size(109, 13);
            this.labelCantidadButacas.TabIndex = 13;
            this.labelCantidadButacas.Text = "Cantidad de Butacas:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 468);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(433, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(306, 468);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(83, 31);
            this.guardar1.TabIndex = 15;
            // 
            // FormAltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(533, 517);
            this.Controls.Add(this.guardar1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MsgError = "Error al dar de alta aeronave, compruebe los campos ingresados";
            this.MsgExito = "Aeronave cargada exitosamente";
            this.Name = "FormAltaAeronave";
            this.Text = "Alta Aeronave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelCapacidadEncomiendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCantidadButacas;
        private System.Windows.Forms.Label labelVentanillaPasillo;
        private System.Windows.Forms.Button btnElegirTipoButaca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Abm.TextBoxLetras textBoxFabricante;
        private Abm.TextBoxLetras textBoxMatricula;
        private Abm.TextBoxLetras textBoxModelo;
        private Abm.Guardar guardar1;
        private Abm.TextBoxNumeros textBoxCapacidadEncomiendas;
        private Abm.TextBoxNumeros textBoxCantidadButacas;
    }
}