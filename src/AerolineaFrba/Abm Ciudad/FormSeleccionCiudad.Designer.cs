namespace AerolineaFrba.Abm_Ciudad
{
    partial class FormSeleccionCiudad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.fKRutaAereidci3E1D39E1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.CiudadTableAdapter();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ruta_AereaTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Ruta_AereaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRutaAereidci3E1D39E1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ciudadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 172);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(500, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(388, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKRutaAereidci3E1D39E1BindingSource
            // 
            this.fKRutaAereidci3E1D39E1BindingSource.DataMember = "FK__Ruta_Aere__id_ci__3E1D39E1";
            this.fKRutaAereidci3E1D39E1BindingSource.DataSource = this.ciudadBindingSource;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.gD2C2015DataSet;
            // 
            // ciudadBindingSource2
            // 
            this.ciudadBindingSource2.DataMember = "Ciudad";
            this.ciudadBindingSource2.DataSource = this.gD2C2015DataSet;
            // 
            // ruta_AereaTableAdapter
            // 
            this.ruta_AereaTableAdapter.ClearBeforeFill = true;
            // 
            // FormSeleccionCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 371);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSeleccionCiudad";
            this.Text = "FormSeleccionCiudad";
            this.Load += new System.EventHandler(this.FormSeleccionCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRutaAereidci3E1D39E1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private GD2C2015DataSetTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private System.Windows.Forms.BindingSource ciudadBindingSource2;
        private System.Windows.Forms.BindingSource fKRutaAereidci3E1D39E1BindingSource;
        private GD2C2015DataSetTableAdapters.Ruta_AereaTableAdapter ruta_AereaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}