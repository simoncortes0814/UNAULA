using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace wOficinaEmpleo
{
    internal class clsOficinaEmpleos
    {
        public int intNoDocumento { get; set; }
        public string strDocumentoIdentidad { get; set; }
        public string strApellido { get; set; }
        public string strNombre { get; set; }
        public string dateFechaNacimiento { get; set; }
        public string strNivelEstudios { get; set; }
        public string strTituloAcademico { get; set; }

        public clsOficinaEmpleos()
        {

        }
        public clsOficinaEmpleos(int intNoDocumento, string strDocumentoIdentidad, string strApellido, string strNombre, string dateFechaNacimiento, string strNivelEstudios, string strTituloAcademico)
        {
            this.intNoDocumento = intNoDocumento;
            this.strDocumentoIdentidad = strDocumentoIdentidad;
            this.strApellido = strApellido;
            this.strNombre = strNombre;
            this.dateFechaNacimiento = dateFechaNacimiento;
            this.strNivelEstudios = strNivelEstudios;
            this.strTituloAcademico = strTituloAcademico;

        }

        public bool InsertarEmpleados()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();
            string insertarEmpleados = "INSERT INTO  tblModuloEmpleados VALUES (@intNoDocumento, @strDocumentoIdentidad, @strApellido, @strNombre, @dateFechaNacimiento, @strNivelEstudios, @strTituloAcademico)";

            SqlCommand sql = new SqlCommand(insertarEmpleados, conexion);

            sql.Parameters.AddWithValue("@intNoDocumento", this.intNoDocumento);
            sql.Parameters.AddWithValue("@strDocumentoIdentidad", this.strDocumentoIdentidad);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@dateFechaNacimiento", this.dateFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelEstudios", this.strNivelEstudios);
            sql.Parameters.AddWithValue("@strTituloAcademico", this.strTituloAcademico);

            sql.ExecuteNonQuery();

            return true;

        }
        public DataTable consultarDatos()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();

            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM tblModuloEmpleados";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public DataTable consultarDatosPersona(int intNoDocumento)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();

            this.intNoDocumento = intNoDocumento;

            DataTable dt = new DataTable();
            string consultaIndividual = "SELECT * FROM tblModuloEmpleados where intNoDocumento = @intNoDocumento ";
            SqlCommand cmd = new SqlCommand(consultaIndividual, conexion);

            cmd.Parameters.AddWithValue("@intNoDocumento", this.intNoDocumento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public bool eliminarDatos(int intNoDocumento)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();

            this.intNoDocumento = intNoDocumento;
            string eliminar = "DELETE tblModuloEmpleados where intNoDocumento = @intNoDocumento";
            SqlCommand sql = new SqlCommand(eliminar, conexion);

            sql.Parameters.AddWithValue("@intNoDocumento", this.intNoDocumento);
            sql.ExecuteNonQuery();

            return true;

        }
        
            public bool modificarDatosEmpleados()
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
                conexion.Open();

                string modificar = "UPDATE tblModuloEmpleados SET strDocumentoIdentidad = @strDocumentoIdentidad, strNombre = @strNombre, strApellido = @strApellido, dateFechaNacimiento = @dateFechaNacimiento, strNivelEstudios = @strNivelEstudios, strTituloAcademico = @strTituloAcademico WHERE intNoDocumento = @intNoDocumento";
                SqlCommand sql = new SqlCommand(modificar, conexion);

                sql.Parameters.AddWithValue("@intNoDocumento", intNoDocumento);
                sql.Parameters.AddWithValue("@strDocumentoIdentidad", strDocumentoIdentidad);
                sql.Parameters.AddWithValue("@strNombre", strNombre);
                sql.Parameters.AddWithValue("@strApellido", strApellido);
                sql.Parameters.AddWithValue("@dateFechaNacimiento", dateFechaNacimiento);
                sql.Parameters.AddWithValue("@strNivelEstudios", strNivelEstudios);
                sql.Parameters.AddWithValue("@strTituloAcademico", strTituloAcademico);

                sql.ExecuteNonQuery();
                return true;
            }
        



    }
}
