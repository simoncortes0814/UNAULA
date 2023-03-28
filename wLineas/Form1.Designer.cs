namespace wLineas
{
    partial class frmtrazodelinea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxinicial = new System.Windows.Forms.TextBox();
            this.txtxfinal = new System.Windows.Forms.TextBox();
            this.txtyinicial = new System.Windows.Forms.TextBox();
            this.txtyfinal = new System.Windows.Forms.TextBox();
            this.btndibujolinea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantLineas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y Final";
            // 
            // txtxinicial
            // 
            this.txtxinicial.Location = new System.Drawing.Point(165, 30);
            this.txtxinicial.Name = "txtxinicial";
            this.txtxinicial.Size = new System.Drawing.Size(56, 20);
            this.txtxinicial.TabIndex = 4;
            // 
            // txtxfinal
            // 
            this.txtxfinal.Location = new System.Drawing.Point(348, 30);
            this.txtxfinal.Name = "txtxfinal";
            this.txtxfinal.Size = new System.Drawing.Size(56, 20);
            this.txtxfinal.TabIndex = 5;
            // 
            // txtyinicial
            // 
            this.txtyinicial.Location = new System.Drawing.Point(165, 88);
            this.txtyinicial.Name = "txtyinicial";
            this.txtyinicial.Size = new System.Drawing.Size(56, 20);
            this.txtyinicial.TabIndex = 6;
            // 
            // txtyfinal
            // 
            this.txtyfinal.Location = new System.Drawing.Point(348, 91);
            this.txtyfinal.Name = "txtyfinal";
            this.txtyfinal.Size = new System.Drawing.Size(56, 20);
            this.txtyfinal.TabIndex = 7;
            // 
            // btndibujolinea
            // 
            this.btndibujolinea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndibujolinea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndibujolinea.Location = new System.Drawing.Point(165, 147);
            this.btndibujolinea.Name = "btndibujolinea";
            this.btndibujolinea.Size = new System.Drawing.Size(114, 23);
            this.btndibujolinea.TabIndex = 8;
            this.btndibujolinea.Text = "Dibujar Linea";
            this.btndibujolinea.UseVisualStyleBackColor = false;
            this.btndibujolinea.Click += new System.EventHandler(this.btndibujolinea_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad de Lineas";
            // 
            // txtCantLineas
            // 
            this.txtCantLineas.Location = new System.Drawing.Point(429, 243);
            this.txtCantLineas.Name = "txtCantLineas";
            this.txtCantLineas.Size = new System.Drawing.Size(56, 20);
            this.txtCantLineas.TabIndex = 10;
            // 
            // frmtrazodelinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 293);
            this.Controls.Add(this.txtCantLineas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndibujolinea);
            this.Controls.Add(this.txtyfinal);
            this.Controls.Add(this.txtyinicial);
            this.Controls.Add(this.txtxfinal);
            this.Controls.Add(this.txtxinicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtrazodelinea";
            this.Text = "Trazo de una Linea";
            this.Load += new System.EventHandler(this.frmtrazodelinea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxinicial;
        private System.Windows.Forms.TextBox txtxfinal;
        private System.Windows.Forms.TextBox txtyinicial;
        private System.Windows.Forms.TextBox txtyfinal;
        private System.Windows.Forms.Button btndibujolinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantLineas;
    }
}

