namespace wOficinaEmpleo
{
    partial class wEmpleados
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNivelEstudios = new System.Windows.Forms.Label();
            this.lblTituloAcademico = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTituloAcademico = new System.Windows.Forms.TextBox();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmbNivelEstudios = new System.Windows.Forms.ComboBox();
            this.btnBuscarPersonas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(69, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(69, 129);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Tipo de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Documento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(395, 34);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNivelEstudios
            // 
            this.lblNivelEstudios.AutoSize = true;
            this.lblNivelEstudios.Location = new System.Drawing.Point(395, 77);
            this.lblNivelEstudios.Name = "lblNivelEstudios";
            this.lblNivelEstudios.Size = new System.Drawing.Size(89, 13);
            this.lblNivelEstudios.TabIndex = 5;
            this.lblNivelEstudios.Text = "Nivel de Estudios";
            // 
            // lblTituloAcademico
            // 
            this.lblTituloAcademico.AutoSize = true;
            this.lblTituloAcademico.Location = new System.Drawing.Point(395, 129);
            this.lblTituloAcademico.Name = "lblTituloAcademico";
            this.lblTituloAcademico.Size = new System.Drawing.Size(89, 13);
            this.lblTituloAcademico.TabIndex = 6;
            this.lblTituloAcademico.Text = "Titulo Academico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(218, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(218, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Location = new System.Drawing.Point(218, 169);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(120, 20);
            this.txtNoDocumento.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(532, 31);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 11;
            // 
            // txtTituloAcademico
            // 
            this.txtTituloAcademico.Location = new System.Drawing.Point(532, 122);
            this.txtTituloAcademico.Name = "txtTituloAcademico";
            this.txtTituloAcademico.Size = new System.Drawing.Size(120, 20);
            this.txtTituloAcademico.TabIndex = 13;
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(12, 280);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(986, 199);
            this.dtgEmpleados.TabIndex = 14;
            this.dtgEmpleados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgEmpleados_MouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 208);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 55);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(235, 208);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(170, 55);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(432, 208);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 55);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(629, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 55);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar Fila";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(811, 62);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 55);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Pasaporte",
            "Cedula",
            "Permiso de Trabajo"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(218, 126);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocumento.TabIndex = 20;
            // 
            // cmbNivelEstudios
            // 
            this.cmbNivelEstudios.FormattingEnabled = true;
            this.cmbNivelEstudios.Items.AddRange(new object[] {
            "Pregrado",
            "Posgrado",
            "Tecnologia",
            "Tecnica"});
            this.cmbNivelEstudios.Location = new System.Drawing.Point(531, 77);
            this.cmbNivelEstudios.Name = "cmbNivelEstudios";
            this.cmbNivelEstudios.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelEstudios.TabIndex = 21;
            // 
            // btnBuscarPersonas
            // 
            this.btnBuscarPersonas.Location = new System.Drawing.Point(828, 208);
            this.btnBuscarPersonas.Name = "btnBuscarPersonas";
            this.btnBuscarPersonas.Size = new System.Drawing.Size(170, 55);
            this.btnBuscarPersonas.TabIndex = 22;
            this.btnBuscarPersonas.Text = "Consultar Datos Individuales";
            this.btnBuscarPersonas.UseVisualStyleBackColor = true;
            this.btnBuscarPersonas.Click += new System.EventHandler(this.btnBuscarPersonas_Click);
            // 
            // wEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 491);
            this.Controls.Add(this.btnBuscarPersonas);
            this.Controls.Add(this.cmbNivelEstudios);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.txtTituloAcademico);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTituloAcademico);
            this.Controls.Add(this.lblNivelEstudios);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "wEmpleados";
            this.Text = "wEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNivelEstudios;
        private System.Windows.Forms.Label lblTituloAcademico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtTituloAcademico;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.ComboBox cmbNivelEstudios;
        private System.Windows.Forms.Button btnBuscarPersonas;
    }
}