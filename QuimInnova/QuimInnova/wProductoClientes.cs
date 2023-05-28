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
    public partial class wProductoClientes : Form
    {
        

        public wProductoClientes()
        {
            InitializeComponent();
            
           
        }

        
        


        private void wProductoClientes_Load(object sender, EventArgs e)
        {
            //se instancia un objeto de la clase producto clientes que carga los diferentes datos de la columna producto en el combobox
            clsProductoClientes clsProductoClientes = new clsProductoClientes();
            cboProductos.DataSource = clsProductoClientes.cargarDatos();
            cboProductos.DisplayMember = "strProducto";
            

            
             

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                //Se hace conexión a la base de datos
                SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
                Conexion.Open();
                //Se instancia un objeto de la clase ProductoClientes y se le dirige la consulta agregado hacia al dtg
                clsProductoClientes Productos = new clsProductoClientes();
                //Se muestra los datos del precio y el producto en el datagridview
                dtgPrecio.DataSource = Productos.consultarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }

 

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            //Cierra esta ventana
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase clsProductoClientes y pasar los valores de los controles cboProductos, txtNombre, txtApellido y txtDirecicon como argumentos
                clsProductoClientes clsProductoClientes = new clsProductoClientes(cboProductos.Text, txtNombre.Text, txtApellido.Text, txtDirecicon.Text);

                // Llamar al método ingresoCompra en la instancia clsProductoClientes para realizar la compra
                clsProductoClientes.ingresoCompra();

                // Mostrar un mensaje de éxito después de realizar la compra
                MessageBox.Show("Compra realizada con éxito, su producto llegará a su hogar en un plazo de dos días hábiles.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtDirecicon.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       
    }
}
