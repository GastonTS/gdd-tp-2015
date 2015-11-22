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
            this.dataGridViewCiudades = new System.Windows.Forms.DataGridView();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnaModificación = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCiudades
            // 
            this.dataGridViewCiudades.AllowUserToAddRows = false;
            this.dataGridViewCiudades.AllowUserToDeleteRows = false;
            this.dataGridViewCiudades.AllowUserToOrderColumns = true;
            this.dataGridViewCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaModificación});
            this.dataGridViewCiudades.Location = new System.Drawing.Point(30, 62);
            this.dataGridViewCiudades.MaximumSize = new System.Drawing.Size(500, 500);
            this.dataGridViewCiudades.Name = "dataGridViewCiudades";
            this.dataGridViewCiudades.ReadOnly = true;
            this.dataGridViewCiudades.Size = new System.Drawing.Size(492, 239);
            this.dataGridViewCiudades.TabIndex = 0;
            this.dataGridViewCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Ciudades cargas en el Sistema:";
            // 
            // ColumnaModificación
            // 
            this.ColumnaModificación.HeaderText = "Seleccione Ciudad a Modificar";
            this.ColumnaModificación.Name = "ColumnaModificación";
            this.ColumnaModificación.ReadOnly = true;
            this.ColumnaModificación.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnaModificación.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormSeleccionCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCiudades);
            this.Name = "FormSeleccionCiudad";
            this.Text = "Ciudades habilitadas para Rutas Aéreas";
            this.Load += new System.EventHandler(this.FormSeleccionCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCiudades;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaModificación;
    }
}