using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreyEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEdadNombre Persona = new ClsEdadNombre();
            Console.WriteLine("Por favor ingrese su edad principalmente");
            Persona.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ahora su nombre para subirlo al sistema");
            Persona.Nombre = Console.ReadLine();

            
            if (Persona.Edad < 18)
            {
                
                Console.WriteLine(Persona.Nombre + " usted tiene: " + Persona.Edad + " años " + " por lo que usted es menor de edad, podra ser registrado en el sistema cuando cumpla los 18 años" );
            }
            else if (Persona.Edad >= 18)
            {

                Console.WriteLine(Persona.Nombre + " usted tiene: " + Persona.Edad + " años" + " usted ha sido registrado en el sistema con exito");
            }

            Console.ReadKey();
        }
    }
}
