using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuimInnova
{
    class clsRegistros
    {
        // Propiedades de la clase
        public int intCedulaUsuario { get; set; }
        public string strTipoDocumento { get; set; }
        public string strUsuario { get; set; }
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public string strContraseña { get; set; }

        // Constructor sin parámetros
        public clsRegistros()
        {
            // No se realiza ninguna acción en el constructor sin parámetros
        }

        // Constructor con parámetros
        public clsRegistros(int intCedulaUsuario, string strTipoDocumento, string strNombre, string strApellido, string strUsuario, string strContraseña)
        {
            // Asignar los valores de los parámetros a las propiedades de la clase
            this.intCedulaUsuario = intCedulaUsuario;
            this.strTipoDocumento = strTipoDocumento;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.strUsuario = strUsuario;
            this.strContraseña = strContraseña;
        }

        public bool datosUsuarios()
        {

            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();

            // Definir la instrucción SQL para insertar los datos sobre el registro en la tabla tblUsuarios
            string datosUsuarios = "INSERT INTO tblUsuarios VALUES (@intCedulaUsuario, @strTipoDocumento, @strNombre, @strApellido, @strNombreUsuario, @strContraseña)";

            // Crear un objeto SqlCommand con la instrucción SQL y la conexión establecida
            SqlCommand sql = new SqlCommand(datosUsuarios, Conexion);

            // Asignar los valores de los parámetros a los valores de las propiedades de la clase
            sql.Parameters.AddWithValue("@intCedulaUsuario", this.intCedulaUsuario);
            sql.Parameters.AddWithValue("@strTipoDocumento", this.strTipoDocumento);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strNombreUsuario", this.strUsuario);
            sql.Parameters.AddWithValue("@strContraseña", this.strContraseña);

            // Ejecutar el comando SQL para insertar los datos del registro en la tabla
            sql.ExecuteNonQuery();

            // Indicar que la operación se realizó correctamente
            return true;
        }
    }
}
