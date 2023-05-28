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
using System.Data;
namespace QuimInnova
{
    public partial class wAdministradores : Form
    {

        
        public wAdministradores()
        {
            InitializeComponent();
        }

       

        private void wAdministradores_Load(object sender, EventArgs e)
        {
            //Hace que los diferentes txt que esten en true tengan un valor fijo y que no se puede modificar 
            txtRutEmpresa.ReadOnly = true;
            txtRutEmpresa.Text = "0403020100";
            txtNombreEmpresa.Text = "Quimica Innovadora";
            txtMarcaEmpresa.Text = "QuimInnova";
            txtDireccion.Text = "Carrera 20 # 40-60";
            txtNombreEmpresa.ReadOnly = true;
            txtMarcaEmpresa.ReadOnly = true;
            txtDireccion.ReadOnly = true;
        }

        private void dtgTblEmpresa_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (string.IsNullOrEmpty(txtProductos.Text) || string.IsNullOrEmpty(txtPrecioProducto.Text) || string.IsNullOrEmpty(txtCodProducto.Text))
                {
                    // Mostrar mensaje de error si algún campo obligatorio está vacío
                    MessageBox.Show("Por favor verifique que todos los campos estén rellenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Establecer la conexión a la base de datos
                    SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                    conexion.Open();

                    // Crear una instancia de la clase clsAdministraciónEmpresa con los valores proporcionados
                    clsAdministraciónEmpresa Administrador = new clsAdministraciónEmpresa(int.Parse(txtRutEmpresa.Text), txtNombreEmpresa.Text, txtMarcaEmpresa.Text, txtDireccion.Text, txtProductos.Text, dtpFechaCreacion.Text, int.Parse(txtPrecioProducto.Text), int.Parse(txtCodProducto.Text));

                    // Llamar al método IngresoProductos() en la instancia de clsAdministraciónEmpresa para ingresar todos los datos del producto
                    Administrador.IngresoProductos();

                    // Mostrar la consulta dentro del datagridview
                    dtgTblEmpresa.DataSource = Administrador.consultarDatos();

                    // Limpiar los campos de texto después de ingresar los datos del producto
                    txtProductos.Text = "";
                    txtPrecioProducto.Text = "";
                    txtCodProducto.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnConsultarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                Conexion.Open();

                // Crear una instancia de la clase clsAdministraciónEmpresa
                clsAdministraciónEmpresa clsAdministraciónEmpresa = new clsAdministraciónEmpresa();

                // Mostrar los datos consultados en el datagridview
                dtgTblEmpresa.DataSource = clsAdministraciónEmpresa.consultarDatos();
            }
            catch (Exception)
            {
                // Relanzar la excepción si ocurre algún error
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                Conexion.Open();

                // Crear una instancia de la clase clsAdministraciónEmpresa
                clsAdministraciónEmpresa clsAdministraciónEmpresa = new clsAdministraciónEmpresa();

                // Llamar al método eliminarDatos() en la instancia de clsAdministraciónEmpresa para eliminar los datos según el código del producto proporcionado
                dtgTblEmpresa.DataSource = clsAdministraciónEmpresa.eliminarDatos(int.Parse(txtCodProducto.Text));

                // Mostrar mensaje de éxito después de eliminar los datos
                MessageBox.Show("Datos eliminados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Relanzar la excepción si ocurre algún error
                throw;
            }

        }

        private void btnmodifcarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsAdministraciónEmpresa con los datos modificados
                clsAdministraciónEmpresa Administrador = new clsAdministraciónEmpresa(int.Parse(txtRutEmpresa.Text), txtNombreEmpresa.Text, txtMarcaEmpresa.Text, txtDireccion.Text, txtProductos.Text, dtpFechaCreacion.Text, int.Parse(txtPrecioProducto.Text), int.Parse(txtCodProducto.Text));

                // Llamar al método modificarDatos() en la instancia de Administrador para actualizar los datos
                Administrador.modificarDatos();

                // Actualizar el origen de datos del DataGridView dtgTblEmpresa
                dtgTblEmpresa.DataSource = Administrador.consultarDatos();

                // Limpiar los campos de entrada de texto
                txtProductos.Text = "";
                txtPrecioProducto.Text = "";
                txtCodProducto.Text = "";

                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos modificados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Relanzar la excepción si ocurre algún error
                throw;
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //Abre el formulario de inici y cierra este
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                Conexion.Open();

                // Crear una instancia de la clase clsAdministraciónEmpresa
                clsAdministraciónEmpresa clsAdministraciónEmpresa = new clsAdministraciónEmpresa();

                // Mostrar los datos de los pedidos en el datagridview
                dtgTblEmpresa.DataSource = clsAdministraciónEmpresa.consultarProductos();
            }
            catch (Exception)
            {
                // Relanzar la excepción si ocurre algún error
                throw;
            }
        }
    }
}
