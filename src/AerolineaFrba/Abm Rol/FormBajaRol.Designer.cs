namespace AerolineaFrba.Abm_Rol
{
    partial class FormBajaRol
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Inhabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelFuncionalidad = new System.Windows.Forms.Label();
            this.comboBoxFuncionalidad = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inhabilitar});
            this.dataGridView.Location = new System.Drawing.Point(12, 172);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(455, 167);
            this.dataGridView.TabIndex = 0;
            // 
            // Inhabilitar
            // 
            this.Inhabilitar.HeaderText = "Inhabilitar";
            this.Inhabilitar.Name = "Inhabilitar";
            this.Inhabilitar.ReadOnly = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(32, 35);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(85, 32);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelFuncionalidad
            // 
            this.labelFuncionalidad.AutoSize = true;
            this.labelFuncionalidad.Location = new System.Drawing.Point(3, 73);
            this.labelFuncionalidad.Name = "labelFuncionalidad";
            this.labelFuncionalidad.Size = new System.Drawing.Size(76, 13);
            this.labelFuncionalidad.TabIndex = 3;
            this.labelFuncionalidad.Text = "Funcionalidad:";
            // 
            // comboBoxFuncionalidad
            // 
            this.comboBoxFuncionalidad.FormattingEnabled = true;
            this.comboBoxFuncionalidad.Location = new System.Drawing.Point(85, 70);
            this.comboBoxFuncionalidad.Name = "comboBoxFuncionalidad";
            this.comboBoxFuncionalidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuncionalidad.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(47, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(343, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.textBoxNombre);
            this.groupBoxFiltros.Controls.Add(this.labelNombre);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFuncionalidad);
            this.groupBoxFiltros.Controls.Add(this.labelFuncionalidad);
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(455, 111);
            this.groupBoxFiltros.TabIndex = 7;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de Búsqueda";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // FormBajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 351);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxFiltros);
            this.Name = "FormBajaRol";
            this.Text = "Baja Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Inhabilitar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelFuncionalidad;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
    }
}