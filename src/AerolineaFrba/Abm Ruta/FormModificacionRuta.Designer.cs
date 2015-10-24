namespace AerolineaFrba.Abm_Ruta
{
    partial class FormModificacionRuta
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
            this.dataGridRuta = new System.Windows.Forms.DataGridView();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.servicioBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.destinoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.origenBinding = new System.Windows.Forms.BindingSource(this.components);
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.ciudadTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.CiudadTableAdapter();
            this.ruta_AereaTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.Ruta_AereaTableAdapter();
            this.idrutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudadorigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudaddestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciobaseporpesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciobaseporpasajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposervicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRuta
            // 
            this.dataGridRuta.AllowUserToAddRows = false;
            this.dataGridRuta.AllowUserToDeleteRows = false;
            this.dataGridRuta.AutoGenerateColumns = false;
            this.dataGridRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrutaDataGridViewTextBoxColumn,
            this.idciudadorigenDataGridViewTextBoxColumn,
            this.idciudaddestinoDataGridViewTextBoxColumn,
            this.preciobaseporpesoDataGridViewTextBoxColumn,
            this.preciobaseporpasajeDataGridViewTextBoxColumn,
            this.tiposervicioDataGridViewTextBoxColumn});
            this.dataGridRuta.DataSource = this.servicioBinding;
            this.dataGridRuta.Location = new System.Drawing.Point(25, 199);
            this.dataGridRuta.Name = "dataGridRuta";
            this.dataGridRuta.ReadOnly = true;
            this.dataGridRuta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRuta.Size = new System.Drawing.Size(566, 150);
            this.dataGridRuta.TabIndex = 0;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servicioBinding, "tipo_servicio", true));
            this.comboBoxTipoServicio.DataSource = this.servicioBinding;
            this.comboBoxTipoServicio.DisplayMember = "tipo_servicio";
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(136, 109);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipoServicio.TabIndex = 15;
            this.comboBoxTipoServicio.ValueMember = "tipo_servicio";
            this.comboBoxTipoServicio.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTipoServicio_SelectionChangeCommitted);
            // 
            // servicioBinding
            // 
            this.servicioBinding.DataMember = "Ruta_Aerea";
            this.servicioBinding.DataSource = this.gD2C2015DataSet;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(22, 112);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 14;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.destinoBinding, "id_ciudad", true));
            this.comboBoxDestino.DataSource = this.destinoBinding;
            this.comboBoxDestino.DisplayMember = "nombre";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(136, 68);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 13;
            this.comboBoxDestino.ValueMember = "id_ciudad";
            // 
            // destinoBinding
            // 
            this.destinoBinding.DataMember = "Ciudad";
            this.destinoBinding.DataSource = this.gD2C2015DataSet;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.origenBinding, "id_ciudad", true));
            this.comboBoxOrigen.DataSource = this.origenBinding;
            this.comboBoxOrigen.DisplayMember = "nombre";
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(136, 29);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 11;
            this.comboBoxOrigen.ValueMember = "id_ciudad";
            // 
            // origenBinding
            // 
            this.origenBinding.DataMember = "Ciudad";
            this.origenBinding.DataSource = this.gD2C2015DataSet;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(22, 71);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(100, 13);
            this.labelDestino.TabIndex = 12;
            this.labelDestino.Text = "Seleccione destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(22, 32);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(95, 13);
            this.labelOrigen.TabIndex = 10;
            this.labelOrigen.Text = "Seleccione origen:";
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // ruta_AereaTableAdapter
            // 
            this.ruta_AereaTableAdapter.ClearBeforeFill = true;
            // 
            // idrutaDataGridViewTextBoxColumn
            // 
            this.idrutaDataGridViewTextBoxColumn.DataPropertyName = "id_ruta";
            this.idrutaDataGridViewTextBoxColumn.HeaderText = "id_ruta";
            this.idrutaDataGridViewTextBoxColumn.Name = "idrutaDataGridViewTextBoxColumn";
            this.idrutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idciudadorigenDataGridViewTextBoxColumn
            // 
            this.idciudadorigenDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad_origen";
            this.idciudadorigenDataGridViewTextBoxColumn.HeaderText = "id_ciudad_origen";
            this.idciudadorigenDataGridViewTextBoxColumn.Name = "idciudadorigenDataGridViewTextBoxColumn";
            this.idciudadorigenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idciudaddestinoDataGridViewTextBoxColumn
            // 
            this.idciudaddestinoDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad_destino";
            this.idciudaddestinoDataGridViewTextBoxColumn.HeaderText = "id_ciudad_destino";
            this.idciudaddestinoDataGridViewTextBoxColumn.Name = "idciudaddestinoDataGridViewTextBoxColumn";
            this.idciudaddestinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciobaseporpesoDataGridViewTextBoxColumn
            // 
            this.preciobaseporpesoDataGridViewTextBoxColumn.DataPropertyName = "precio_base_por_peso";
            this.preciobaseporpesoDataGridViewTextBoxColumn.HeaderText = "precio_base_por_peso";
            this.preciobaseporpesoDataGridViewTextBoxColumn.Name = "preciobaseporpesoDataGridViewTextBoxColumn";
            this.preciobaseporpesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciobaseporpasajeDataGridViewTextBoxColumn
            // 
            this.preciobaseporpasajeDataGridViewTextBoxColumn.DataPropertyName = "precio_base_por_pasaje";
            this.preciobaseporpasajeDataGridViewTextBoxColumn.HeaderText = "precio_base_por_pasaje";
            this.preciobaseporpasajeDataGridViewTextBoxColumn.Name = "preciobaseporpasajeDataGridViewTextBoxColumn";
            this.preciobaseporpasajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiposervicioDataGridViewTextBoxColumn
            // 
            this.tiposervicioDataGridViewTextBoxColumn.DataPropertyName = "tipo_servicio";
            this.tiposervicioDataGridViewTextBoxColumn.HeaderText = "tipo_servicio";
            this.tiposervicioDataGridViewTextBoxColumn.Name = "tiposervicioDataGridViewTextBoxColumn";
            this.tiposervicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormModificacionRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 380);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.labelTipoServicio);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.dataGridRuta);
            this.Name = "FormModificacionRuta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormModificacionRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRuta;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource origenBinding;
        private GD2C2015DataSetTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.BindingSource destinoBinding;
        private System.Windows.Forms.BindingSource servicioBinding;
        private GD2C2015DataSetTableAdapters.Ruta_AereaTableAdapter ruta_AereaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudaddestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciobaseporpesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciobaseporpasajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposervicioDataGridViewTextBoxColumn;
    }
}