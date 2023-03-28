using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPersonaMayorMenorEdad
{
    class ClsPersona
    {
        public string nombre, apellido, correo;
        public int edad;
        public ClsPersona()
        {
            nombre = "";
            correo = "";
            apellido = "";
            edad = 0;

        }

        public void MayorMenor()
        {   
            
            if (edad >= 18)
            {
                Console.WriteLine( nombre + " Termine su registro por favor");
                Console.WriteLine("Por favor ingrese su apellido");
                apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su correo electronico");
                correo = Console.ReadLine();
                Console.WriteLine("Se ha registrado con exito");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Usted es menor de edad, no puede terminar el registro");
            }

        }
    }

}
