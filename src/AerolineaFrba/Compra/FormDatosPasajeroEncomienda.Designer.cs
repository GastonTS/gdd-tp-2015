namespace AerolineaFrba.Compra
{
    partial class FormDatosPasajeroEncomienda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDNI = new AerolineaFrba.Abm.TextBoxDNI();
            this.btnIngresarDatosPasajero = new System.Windows.Forms.Button();
            this.labelDNI = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxButacaYEncomienda = new System.Windows.Forms.GroupBox();
            this.labelVentanilla = new System.Windows.Forms.Label();
            this.labelPasillo = new System.Windows.Forms.Label();
            this.listBoxEleccionButacaVentanilla = new System.Windows.Forms.ListBox();
            this.textBoxCantidadAEncomendar = new System.Windows.Forms.TextBox();
            this.labelEncomienda = new System.Windows.Forms.Label();
            this.labelButaca = new System.Windows.Forms.Label();
            this.listBoxEleccionButacaPasillo = new System.Windows.Forms.ListBox();
            this.btnAceptar = new AerolineaFrba.Abm.Guardar();
            this.groupBox1.SuspendLayout();
            this.groupBoxButacaYEncomienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.btnIngresarDatosPasajero);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pasajero";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.textBoxDNI.Enabled = false;
            this.textBoxDNI.ErrorText = null;
            this.textBoxDNI.Location = new System.Drawing.Point(54, 34);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(129, 22);
            this.textBoxDNI.TabIndex = 7;
            // 
            // btnIngresarDatosPasajero
            // 
            this.btnIngresarDatosPasajero.Location = new System.Drawing.Point(183, 30);
            this.btnIngresarDatosPasajero.Name = "btnIngresarDatosPasajero";
            this.btnIngresarDatosPasajero.Size = new System.Drawing.Size(167, 30);
            this.btnIngresarDatosPasajero.TabIndex = 1;
            this.btnIngresarDatosPasajero.Text = "Ingresar Datos del Pasajero";
            this.btnIngresarDatosPasajero.UseVisualStyleBackColor = true;
            this.btnIngresarDatosPasajero.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(12, 39);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 5;
            this.labelDNI.Text = "DNI";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 374);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 31);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxButacaYEncomienda
            // 
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelVentanilla);
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelPasillo);
            this.groupBoxButacaYEncomienda.Controls.Add(this.listBoxEleccionButacaVentanilla);
            this.groupBoxButacaYEncomienda.Controls.Add(this.textBoxCantidadAEncomendar);
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelEncomienda);
            this.groupBoxButacaYEncomienda.Controls.Add(this.labelButaca);
            this.groupBoxButacaYEncomienda.Controls.Add(this.listBoxEleccionButacaPasillo);
            this.groupBoxButacaYEncomienda.Location = new System.Drawing.Point(24, 116);
            this.groupBoxButacaYEncomienda.Name = "groupBoxButacaYEncomienda";
            this.groupBoxButacaYEncomienda.Size = new System.Drawing.Size(458, 232);
            this.groupBoxButacaYEncomienda.TabIndex = 17;
            this.groupBoxButacaYEncomienda.TabStop = false;
            this.groupBoxButacaYEncomienda.Text = "Datos de compra";
            // 
            // labelVentanilla
            // 
            this.labelVentanilla.AutoSize = true;
            this.labelVentanilla.Location = new System.Drawing.Point(250, 99);
            this.labelVentanilla.Name = "labelVentanilla";
            this.labelVentanilla.Size = new System.Drawing.Size(53, 13);
            this.labelVentanilla.TabIndex = 7;
            this.labelVentanilla.Text = "Ventanilla";
            // 
            // labelPasillo
            // 
            this.labelPasillo.AutoSize = true;
            this.labelPasillo.Location = new System.Drawing.Point(51, 99);
            this.labelPasillo.Name = "labelPasillo";
            this.labelPasillo.Size = new System.Drawing.Size(37, 13);
            this.labelPasillo.TabIndex = 6;
            this.labelPasillo.Text = "Pasillo";
            // 
            // listBoxEleccionButacaVentanilla
            // 
            this.listBoxEleccionButacaVentanilla.FormattingEnabled = true;
            this.listBoxEleccionButacaVentanilla.Location = new System.Drawing.Point(253, 118);
            this.listBoxEleccionButacaVentanilla.Name = "listBoxEleccionButacaVentanilla";
            this.listBoxEleccionButacaVentanilla.Size = new System.Drawing.Size(86, 95);
            this.listBoxEleccionButacaVentanilla.TabIndex = 5;
            this.listBoxEleccionButacaVentanilla.SelectedIndexChanged += new System.EventHandler(this.listBoxEleccionButacaVentanilla_SelectedIndexChanged);
            // 
            // textBoxCantidadAEncomendar
            // 
            this.textBoxCantidadAEncomendar.Location = new System.Drawing.Point(146, 33);
            this.textBoxCantidadAEncomendar.Name = "textBoxCantidadAEncomendar";
            this.textBoxCantidadAEncomendar.Size = new System.Drawing.Size(78, 20);
            this.textBoxCantidadAEncomendar.TabIndex = 0;
            this.textBoxCantidadAEncomendar.Visible = false;
            this.textBoxCantidadAEncomendar.TextChanged += new System.EventHandler(this.textBoxCantidadAEncomendar_TextChanged);
            // 
            // labelEncomienda
            // 
            this.labelEncomienda.AutoSize = true;
            this.labelEncomienda.Location = new System.Drawing.Point(17, 36);
            this.labelEncomienda.Name = "labelEncomienda";
            this.labelEncomienda.Size = new System.Drawing.Size(123, 13);
            this.labelEncomienda.TabIndex = 2;
            this.labelEncomienda.Text = "Cantidad a encomendar:";
            this.labelEncomienda.Visible = false;
            // 
            // labelButaca
            // 
            this.labelButaca.AutoSize = true;
            this.labelButaca.Location = new System.Drawing.Point(17, 71);
            this.labelButaca.Name = "labelButaca";
            this.labelButaca.Size = new System.Drawing.Size(152, 13);
            this.labelButaca.TabIndex = 1;
            this.labelButaca.Text = "N° de las Butacas Disponibles:";
            // 
            // listBoxEleccionButacaPasillo
            // 
            this.listBoxEleccionButacaPasillo.FormattingEnabled = true;
            this.listBoxEleccionButacaPasillo.Location = new System.Drawing.Point(54, 118);
            this.listBoxEleccionButacaPasillo.Name = "listBoxEleccionButacaPasillo";
            this.listBoxEleccionButacaPasillo.Size = new System.Drawing.Size(86, 95);
            this.listBoxEleccionButacaPasillo.TabIndex = 0;
            this.listBoxEleccionButacaPasillo.SelectedIndexChanged += new System.EventHandler(this.listBoxEleccionButacaPasillo_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(399, 374);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.TextBtn = "Aceptar";
            // 
            // FormDatosPasajeroEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 425);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxButacaYEncomienda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDatosPasajeroEncomienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese los datos de un Pasajero y/o Encomienda";
            this.Load += new System.EventHandler(this.FormDatosPasajeroEncomienda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxButacaYEncomienda.ResumeLayout(false);
            this.groupBoxButacaYEncomienda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxButacaYEncomienda;
        private System.Windows.Forms.TextBox textBoxCantidadAEncomendar;
        private System.Windows.Forms.Label labelEncomienda;
        private System.Windows.Forms.Label labelButaca;
        private System.Windows.Forms.ListBox listBoxEleccionButacaPasillo;
        private System.Windows.Forms.ListBox listBoxEleccionButacaVentanilla;
        private System.Windows.Forms.Label labelVentanilla;
        private System.Windows.Forms.Label labelPasillo;
        private System.Windows.Forms.Button btnIngresarDatosPasajero;
        private Abm.TextBoxDNI textBoxDNI;
        private Abm.Guardar btnAceptar;
    }
}