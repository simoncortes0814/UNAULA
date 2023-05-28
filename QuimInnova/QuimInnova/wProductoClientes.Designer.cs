namespace QuimInnova
{
    partial class wProductoClientes
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
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDirecicon = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtgPrecio = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(93, 67);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(121, 21);
            this.cboProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(90, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 146);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDirecicon
            // 
            this.txtDirecicon.Location = new System.Drawing.Point(93, 185);
            this.txtDirecicon.Name = "txtDirecicon";
            this.txtDirecicon.Size = new System.Drawing.Size(100, 20);
            this.txtDirecicon.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(93, 169);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // dtgPrecio
            // 
            this.dtgPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrecio.Location = new System.Drawing.Point(275, 55);
            this.dtgPrecio.Name = "dtgPrecio";
            this.dtgPrecio.Size = new System.Drawing.Size(240, 150);
            this.dtgPrecio.TabIndex = 8;
         //   this.dtgPrecio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrecio_CellContentClick);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(275, 237);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(156, 79);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(534, 102);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(180, 41);
            this.btnPrecio.TabIndex = 10;
            this.btnPrecio.Text = "Precios de Productos";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Location = new System.Drawing.Point(711, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(14, 13);
            this.lblCerrar.TabIndex = 11;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click_1);
            // 
            // wProductoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dtgPrecio);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDirecicon);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProductos);
            this.Name = "wProductoClientes";
            this.Text = "wProductoClientes";
            this.Load += new System.EventHandler(this.wProductoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDirecicon;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DataGridView dtgPrecio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblCerrar;
    }
}