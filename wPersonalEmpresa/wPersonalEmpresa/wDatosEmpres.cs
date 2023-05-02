using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;

namespace wPersonalEmpresa
{
    public partial class wDatosEmpres : Form
    {
        public wDatosEmpres()
        {
            InitializeComponent();
        }

        private Stream myStream;
        string line; 
        int count = 0;
        private void CSV_Click(object sender, EventArgs e)
        {

            string[] result;
           
            Column7.HeaderText = "FECHA DE NACIMIENTO";
            Column7.Width = 200;
            Column1.Width = 200;
            Column7.ReadOnly = true;


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivo (*.csv) | *.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);

                            while ((line = file.ReadLine()) != null)
                            {
                                result = line.Split(';');

                                dtgCSV.Rows.Add(result[0] = "CR 93B No 32-43 AB39", result[1] = "CF UNAULA", result[2], result[3], result[4], result[5], result[6], result[7], result[8]);

                                count++;
                            }
                            file.Close();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk. Original error:" + ex.Message);
                }
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgCSV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }
    }
}
