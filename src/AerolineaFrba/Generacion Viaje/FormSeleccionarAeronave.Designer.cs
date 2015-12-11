namespace AerolineaFrba.Generacion_Viaje
{
    partial class FormSeleccionarAeronave
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
            this.dataGridViewAeronave = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidadButacas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.labelCantidadButacas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCapacidadEncomiendas = new AerolineaFrba.Abm.TextBoxNumeros();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.tipoServicioBinding = new System.Windows.Forms.BindingSource(this.components);
            this.labelCapacidadEncomiendas = new System.Windows.Forms.Label();
            this.bindingSourceTipoServicio = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxFabricante = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bindingAeronaves = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAeronave)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAeronave
            // 
            this.dataGridViewAeronave.AllowUserToAddRows = false;
            this.dataGridViewAeronave.AllowUserToDeleteRows = false;
            this.dataGridViewAeronave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAeronave.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAeronave.Location = new System.Drawing.Point(21, 204);
            this.dataGridViewAeronave.MultiSelect = false;
            this.dataGridViewAeronave.Name = "dataGridViewAeronave";
            this.dataGridViewAeronave.ReadOnly = true;
            this.dataGridViewAeronave.Size = new System.Drawing.Size(718, 190);
            this.dataGridViewAeronave.TabIndex = 23;
            this.dataGridViewAeronave.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAeronave_CellEnter);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(655, 166);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(84, 23);
            this.btnSeleccionar.TabIndex = 22;
            this.btnSeleccionar.Text = "Buscar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(21, 166);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCantidadButacas);
            this.groupBox2.Controls.Add(this.labelCantidadButacas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCapacidadEncomiendas);
            this.groupBox2.Controls.Add(this.comboBoxTipoServicio);
            this.groupBox2.Controls.Add(this.labelCapacidadEncomiendas);
            this.groupBox2.Location = new System.Drawing.Point(394, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 138);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características de la Aeronave";
            // 
            // textBoxCantidadButacas
            // 
            this.textBoxCantidadButacas.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCantidadButacas.ErrorText = "Debe ingresar cantidad de butacas";
            this.textBoxCantidadButacas.Location = new System.Drawing.Point(171, 86);
            this.textBoxCantidadButacas.Name = "textBoxCantidadButacas";
            this.textBoxCantidadButacas.Size = new System.Drawing.Size(110, 20);
            this.textBoxCantidadButacas.TabIndex = 2;
            // 
            // labelCantidadButacas
            // 
            this.labelCantidadButacas.AutoSize = true;
            this.labelCantidadButacas.Location = new System.Drawing.Point(54, 89);
            this.labelCantidadButacas.Name = "labelCantidadButacas";
            this.labelCantidadButacas.Size = new System.Drawing.Size(109, 13);
            this.labelCantidadButacas.TabIndex = 13;
            this.labelCantidadButacas.Text = "Cantidad de Butacas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Servicio:";
            // 
            // textBoxCapacidadEncomiendas
            // 
            this.textBoxCapacidadEncomiendas.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxCapacidadEncomiendas.ErrorText = "Debe ingresar la capacidad de encomiendas";
            this.textBoxCapacidadEncomiendas.Location = new System.Drawing.Point(171, 60);
            this.textBoxCapacidadEncomiendas.Name = "textBoxCapacidadEncomiendas";
            this.textBoxCapacidadEncomiendas.Size = new System.Drawing.Size(110, 20);
            this.textBoxCapacidadEncomiendas.TabIndex = 1;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.tipoServicioBinding;
            this.comboBoxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(105, 25);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTipoServicio.TabIndex = 0;
            // 
            // labelCapacidadEncomiendas
            // 
            this.labelCapacidadEncomiendas.AutoSize = true;
            this.labelCapacidadEncomiendas.Location = new System.Drawing.Point(12, 63);
            this.labelCapacidadEncomiendas.Name = "labelCapacidadEncomiendas";
            this.labelCapacidadEncomiendas.Size = new System.Drawing.Size(151, 13);
            this.labelCapacidadEncomiendas.TabIndex = 6;
            this.labelCapacidadEncomiendas.Text = "Capacidad para encomiendas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.textBoxFabricante);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.labelMatricula);
            this.groupBox1.Controls.Add(this.labelFabricante);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 138);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación de Aeronave";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(105, 28);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(126, 20);
            this.textBoxModelo.TabIndex = 0;
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
            // textBoxFabricante
            // 
            this.textBoxFabricante.Location = new System.Drawing.Point(105, 94);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(126, 20);
            this.textBoxFabricante.TabIndex = 2;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(105, 60);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(126, 20);
            this.textBoxMatricula.TabIndex = 1;
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
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(636, 410);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 29);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormSeleccionarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridViewAeronave);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSeleccionarAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Aeronave para Viaje";
            this.Load += new System.EventHandler(this.FormSeleccionarAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAeronave)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAeronaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAeronave;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private Abm.TextBoxNumeros textBoxCantidadButacas;
        private System.Windows.Forms.Label labelCantidadButacas;
        private System.Windows.Forms.Label label1;
        private Abm.TextBoxNumeros textBoxCapacidadEncomiendas;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Label labelCapacidadEncomiendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxFabricante;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bindingAeronaves;
        private System.Windows.Forms.BindingSource bindingSourceTipoServicio;
        private System.Windows.Forms.BindingSource tipoServicioBinding;
    }
}