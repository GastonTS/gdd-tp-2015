namespace AerolineaFrba.Abm_Aeronave
{
    partial class FormSeleccionAeronave
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxFabricante = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidadButacas = new System.Windows.Forms.TextBox();
            this.labelCantidadButacas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCapacidadEncomiendas = new System.Windows.Forms.TextBox();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.bindingSourceTipoServicio = new System.Windows.Forms.BindingSource(this.components);
            this.labelCapacidadEncomiendas = new System.Windows.Forms.Label();
            this.groupBoxEstadoAeronave = new System.Windows.Forms.GroupBox();
            this.checkBoxPorVidaUtil = new System.Windows.Forms.CheckBox();
            this.checkBoxBajaPorServicio = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dataGridViewAeronave = new System.Windows.Forms.DataGridView();
            this.bindingAeronaves = new System.Windows.Forms.BindingSource(this.components);
            this.btnModificarAeronave = new System.Windows.Forms.Button();
            this.btnBajaFueraServicio = new System.Windows.Forms.Button();
            this.btnBajaVidaUtil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).BeginInit();
            this.groupBoxEstadoAeronave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAeronave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.textBoxFabricante);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.labelMatricula);
            this.groupBox1.Controls.Add(this.labelFabricante);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación de Aeronave";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(105, 28);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 20);
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
            this.textBoxFabricante.Size = new System.Drawing.Size(100, 20);
            this.textBoxFabricante.TabIndex = 2;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(105, 60);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 20);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCantidadButacas);
            this.groupBox2.Controls.Add(this.labelCantidadButacas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCapacidadEncomiendas);
            this.groupBox2.Controls.Add(this.comboBoxTipoServicio);
            this.groupBox2.Controls.Add(this.labelCapacidadEncomiendas);
            this.groupBox2.Location = new System.Drawing.Point(27, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 67);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características de la Aeronave";
            // 
            // textBoxCantidadButacas
            // 
            this.textBoxCantidadButacas.Location = new System.Drawing.Point(634, 24);
            this.textBoxCantidadButacas.Name = "textBoxCantidadButacas";
            this.textBoxCantidadButacas.Size = new System.Drawing.Size(59, 20);
            this.textBoxCantidadButacas.TabIndex = 2;
            // 
            // labelCantidadButacas
            // 
            this.labelCantidadButacas.AutoSize = true;
            this.labelCantidadButacas.Location = new System.Drawing.Point(519, 28);
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
            this.textBoxCapacidadEncomiendas.Location = new System.Drawing.Point(421, 25);
            this.textBoxCapacidadEncomiendas.Name = "textBoxCapacidadEncomiendas";
            this.textBoxCapacidadEncomiendas.Size = new System.Drawing.Size(59, 20);
            this.textBoxCapacidadEncomiendas.TabIndex = 1;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.bindingSourceTipoServicio;
            this.comboBoxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(105, 25);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(125, 21);
            this.comboBoxTipoServicio.TabIndex = 0;
            // 
            // labelCapacidadEncomiendas
            // 
            this.labelCapacidadEncomiendas.AutoSize = true;
            this.labelCapacidadEncomiendas.Location = new System.Drawing.Point(262, 28);
            this.labelCapacidadEncomiendas.Name = "labelCapacidadEncomiendas";
            this.labelCapacidadEncomiendas.Size = new System.Drawing.Size(151, 13);
            this.labelCapacidadEncomiendas.TabIndex = 6;
            this.labelCapacidadEncomiendas.Text = "Capacidad para encomiendas:";
            // 
            // groupBoxEstadoAeronave
            // 
            this.groupBoxEstadoAeronave.Controls.Add(this.checkBoxPorVidaUtil);
            this.groupBoxEstadoAeronave.Controls.Add(this.checkBoxBajaPorServicio);
            this.groupBoxEstadoAeronave.Location = new System.Drawing.Point(407, 25);
            this.groupBoxEstadoAeronave.Name = "groupBoxEstadoAeronave";
            this.groupBoxEstadoAeronave.Size = new System.Drawing.Size(338, 138);
            this.groupBoxEstadoAeronave.TabIndex = 15;
            this.groupBoxEstadoAeronave.TabStop = false;
            this.groupBoxEstadoAeronave.Text = "Estado actual de la Aeronave";
            // 
            // checkBoxPorVidaUtil
            // 
            this.checkBoxPorVidaUtil.AutoSize = true;
            this.checkBoxPorVidaUtil.Location = new System.Drawing.Point(19, 75);
            this.checkBoxPorVidaUtil.Name = "checkBoxPorVidaUtil";
            this.checkBoxPorVidaUtil.Size = new System.Drawing.Size(122, 17);
            this.checkBoxPorVidaUtil.TabIndex = 1;
            this.checkBoxPorVidaUtil.Text = "de Baja por Vida Útil";
            this.checkBoxPorVidaUtil.UseVisualStyleBackColor = true;
            this.checkBoxPorVidaUtil.CheckedChanged += new System.EventHandler(this.checkBoxPorVidaUtil_CheckedChanged);
            // 
            // checkBoxBajaPorServicio
            // 
            this.checkBoxBajaPorServicio.AutoSize = true;
            this.checkBoxBajaPorServicio.Location = new System.Drawing.Point(19, 40);
            this.checkBoxBajaPorServicio.Name = "checkBoxBajaPorServicio";
            this.checkBoxBajaPorServicio.Size = new System.Drawing.Size(168, 17);
            this.checkBoxBajaPorServicio.TabIndex = 0;
            this.checkBoxBajaPorServicio.Text = "De Baja por Fuera de Servicio";
            this.checkBoxBajaPorServicio.UseVisualStyleBackColor = true;
            this.checkBoxBajaPorServicio.CheckedChanged += new System.EventHandler(this.checkBoxBajaPorServicio_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 267);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(661, 267);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(84, 23);
            this.btnSeleccionar.TabIndex = 17;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dataGridViewAeronave
            // 
            this.dataGridViewAeronave.AllowUserToAddRows = false;
            this.dataGridViewAeronave.AllowUserToDeleteRows = false;
            this.dataGridViewAeronave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAeronave.Location = new System.Drawing.Point(27, 306);
            this.dataGridViewAeronave.Name = "dataGridViewAeronave";
            this.dataGridViewAeronave.ReadOnly = true;
            this.dataGridViewAeronave.Size = new System.Drawing.Size(718, 205);
            this.dataGridViewAeronave.TabIndex = 18;
            this.dataGridViewAeronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAeronave_CellContentClick);
            // 
            // btnModificarAeronave
            // 
            this.btnModificarAeronave.Enabled = false;
            this.btnModificarAeronave.Location = new System.Drawing.Point(42, 523);
            this.btnModificarAeronave.Name = "btnModificarAeronave";
            this.btnModificarAeronave.Size = new System.Drawing.Size(110, 43);
            this.btnModificarAeronave.TabIndex = 19;
            this.btnModificarAeronave.Text = "Modificar Aeronave";
            this.btnModificarAeronave.UseVisualStyleBackColor = true;
            this.btnModificarAeronave.Click += new System.EventHandler(this.btnModificarAeronave_Click);
            // 
            // btnBajaFueraServicio
            // 
            this.btnBajaFueraServicio.Enabled = false;
            this.btnBajaFueraServicio.Location = new System.Drawing.Point(445, 523);
            this.btnBajaFueraServicio.Name = "btnBajaFueraServicio";
            this.btnBajaFueraServicio.Size = new System.Drawing.Size(113, 43);
            this.btnBajaFueraServicio.TabIndex = 20;
            this.btnBajaFueraServicio.Text = "Dar de Baja Por Fuera de Servicio";
            this.btnBajaFueraServicio.UseVisualStyleBackColor = true;
            this.btnBajaFueraServicio.Click += new System.EventHandler(this.btnBajaFueraServicio_Click);
            // 
            // btnBajaVidaUtil
            // 
            this.btnBajaVidaUtil.Enabled = false;
            this.btnBajaVidaUtil.Location = new System.Drawing.Point(253, 523);
            this.btnBajaVidaUtil.Name = "btnBajaVidaUtil";
            this.btnBajaVidaUtil.Size = new System.Drawing.Size(110, 43);
            this.btnBajaVidaUtil.TabIndex = 21;
            this.btnBajaVidaUtil.Text = "Dar de Baja por Vida Útil";
            this.btnBajaVidaUtil.UseVisualStyleBackColor = true;
            this.btnBajaVidaUtil.Click += new System.EventHandler(this.btnBajaVidaUtil_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 539);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha de reincorporación:";
            // 
            // FormSeleccionAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBajaVidaUtil);
            this.Controls.Add(this.btnBajaFueraServicio);
            this.Controls.Add(this.btnModificarAeronave);
            this.Controls.Add(this.dataGridViewAeronave);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxEstadoAeronave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSeleccionAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Aeronave";
            this.Load += new System.EventHandler(this.FormSeleccionAeronave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoServicio)).EndInit();
            this.groupBoxEstadoAeronave.ResumeLayout(false);
            this.groupBoxEstadoAeronave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAeronave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCantidadButacas;
        private System.Windows.Forms.Label labelCantidadButacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCapacidadEncomiendas;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Label labelCapacidadEncomiendas;
        private System.Windows.Forms.GroupBox groupBoxEstadoAeronave;
        private System.Windows.Forms.CheckBox checkBoxBajaPorServicio;
        private System.Windows.Forms.CheckBox checkBoxPorVidaUtil;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dataGridViewAeronave;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxFabricante;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.BindingSource bindingSourceTipoServicio;
        private System.Windows.Forms.BindingSource bindingAeronaves;
        private System.Windows.Forms.Button btnModificarAeronave;
        private System.Windows.Forms.Button btnBajaFueraServicio;
        private System.Windows.Forms.Button btnBajaVidaUtil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}