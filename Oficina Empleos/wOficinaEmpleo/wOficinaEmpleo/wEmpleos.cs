using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;        
namespace wOficinaEmpleo
{
    public partial class wEmpleos : Form
    {
        public wEmpleos()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();
                //instanciamos un objeto de la clase clsEmpleos
                clsEmpleos empleos = new clsEmpleos();
                dtgEmpleos.DataSource = empleos.seleccionarDato(Convert.ToInt32(txtCodigo.Text));

                if (Convert.ToInt32(txtCodigo.Text) > 6)
                {
                    MessageBox.Show("Recuerde por favor que la cantidad de empleos disponibles por el momento es de 6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnConsultarEmpleos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();
                clsEmpleos empleos = new clsEmpleos();
                dtgEmpleos.DataSource = empleos.consultarEmpleos();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
