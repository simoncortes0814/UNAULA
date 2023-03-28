using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha: Marzo 14 de 2023
/// Autor: Simón Cortés Lotero
/// Descripción: Aplicación para el trazo de una linea
/// </summary>
namespace wLineas
{
    public partial class frmtrazodelinea : Form
    {

        public const int Xinicial = 0;
        public const int Xfinal= 0;
        public const int Yfinal = 0;
        public const int Yinicial = 0;
        Graphics graficoLinea;

        public frmtrazodelinea()
        {
            InitializeComponent();
            graficoLinea = CreateGraphics();
          
        }

        private void btndibujolinea_Click(object sender, EventArgs e)
        {
            try
            {
                double Xinicial = double.Parse(txtxinicial.Text);
                double Yinicial = double.Parse(txtyinicial.Text);
                double Xfinal = double.Parse(txtxfinal.Text);
                double Yfinal = double.Parse(txtyfinal.Text);

                ClsLineas linea = new ClsLineas(Xfinal, Xinicial, Yfinal, Yinicial);

                Pen pen = new Pen(Brushes.Blue);

          
                graficoLinea.DrawLine(pen, linea.obtenxf(), linea.obtenxi(), linea.obtenyf(), linea.obtenyi());

                txtCantLineas.Text = Convert.ToString(ClsLineas.SubirCuenta());
            }
            catch 
            {
                MessageBox.Show("Por favor ingrese solo números");
                
            }
        } 

        private void frmtrazodelinea_Load(object sender, EventArgs e)
        {

        }
    }
}
