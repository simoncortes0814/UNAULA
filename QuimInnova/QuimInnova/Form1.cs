using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuimInnova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana wRegistro 
            wRegistro wRegistro = new wRegistro();
            // Mostrar la ventana wRegistro en la pantalla
            wRegistro.Show();
            // Ocultar la ventana actual
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            // Crear una instancia de la clase clsClientesIngreso con los valores de usuario y contraseña proporcionados los cuales ayudaran a ingresar al usuario a su funcion
            clsClientesIngreso clientesIngreso = new clsClientesIngreso(txtUsuario.Text, txtContraseña.Text);

            // Llamar al método ingresoClientes() en la instancia de clsClientesIngreso para realizar el ingreso de los clientes
            clientesIngreso.ingresoClientes();

            // Ocultar la ventana actual
            this.Hide();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //Se cierra el programa
            this.Close();
        }
    }
}
