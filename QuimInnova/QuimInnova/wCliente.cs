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
    public partial class wCliente : Form
    {
        public wCliente()
        {
            InitializeComponent();
        }

        private void cONTACTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deja de manera que no se puede usar este boton para que solo aparezca el número telefonico de la empresa o el contacto mejor decirlo
            cONTACTOToolStripMenuItem.Enabled = false;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario wProductoClientes
            wProductoClientes wProductoClientes = new wProductoClientes();

            // Establecer el formulario wProductoClientes como formulario secundario del formulario actual (this)
            wProductoClientes.MdiParent = this;

            // Mostrar el formulario wProductoClientes
            wProductoClientes.Show();
        }
 

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre el inicio de sesión y cierra este formulario
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
