namespace wOficinaEmpleo
{
    partial class wEmpleos
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
            this.dtgEmpleos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodiog = new System.Windows.Forms.Label();
            this.btnBuscarEmpleo = new System.Windows.Forms.Button();
            this.btnConsultarEmpleos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmpleos
            // 
            this.dtgEmpleos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleos.Location = new System.Drawing.Point(41, 106);
            this.dtgEmpleos.Name = "dtgEmpleos";
            this.dtgEmpleos.Size = new System.Drawing.Size(713, 150);
            this.dtgEmpleos.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodiog
            // 
            this.lblCodiog.AutoSize = true;
            this.lblCodiog.Location = new System.Drawing.Point(22, 51);
            this.lblCodiog.Name = "lblCodiog";
            this.lblCodiog.Size = new System.Drawing.Size(80, 13);
            this.lblCodiog.TabIndex = 2;
            this.lblCodiog.Text = "Agregar Codigo";
            // 
            // btnBuscarEmpleo
            // 
            this.btnBuscarEmpleo.Location = new System.Drawing.Point(253, 33);
            this.btnBuscarEmpleo.Name = "btnBuscarEmpleo";
            this.btnBuscarEmpleo.Size = new System.Drawing.Size(138, 48);
            this.btnBuscarEmpleo.TabIndex = 3;
            this.btnBuscarEmpleo.Text = "Buscar Empleo";
            this.btnBuscarEmpleo.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleo.Click += new System.EventHandler(this.btnBuscarEmpleo_Click);
            // 
            // btnConsultarEmpleos
            // 
            this.btnConsultarEmpleos.Location = new System.Drawing.Point(455, 33);
            this.btnConsultarEmpleos.Name = "btnConsultarEmpleos";
            this.btnConsultarEmpleos.Size = new System.Drawing.Size(138, 48);
            this.btnConsultarEmpleos.TabIndex = 4;
            this.btnConsultarEmpleos.Text = "Consultar Empleos";
            this.btnConsultarEmpleos.UseVisualStyleBackColor = true;
            this.btnConsultarEmpleos.Click += new System.EventHandler(this.btnConsultarEmpleos_Click);
            // 
            // wEmpleos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.btnConsultarEmpleos);
            this.Controls.Add(this.btnBuscarEmpleo);
            this.Controls.Add(this.lblCodiog);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dtgEmpleos);
            this.Name = "wEmpleos";
            this.Text = "wEmpleos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmpleos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodiog;
        private System.Windows.Forms.Button btnBuscarEmpleo;
        private System.Windows.Forms.Button btnConsultarEmpleos;
    }
}