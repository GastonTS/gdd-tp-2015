using System;
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
            this.components = new System.ComponentModel.Container();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelCapacidadEncomiendas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMatricula = new AerolineaFrba.Abm.TextBoxValidado();
            this.textBoxFabricante = new AerolineaFrba.Abm.TextBoxLetras();
            this.textBoxModelo = new AerolineaFrba.Abm.TextBoxLetras();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.bindingSourceTipoServicio = new System.Windows.Forms.BindingSource(this.components);
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidadButacas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.textBoxCapacidadEncomiendas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.btnElegirTipoButaca = new System.Windows.Forms.Button();
            this.labelVentanillaPasillo = new System.Windows.Forms.Label();
            this.checkedListBoxButacas = new System.Windows.Forms.CheckedListBox();
            this.labelCantidadButacas = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.guardar1 = new AerolineaFrba.Abm.Guardar();
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
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
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.textBoxFabricante);
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
            // textBoxMatricula
            // 
            this.textBoxMatricula.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxMatricula.ErrorText = "Debe ingresar la matrícula";
            this.textBoxMatricula.Location = new System.Drawing.Point(105, 58);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(139, 22);
            this.textBoxMatricula.TabIndex = 1;
            // 
            // textBoxFabricante
            // 
            this.textBoxFabricante.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxFabricante.ErrorText = "Debe ingresar el fabricante";
            this.textBoxFabricante.Location = new System.Drawing.Point(105, 94);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(211, 22);
            this.textBoxFabricante.TabIndex = 2;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxModelo.ErrorText = "Debe ingresar el modelo";
            this.textBoxModelo.Location = new System.Drawing.Point(105, 30);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(211, 22);
            this.textBoxModelo.TabIndex = 0;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.bindingSourceTipoServicio;
            this.comboBoxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBox2.Controls.Add(this.checkedListBoxButacas);
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
            this.textBoxCantidadButacas.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCantidadButacas.ErrorText = "Debe ingresar una cantidad de butacas";
            this.textBoxCantidadButacas.Location = new System.Drawing.Point(120, 149);
            this.textBoxCantidadButacas.Name = "textBoxCantidadButacas";
            this.textBoxCantidadButacas.Size = new System.Drawing.Size(124, 22);
            this.textBoxCantidadButacas.TabIndex = 2;
            this.textBoxCantidadButacas.TextboxTextChanged += new System.EventHandler(this.textBoxCantidadButacas_TextChanged);
            // 
            // textBoxCapacidadEncomiendas
            // 
            this.textBoxCapacidadEncomiendas.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCapacidadEncomiendas.ErrorText = "Debe ingresar la capacidad en encomiendas";
            this.textBoxCapacidadEncomiendas.Location = new System.Drawing.Point(105, 59);
            this.textBoxCapacidadEncomiendas.Name = "textBoxCapacidadEncomiendas";
            this.textBoxCapacidadEncomiendas.Size = new System.Drawing.Size(211, 22);
            this.textBoxCapacidadEncomiendas.TabIndex = 1;
            // 
            // btnElegirTipoButaca
            // 
            this.btnElegirTipoButaca.Enabled = false;
            this.btnElegirTipoButaca.Location = new System.Drawing.Point(16, 177);
            this.btnElegirTipoButaca.Name = "btnElegirTipoButaca";
            this.btnElegirTipoButaca.Size = new System.Drawing.Size(189, 23);
            this.btnElegirTipoButaca.TabIndex = 3;
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
            // checkedListBoxButacas
            // 
            this.checkedListBoxButacas.Enabled = false;
            this.checkedListBoxButacas.FormattingEnabled = true;
            this.checkedListBoxButacas.Location = new System.Drawing.Point(253, 111);
            this.checkedListBoxButacas.Name = "checkedListBoxButacas";
            this.checkedListBoxButacas.Size = new System.Drawing.Size(179, 154);
            this.checkedListBoxButacas.TabIndex = 3;
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
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(425, 460);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(83, 31);
            this.guardar1.TabIndex = 0;
            this.guardar1.TextBtn = "Guardar";
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(533, 517);
            this.Controls.Add(this.guardar1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MsgError = "Error al dar de alta aeronave, compruebe los campos ingresados";
            this.MsgExito = "Aeronave cargada exitosamente";
            this.Name = "FormAltaAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Aeronave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
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
        private System.Windows.Forms.CheckedListBox checkedListBoxButacas;
        private Abm.TextBoxLetras textBoxFabricante;
        private Abm.TextBoxLetras textBoxModelo;
        private Abm.Guardar guardar1;
        private Abm.TextBoxNumeros textBoxCapacidadEncomiendas;
        private Abm.TextBoxNumeros textBoxCantidadButacas;
        private System.Windows.Forms.BindingSource bindingSourceTipoServicio;
        private GD2C2015DataSet gD2C2015DataSet;
        private Abm.TextBoxValidado textBoxMatricula;
    }
}