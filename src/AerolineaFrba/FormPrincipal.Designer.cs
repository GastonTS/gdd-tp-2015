namespace AerolineaFrba
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaModifAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaModifRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaModifRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeLlegadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPasajeEncomiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMAeronaveToolStripMenuItem,
            this.aBMRolToolStripMenuItem,
            this.aBMRutaToolStripMenuItem,
            this.comprarViajeToolStripMenuItem,
            this.millasToolStripMenuItem,
            this.generarViajeToolStripMenuItem,
            this.registroDeLlegadaToolStripMenuItem,
            this.devoluciónToolStripMenuItem,
            this.bajaPasajeEncomiendaToolStripMenuItem,
            this.listadoEstadísticoToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMAeronaveToolStripMenuItem
            // 
            this.aBMAeronaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAeronaveToolStripMenuItem,
            this.bajaModifAeronaveToolStripMenuItem});
            this.aBMAeronaveToolStripMenuItem.Name = "aBMAeronaveToolStripMenuItem";
            this.aBMAeronaveToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.aBMAeronaveToolStripMenuItem.Text = "ABM Aeronave";
            // 
            // altaAeronaveToolStripMenuItem
            // 
            this.altaAeronaveToolStripMenuItem.Name = "altaAeronaveToolStripMenuItem";
            this.altaAeronaveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.altaAeronaveToolStripMenuItem.Text = "Alta";
            this.altaAeronaveToolStripMenuItem.Click += new System.EventHandler(this.altaAeronaveToolStripMenuItem_Click);
            // 
            // bajaModifAeronaveToolStripMenuItem
            // 
            this.bajaModifAeronaveToolStripMenuItem.Name = "bajaModifAeronaveToolStripMenuItem";
            this.bajaModifAeronaveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bajaModifAeronaveToolStripMenuItem.Text = "Modificación y Baja";
            this.bajaModifAeronaveToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // aBMRolToolStripMenuItem
            // 
            this.aBMRolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRolToolStripMenuItem,
            this.BajaModifRolToolStripMenuItem});
            this.aBMRolToolStripMenuItem.Name = "aBMRolToolStripMenuItem";
            this.aBMRolToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aBMRolToolStripMenuItem.Text = "ABM Rol";
            // 
            // altaRolToolStripMenuItem
            // 
            this.altaRolToolStripMenuItem.Name = "altaRolToolStripMenuItem";
            this.altaRolToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.altaRolToolStripMenuItem.Text = "Alta";
            this.altaRolToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // BajaModifRolToolStripMenuItem
            // 
            this.BajaModifRolToolStripMenuItem.Name = "BajaModifRolToolStripMenuItem";
            this.BajaModifRolToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.BajaModifRolToolStripMenuItem.Text = "Modificación y Baja";
            this.BajaModifRolToolStripMenuItem.Click += new System.EventHandler(this.modificaciónToolStripMenuItem_Click);
            // 
            // aBMRutaToolStripMenuItem
            // 
            this.aBMRutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRutaToolStripMenuItem,
            this.BajaModifRutaToolStripMenuItem});
            this.aBMRutaToolStripMenuItem.Name = "aBMRutaToolStripMenuItem";
            this.aBMRutaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aBMRutaToolStripMenuItem.Text = "ABM Ruta";
            // 
            // altaRutaToolStripMenuItem
            // 
            this.altaRutaToolStripMenuItem.Name = "altaRutaToolStripMenuItem";
            this.altaRutaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.altaRutaToolStripMenuItem.Text = "Alta";
            this.altaRutaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // BajaModifRutaToolStripMenuItem
            // 
            this.BajaModifRutaToolStripMenuItem.Name = "BajaModifRutaToolStripMenuItem";
            this.BajaModifRutaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.BajaModifRutaToolStripMenuItem.Text = "Modificación y Baja";
            this.BajaModifRutaToolStripMenuItem.Click += new System.EventHandler(this.modificaciónYBajaToolStripMenuItem_Click);
            // 
            // comprarViajeToolStripMenuItem
            // 
            this.comprarViajeToolStripMenuItem.Name = "comprarViajeToolStripMenuItem";
            this.comprarViajeToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.comprarViajeToolStripMenuItem.Text = "Comprar Viaje";
            this.comprarViajeToolStripMenuItem.Click += new System.EventHandler(this.comprarViajeToolStripMenuItem_Click);
            // 
            // millasToolStripMenuItem
            // 
            this.millasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMillasToolStripMenuItem,
            this.canjeToolStripMenuItem});
            this.millasToolStripMenuItem.Name = "millasToolStripMenuItem";
            this.millasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.millasToolStripMenuItem.Text = "Millas";
            // 
            // consultaMillasToolStripMenuItem
            // 
            this.consultaMillasToolStripMenuItem.Name = "consultaMillasToolStripMenuItem";
            this.consultaMillasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaMillasToolStripMenuItem.Text = "Consulta";
            this.consultaMillasToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // canjeToolStripMenuItem
            // 
            this.canjeToolStripMenuItem.Name = "canjeToolStripMenuItem";
            this.canjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.canjeToolStripMenuItem.Text = "Canje";
            this.canjeToolStripMenuItem.Click += new System.EventHandler(this.canjeToolStripMenuItem_Click);
            // 
            // generarViajeToolStripMenuItem
            // 
            this.generarViajeToolStripMenuItem.Name = "generarViajeToolStripMenuItem";
            this.generarViajeToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.generarViajeToolStripMenuItem.Text = "Generar Viaje";
            this.generarViajeToolStripMenuItem.Click += new System.EventHandler(this.generarViajeToolStripMenuItem_Click);
            // 
            // registroDeLlegadaToolStripMenuItem
            // 
            this.registroDeLlegadaToolStripMenuItem.Name = "registroDeLlegadaToolStripMenuItem";
            this.registroDeLlegadaToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.registroDeLlegadaToolStripMenuItem.Text = "Registro de Llegada";
            this.registroDeLlegadaToolStripMenuItem.Click += new System.EventHandler(this.registroDeLlegadaToolStripMenuItem_Click);
            // 
            // devoluciónToolStripMenuItem
            // 
            this.devoluciónToolStripMenuItem.Name = "devoluciónToolStripMenuItem";
            this.devoluciónToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.devoluciónToolStripMenuItem.Text = "Devolución";
            this.devoluciónToolStripMenuItem.Click += new System.EventHandler(this.devoluciónToolStripMenuItem_Click);
            // 
            // bajaPasajeEncomiendaToolStripMenuItem
            // 
            this.bajaPasajeEncomiendaToolStripMenuItem.Name = "bajaPasajeEncomiendaToolStripMenuItem";
            this.bajaPasajeEncomiendaToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.bajaPasajeEncomiendaToolStripMenuItem.Text = "Baja Pasaje/Encomienda";
            this.bajaPasajeEncomiendaToolStripMenuItem.Click += new System.EventHandler(this.bajaPasajeEncomiendaToolStripMenuItem_Click);
            // 
            // listadoEstadísticoToolStripMenuItem
            // 
            this.listadoEstadísticoToolStripMenuItem.Name = "listadoEstadísticoToolStripMenuItem";
            this.listadoEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadísticoToolStripMenuItem.Text = "Listado Estadístico";
            this.listadoEstadísticoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstadísticoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 536);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaModifAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BajaModifRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BajaModifRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeLlegadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaPasajeEncomiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadísticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

