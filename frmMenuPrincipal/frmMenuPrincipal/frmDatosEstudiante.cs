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
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante()
        {
            InitializeComponent();
            
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TxtCC.Text = "";
            txtCiudad.Text = "";
            TxtName.Text = "";
            cmbSexo.Text = "";
            dateTimePicker1.Text = "";
        }

        

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (TxtCC.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (TxtName.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (txtCiudad.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (cmbSexo.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Por favor revise bien que todos los datos esten completados");
                }
                else if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    foreach (string linea in TxtName.Lines)
                    {
                        wrtGuardar.WriteLine("Nombre Completo: " + linea);
                    }
                    foreach (string linea in TxtCC.Lines)
                    {
                        wrtGuardar.WriteLine("Cedula: " + linea);
                    }
                    foreach (string linea in txtCiudad.Lines)
                    {
                        wrtGuardar.WriteLine("Ciudad de Residencia: " + linea);
                    }

                    wrtGuardar.WriteLine("Sexo: " + cmbSexo.Text);
                    wrtGuardar.WriteLine("Fecha de nacimiento: " + dateTimePicker1.Text);
                    
                    wrtGuardar.Close();
                    frmDatosAcademicos frmDatosAcademicos = new frmDatosAcademicos();
                    
                }
            }

            catch (Exception ex)
            {


                MessageBox.Show("" + ex);
            }
        }
    }
}
