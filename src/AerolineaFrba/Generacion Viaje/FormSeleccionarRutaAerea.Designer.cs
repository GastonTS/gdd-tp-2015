namespace AerolineaFrba.Generacion_Viaje
{
    partial class FormSeleccionarRutaAerea
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
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.tipoServicioBinding = new System.Windows.Forms.BindingSource(this.components);
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.origenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutaAereaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaAereaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.DataSource = this.tipoServicioBinding;
            this.comboBoxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(475, 25);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipoServicio.TabIndex = 21;
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(361, 28);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(87, 13);
            this.labelTipoServicio.TabIndex = 20;
            this.labelTipoServicio.Text = "Tipo de Servicio:";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.destinoBindingSource;
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(187, 64);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDestino.TabIndex = 19;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.origenBindingSource;
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(187, 25);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOrigen.TabIndex = 17;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(73, 67);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(100, 13);
            this.labelDestino.TabIndex = 18;
            this.labelDestino.Text = "Seleccione destino:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(73, 28);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(95, 13);
            this.labelOrigen.TabIndex = 16;
            this.labelOrigen.Text = "Seleccione origen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.rutaAereaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(686, 188);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(595, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(539, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormSeleccionarRutaAerea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.labelTipoServicio);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Name = "FormSeleccionarRutaAerea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeleccionarRutaAerea";
            this.Load += new System.EventHandler(this.FormSeleccionarRutaAerea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaAereaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.BindingSource tipoServicioBinding;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.BindingSource destinoBindingSource;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.BindingSource origenBindingSource;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource rutaAereaBindingSource;
    }
}