namespace wOficinaEmpleo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oficinaDeEmpleosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloBuscarEmpleoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoFuncionaLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oficinaDeEmpleosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oficinaDeEmpleosToolStripMenuItem
            // 
            this.oficinaDeEmpleosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.móduloEmpleadoToolStripMenuItem,
            this.móduloBuscarEmpleoToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.cómoFuncionaLaAplicaciónToolStripMenuItem});
            this.oficinaDeEmpleosToolStripMenuItem.Name = "oficinaDeEmpleosToolStripMenuItem";
            this.oficinaDeEmpleosToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.oficinaDeEmpleosToolStripMenuItem.Text = "&Oficina de Empleos";
            // 
            // móduloEmpleadoToolStripMenuItem
            // 
            this.móduloEmpleadoToolStripMenuItem.Name = "móduloEmpleadoToolStripMenuItem";
            this.móduloEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.móduloEmpleadoToolStripMenuItem.Text = "&Módulo empleado";
            this.móduloEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.móduloEmpleadoToolStripMenuItem_Click);
            // 
            // móduloBuscarEmpleoToolStripMenuItem
            // 
            this.móduloBuscarEmpleoToolStripMenuItem.Name = "móduloBuscarEmpleoToolStripMenuItem";
            this.móduloBuscarEmpleoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.móduloBuscarEmpleoToolStripMenuItem.Text = "&Módulo buscar empleo";
            this.móduloBuscarEmpleoToolStripMenuItem.Click += new System.EventHandler(this.móduloBuscarEmpleoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cómoFuncionaLaAplicaciónToolStripMenuItem
            // 
            this.cómoFuncionaLaAplicaciónToolStripMenuItem.Name = "cómoFuncionaLaAplicaciónToolStripMenuItem";
            this.cómoFuncionaLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.cómoFuncionaLaAplicaciónToolStripMenuItem.Text = "¿&Cómo funciona la aplicación?";
            this.cómoFuncionaLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cómoFuncionaLaAplicaciónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Oficina de Empleos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oficinaDeEmpleosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem móduloEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem móduloBuscarEmpleoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cómoFuncionaLaAplicaciónToolStripMenuItem;
    }
}

