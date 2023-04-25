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
namespace frmMenuPrincipal
{
    public partial class frmDatosAcademicos : Form
    {
        public frmDatosAcademicos()
        {
            InitializeComponent();



        }


        public void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            cmbMateria.Text = "";
            cmbVerificacion.Text = "";
            txtSemestre.Text = "";

        }

        public void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSemestre.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (cmbMateria.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (cmbVerificacion.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                { 
                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    foreach (string linea in txtSemestre.Lines)
                    {
                        wrtGuardar.WriteLine("Semestre que cursa: " + linea);
                    }
                    wrtGuardar.WriteLine("Materia a elegir " + cmbMateria.Text);
                    wrtGuardar.WriteLine("¿Esta activo o no activo? " + cmbVerificacion.Text);

                    wrtGuardar.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
        } 
    }
}
