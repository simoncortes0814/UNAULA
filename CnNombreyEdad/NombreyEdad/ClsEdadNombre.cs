using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreyEdad
{
    class ClsEdadNombre
    {
        
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        //Metodo Constructor 

        public ClsEdadNombre()
        {

            Nombre = "";
            Edad = 0;

        }
            

    }
}
