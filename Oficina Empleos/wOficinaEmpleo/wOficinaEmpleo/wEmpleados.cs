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
using System.Data.SqlClient;
using System.Configuration;

namespace wOficinaEmpleo
{
    public partial class wEmpleados : Form
    {
        public wEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                clsOficinaEmpleos oficinaEmpleos = new clsOficinaEmpleos(Convert.ToInt32(txtNoDocumento.Text), cmbTipoDocumento.Text, txtApellido.Text, txtNombre.Text, Convert.ToString(dtpFechaNacimiento.Text), cmbNivelEstudios.Text, txtTituloAcademico.Text);
                oficinaEmpleos.InsertarEmpleados();
                MessageBox.Show("Datos exitosamente ingresados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgEmpleados.DataSource = oficinaEmpleos.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                clsOficinaEmpleos oficinaEmpleos = new clsOficinaEmpleos();
                dtgEmpleados.DataSource = oficinaEmpleos.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnBuscarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                clsOficinaEmpleos oficinaEmpleos = new clsOficinaEmpleos();
                dtgEmpleados.DataSource = oficinaEmpleos.consultarDatosPersona(Convert.ToInt32(txtNoDocumento.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                clsOficinaEmpleos oficinaEmpleos = new clsOficinaEmpleos();
                dtgEmpleados.DataSource = oficinaEmpleos.eliminarDatos(Convert.ToInt32(txtNoDocumento.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                clsOficinaEmpleos oficinaEmpleos = new clsOficinaEmpleos(Convert.ToInt32(txtNoDocumento.Text), cmbTipoDocumento.Text, txtApellido.Text, txtNombre.Text, Convert.ToString(dtpFechaNacimiento.Text), cmbNivelEstudios.Text, txtTituloAcademico.Text);
                oficinaEmpleos.modificarDatosEmpleados();
                MessageBox.Show("Datos modificados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgEmpleados.DataSource = oficinaEmpleos.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dtgEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            txtNoDocumento.Text = dtgEmpleados.SelectedRows[0].Cells[0].Value.ToString();
            cmbTipoDocumento.Text = dtgEmpleados.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = dtgEmpleados.SelectedRows[0].Cells[2].Value.ToString();
            txtApellido.Text = dtgEmpleados.SelectedRows[0].Cells[3].Value.ToString();
            dtpFechaNacimiento.Text = dtgEmpleados.SelectedRows[0].Cells[4].Value.ToString();
            cmbNivelEstudios.Text = dtgEmpleados.SelectedRows[0].Cells[5].Value.ToString();
            txtTituloAcademico.Text = dtgEmpleados.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNoDocumento.Text = "";
            cmbTipoDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Text = "";
            cmbNivelEstudios.Text = "";
            txtTituloAcademico.Text = "";

        }
    }
}
