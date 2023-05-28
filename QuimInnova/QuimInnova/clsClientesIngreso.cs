using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuimInnova
{
    class clsClientesIngreso
    {
        public string strNombreUsuario { get; set; }
        public string strContraseña { get; set; }

        public clsClientesIngreso(string strNombreUsuario, string strContraseña)
        {
            this.strNombreUsuario = strNombreUsuario;
            this.strContraseña = strContraseña;

        }

        public bool ingresoClientes()
        {
            // Establecer la conexión a la base de datos
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-TUHG0K3;database=dboQuimInnova;integrated security=true");
            Conexion.Open();
            // Consulta SQL para verificar el inicio de sesión del cliente
            //El SELECT COUNT(*) FROM tblUsuarios verifica o cuenta la cantidad de registros de personas que hay en la tabla usuarios
            string ingresoUsuario = "SELECT COUNT(*) FROM tblUsuarios WHERE strNombreUsuario = @strNombreUsuario AND strContraseña = @strContraseña";

            //Se instancia un objeto SqlCommand con los parametros de la consulta ingresoUsuario y con la conexion del servidor
            SqlCommand sql= new SqlCommand(ingresoUsuario, Conexion);

            // Asignar los parámetros de la consulta o donde se van a hallar
            sql.Parameters.AddWithValue("@strNombreUsuario", this.strNombreUsuario);
            sql.Parameters.AddWithValue("@strContraseña", this.strContraseña);

            // Ejecutar la instrucción SQL y obtener el resultado
            object result = sql.ExecuteScalar();

            // se hace una condición la cual verifica si el resultado es nulo
            if (result != null && result != null)
            {
                //Se convierte el resultado en un entero
                int count = Convert.ToInt32(result);
                //El primer usuario que se registra es el del administrador, el cual tiene un campo solo para él y sus funciones
                if (strNombreUsuario == "Quiminnova0201" & strContraseña == "12345")
                {
                    // Mostrar mensaje de inicio de sesión exitoso
                    MessageBox.Show("Inicio de sesión exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Abrir la ventana de administradores
                    wAdministradores wAdministradores = new wAdministradores();
                    wAdministradores.Show();
                }
                // Verificar si las credenciales coinciden con un cliente
                else if (count > 0)
                {
                    
                    MessageBox.Show("Inicio de sesión exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Abrir la ventana de clientes
                    wCliente wCliente = new wCliente();
                    wCliente.Show();
                    
                }
                // En caso de que las credenciales no coincidan con ningún administrador ni cliente
                else
                {
                    // En caso de que las credenciales no coincidan con ningún administrador ni cliente
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Abrir el formulario de inicio de sesión nuevamente
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
            {
                // Mostrar mensaje de error de inicio de sesión
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Abrir el formulario de inicio de sesión nuevamente
                Form1 form1 = new Form1();
                form1.Show();
            }
            return true;
        }

    }
}
