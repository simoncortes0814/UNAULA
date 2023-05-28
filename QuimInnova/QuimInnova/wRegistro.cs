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
    public partial class wRegistro : Form
    {
        public wRegistro()
        {
            InitializeComponent();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Comprobar si algún campo obligatorio está vacío
            if (string.IsNullOrEmpty(txtConfirmarContraseña.Text) || string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtDocumento.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(cmbTipoDocumento.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Comprobar si el tipo de documento es "TI"
            else if (cmbTipoDocumento.Text == "TI")
            {
                //Si tiene documento de identidad no se le permetira el ingreso
                MessageBox.Show("Al ser menor de edad no puede ser registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Comprobar si las contraseñas coinciden
            else if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                // Mostrar mensaje de registro exitoso
                MessageBox.Show("Registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una instancia de la clase clsRegistros con los valores proporcionados
                clsRegistros Registros = new clsRegistros(int.Parse(txtDocumento.Text), cmbTipoDocumento.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContraseña.Text);

                // Llamar al método datosUsuarios() en la instancia de clsRegistros para guardar los datos del usuario
                Registros.datosUsuarios();

                // Mostrar la ventana Form1
                Form1 form1 = new Form1();
                form1.Show();

                // Ocultar la ventana actual
                this.Hide();
            }
            else
            {
                //Si las contraseñas son diferentes aparecera el siguiente messageBox
                MessageBox.Show("Verifique que las contraseñas sean correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Hace que se abra el form1 y se cierre el actual
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
