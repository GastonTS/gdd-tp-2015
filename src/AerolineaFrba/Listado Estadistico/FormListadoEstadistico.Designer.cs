namespace AerolineaFrba.Listado_Estadistico
{
    partial class FormListadoEstadistico
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewListado = new System.Windows.Forms.DataGridView();
            this.radioBtnSegundoSemestre = new System.Windows.Forms.RadioButton();
            this.radioBtnPrimerSemestre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceListado = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAño);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridViewListado);
            this.groupBox1.Controls.Add(this.radioBtnSegundoSemestre);
            this.groupBox1.Controls.Add(this.radioBtnPrimerSemestre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxListado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top 5 Estadisticos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewListado
            // 
            this.dataGridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListado.Location = new System.Drawing.Point(25, 175);
            this.dataGridViewListado.Name = "dataGridViewListado";
            this.dataGridViewListado.Size = new System.Drawing.Size(527, 172);
            this.dataGridViewListado.TabIndex = 8;
            // 
            // radioBtnSegundoSemestre
            // 
            this.radioBtnSegundoSemestre.AutoSize = true;
            this.radioBtnSegundoSemestre.Location = new System.Drawing.Point(188, 144);
            this.radioBtnSegundoSemestre.Name = "radioBtnSegundoSemestre";
            this.radioBtnSegundoSemestre.Size = new System.Drawing.Size(68, 17);
            this.radioBtnSegundoSemestre.TabIndex = 7;
            this.radioBtnSegundoSemestre.Text = "Segundo";
            this.radioBtnSegundoSemestre.UseVisualStyleBackColor = true;
            // 
            // radioBtnPrimerSemestre
            // 
            this.radioBtnPrimerSemestre.AutoSize = true;
            this.radioBtnPrimerSemestre.Checked = true;
            this.radioBtnPrimerSemestre.Location = new System.Drawing.Point(122, 144);
            this.radioBtnPrimerSemestre.Name = "radioBtnPrimerSemestre";
            this.radioBtnPrimerSemestre.Size = new System.Drawing.Size(60, 17);
            this.radioBtnPrimerSemestre.TabIndex = 6;
            this.radioBtnPrimerSemestre.TabStop = true;
            this.radioBtnPrimerSemestre.Text = "Primero";
            this.radioBtnPrimerSemestre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo Listado";
            // 
            // comboBoxListado
            // 
            this.comboBoxListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListado.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxListado.Items.AddRange(new object[] {
            "Aeronaves con mayor cantidad de días fuera de servicio.",
            "Destinos con más pasajes comprados.",
            "Destinos con más aeronaves vacías.",
            "Destinos con más pasajes cancelados.",
            "Clientes con más puntos acumulados."});
            this.comboBoxListado.Location = new System.Drawing.Point(119, 59);
            this.comboBoxListado.Name = "comboBoxListado";
            this.comboBoxListado.Size = new System.Drawing.Size(433, 21);
            this.comboBoxListado.TabIndex = 3;
            this.comboBoxListado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(119, 101);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAño.TabIndex = 10;
            // 
            // FormListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 505);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListadoEstadistico";
            this.Text = "Listado Estadistico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnSegundoSemestre;
        private System.Windows.Forms.RadioButton radioBtnPrimerSemestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSourceListado;
        private System.Windows.Forms.ComboBox comboBoxAño;
    }
}