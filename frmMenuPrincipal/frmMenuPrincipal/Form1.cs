using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datosEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante frmDatosEstudiante= new frmDatosEstudiante();
            frmDatosEstudiante.MdiParent = this;
            frmDatosEstudiante.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDatosEstudiante = this.ActiveMdiChild;
            if (frmDatosEstudiante != null)
            {
                frmDatosEstudiante.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAcademicos frmDatosAca = new frmDatosAcademicos();
            frmDatosAca.MdiParent = this;
            frmDatosAca.Show();
        }
    }
}

