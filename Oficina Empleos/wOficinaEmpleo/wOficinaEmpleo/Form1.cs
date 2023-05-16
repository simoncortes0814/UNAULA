using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace wOficinaEmpleo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form wEmpleados = this.ActiveMdiChild;
            if (wEmpleados != null)
            {
                wEmpleados.Close();
            }
        }

        private void móduloEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wEmpleados wEmpleados = new wEmpleados();
            wEmpleados.MdiParent = this;
            wEmpleados.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cómoFuncionaLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dentro de Módulo Empleado registraremos a los datos de aquellas personas las cuales deseen ingresar al sistema de la oficina de empleos.\nPara el Módulo Buscar Empleo se agregara un codigo el cual nos mostrara los datos del empleo proviniente del codigo ", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void móduloBuscarEmpleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wEmpleos wEmpleos = new wEmpleos();
            wEmpleos.MdiParent = this;
            wEmpleos.Show();
        }
    }
}
