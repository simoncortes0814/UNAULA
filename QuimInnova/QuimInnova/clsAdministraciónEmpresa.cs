using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuimInnova
{
    class clsAdministraciónEmpresa
    {
        // Propiedades de la clase
        public int intRUT { get; set; }
        public string strNombreEmpresa { get; set; }
        public string strMarcaEmpresa { get; set; }
        public string strDireccionLaboratorio { get; set; }
        public string strProducto { get; set; }
        public string datFechaCreacion { get; set; }
        public int intPrecio { get; set; }
        public int intCodProducto { get; set; }

        // Constructor por defecto
        public clsAdministraciónEmpresa()
        {

        }
        // Constructor con parámetros
        public clsAdministraciónEmpresa(int intRUT, string strNombreEmpresa, string strMarcaEmpresa, string strDireccionLaboratorio, string strProducto, string datFechaCreacion, int intPrecio, int intCodigoProducto)
        {
            // Asignar los valores de los parámetros a las propiedades correspondientes
            this.intRUT = intRUT;
            this.strNombreEmpresa = strNombreEmpresa;
            this.strMarcaEmpresa = strMarcaEmpresa;
            this.strDireccionLaboratorio = strDireccionLaboratorio;
            this.strProducto = strProducto;
            this.datFechaCreacion = datFechaCreacion;
            this.intPrecio = intPrecio;
            this.intCodProducto = intCodigoProducto;
        }

        public bool IngresoProductos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();
            // Definir la instrucción SQL para insertar los datos en la tabla tblProducto
            string ingresoProductos = "INSERT INTO tblProducto VALUES (@intRUT, @strNombreEmpresa,  @strMarcaEmpresa, @strDireccionLaboratorio, @strProducto , @datFechaCreacion, @intPrecio , @intCodProducto)";
            // Crear un objeto SqlCommand con la instrucción SQL que sería insertar los datos y la conexión establecida
            SqlCommand sql = new SqlCommand(ingresoProductos, Conexion);
            // Ejecutar la instrucción SQL para insertar los datos en la tabla
            sql.Parameters.AddWithValue("@intRUT", this.intRUT);
            sql.Parameters.AddWithValue("@strNombreEmpresa", this.strNombreEmpresa);
            sql.Parameters.AddWithValue("@strMarcaEmpresa", this.strMarcaEmpresa);
            sql.Parameters.AddWithValue("@strDireccionLaboratorio", this.strDireccionLaboratorio);
            sql.Parameters.AddWithValue("@strProducto", this.strProducto);
            sql.Parameters.AddWithValue("@datFechaCreacion", this.datFechaCreacion);
            sql.Parameters.AddWithValue("@intPrecio", this.intPrecio);
            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            // Ejecutar la instrucción SQL para insertar los datos en la tabla
            sql.ExecuteNonQuery();
            // Retornar un valor booleano indicando que el ingreso de productos fue exitoso
            return true;

        }

        public DataTable consultarDatos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            conexion.Open();
            // Establecer la conexión a la base de datos
            DataTable dt = new DataTable();
            // Definir la consulta SQL para seleccionar todos los datos de la tabla tblProducto
            string consultarDatos = "SELECT * FROM tblProducto";
            // Crear un objeto SqlCommand con la instrucción SQL y la conexión establecida
            SqlCommand cmd = new SqlCommand(consultarDatos, conexion);
            // Definir la consulta SQL para seleccionar todos los datos de la tabla tblProducto
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // Retornar el DataTable con los datos consultados
            return dt;
        }

        public DataTable consultarProductos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            conexion.Open();
            // Establecer la conexión a la base de datos
            DataTable dt = new DataTable();
            // Definir la consulta SQL para seleccionar todos los datos de la tabla tblProducto
            string consultarProductos = "SELECT * FROM tblCompraProducto";
            // Crear un objeto SqlCommand con la instrucción SQL y la conexión establecida
            SqlCommand cmd = new SqlCommand(consultarProductos, conexion);
            // Definir la consulta SQL para seleccionar todos los datos de la tabla tblProducto
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // Retornar el DataTable con los datos consultados
            return dt;
        }
        public bool eliminarDatos(int intCodProducto)
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();
            // Asignar el valor del parámetro intCodProducto a la propiedad intCodProducto de la clase
            this.intCodProducto = intCodProducto;
            // Definir la instrucción SQL para eliminar los datos en la tabla tblProducto
            string eliminar = "DELETE tblProducto where intCodProducto = @intCodProducto";
            // Crear un objeto SqlCommand con la instrucción SQL que en este caso sería eliminar los datos y la conexión establecida
            SqlCommand sql = new SqlCommand(eliminar, Conexion);
            
            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            // Ejecutar la instrucción SQL para eliminar los datos en la tabla
            sql.ExecuteNonQuery();
            // Retornar un valor booleano indicando que la eliminación de datos fue exitosa
            return true;

        }

        public bool modificarDatos()
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();
            // Definir la instrucción SQL para modificar los datos en la tabla tblProducto
            string modificarDatos = "UPDATE tblProducto SET intRUT = @intRUT, strNombreEmpresa = @strNombreEmpresa, strMarcaEmpresa = @strMarcaEmpresa, strDireccionLaboratorio = @strDireccionLaboratorio, strProducto = @strProducto, datFechaCreacion = @datFechaCreacion, intPrecio = @intPrecio, intCodProducto = @intCodProducto WHERE intCodProducto = @intCodProducto";
            // Crear un objeto SqlCommand con la instrucción SQL y la conexión establecida
            SqlCommand sql = new SqlCommand(modificarDatos, Conexion);
            // Asignar los valores de las propiedades a los parámetros de la instrucción SQL
            sql.Parameters.AddWithValue("@intRUT", this.intRUT);
            sql.Parameters.AddWithValue("@strNombreEmpresa", this.strNombreEmpresa);
            sql.Parameters.AddWithValue("@strMarcaEmpresa", this.strMarcaEmpresa);
            sql.Parameters.AddWithValue("@strDireccionLaboratorio", this.strDireccionLaboratorio);
            sql.Parameters.AddWithValue("@strProducto", this.strProducto);
            sql.Parameters.AddWithValue("@datFechaCreacion", this.datFechaCreacion);
            sql.Parameters.AddWithValue("@intPrecio", this.intPrecio);
            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            // Asignar los valores de las propiedades a los parámetros de la instrucción SQL
            sql.ExecuteNonQuery();
            // Retornar un valor booleano indicando que la modificación de datos fue exitosa
            return true;
        }
    }
}
