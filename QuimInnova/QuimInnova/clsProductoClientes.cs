using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuimInnova
{
    class clsProductoClientes
    {
        public string strProducto { get; set; }
        public string strNombreCliente { get; set; }
        public string strApellido { get; set; }
        public string strDireccion { get; set; }

        public clsProductoClientes()
        {

        }
        public clsProductoClientes(string strProducto, string strNombreCliente, string strApellido, string strDireccion)
        {
            this.strProducto = strProducto;
            this.strNombreCliente = strNombreCliente;
            this.strApellido = strApellido;
            this.strDireccion = strDireccion;
        }

        public bool ingresoCompra()
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();

            // Definir la instrucción SQL para ingresar una compra en la tabla tblCompraProducto
            string ingresoCompra = "INSERT INTO tblCompraProducto VALUES (@strProducto, @strNombreCliente, @strApellido, @strDireccion)";

            // Crear un objeto SqlCommand con la instrucción SQL y la conexión establecida
            SqlCommand sql = new SqlCommand(ingresoCompra, Conexion);

            // Asignar los valores a los parámetros de la instrucción SQL
            sql.Parameters.AddWithValue("@strProducto", this.strProducto);
            sql.Parameters.AddWithValue("@strNombreCliente", this.strNombreCliente);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);

            // Ejecutar la instrucción SQL para ingresar los datos de compra en la tabla
            sql.ExecuteNonQuery();

            // Retornar un valor booleano indicando que el ingreso de la compra fue exitoso
            return true;
        }

        public DataTable cargarDatos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();

            // Crear un objeto SqlDataAdapter para cargar los productos desde la base de datos
            SqlDataAdapter da = new SqlDataAdapter("cargarProducto", Conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Crear un objeto DataTable para almacenar los datos de los productos
            DataTable dt = new DataTable();

            // Llenar el DataTable con los datos obtenidos de la base de datos
            da.Fill(dt);

            // Retornar el DataTable con los productos cargados desde la base de datos
            return dt;
        }

        public DataTable consultarDatos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            conexion.Open();

            // Crear un objeto DataTable para almacenar los datos consultados
            DataTable dt = new DataTable();

            // Definir la consulta SQL para obtener los datos de los productos (solo se seleccionan las columnas strProducto e intPrecio)
            string consultarDatos = "SELECT strProducto, intPrecio FROM tblProducto";

            // Crear un objeto SqlCommand con la consulta SQL y la conexión establecida
            SqlCommand cmd = new SqlCommand(consultarDatos, conexion);

            // Crear un objeto SqlDataAdapter y asociarlo al SqlCommand
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llenar el DataTable con los datos obtenidos de la base de datos utilizando el SqlDataAdapter
            da.Fill(dt);

            // Retornar el DataTable con los datos consultados (columnas strProducto e intPrecio)
            return dt;
        }
    }
}
