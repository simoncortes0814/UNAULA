using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace wOficinaEmpleo
{
    class clsEmpleos
    {
        public int intCodigoEmpleos { get; set; }
        public string strNombreEmpleo { get; set; }
        public string strDescripcion { get; set; }
        public int intRangoSalarial { get; set; }
        public string strExperiencia { get; set; }

        public clsEmpleos()
        {

        }

        public clsEmpleos(int intCodigoEmpleos, string strNombreEmpleo, string strDescripcion, int intRangoSalarial, string strExperiencia)
        {
            this.intCodigoEmpleos = intCodigoEmpleos;
            this.strNombreEmpleo = strNombreEmpleo;
            this.strDescripcion = strDescripcion;
            this.intRangoSalarial = intRangoSalarial;
            this.strExperiencia = strExperiencia;
        }

        public DataTable consultarEmpleos()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();

            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM tblModuloEmpleos";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public DataTable seleccionarDato(int intCodigoEmpleos)
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboOficinadeEmpleos;integrated security=true");
            conexion.Open();

            // Asignar el codigo de empleo recibido al campo de la clase

            this.intCodigoEmpleos = intCodigoEmpleos;

            
            // Crear un objeto DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();

            //Creamos una variable a la cual se le asigna la consulta deseada
            string seleccionar = "SELECT * FROM tblModuloEmpleos WHERE intCodigoEmpleo = @intCodigoEmpleo";

            // Crear el comando SQL y asignar la consulta y la conexión
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);

            // Asignar el parámetro para el codigo de empleo
            cmd.Parameters.AddWithValue("@intCodigoEmpleo", this.intCodigoEmpleos);

            // Se crea un SqlDataAdapter para ejecutar el comando(cmd) y llenar el DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }


    }
}
