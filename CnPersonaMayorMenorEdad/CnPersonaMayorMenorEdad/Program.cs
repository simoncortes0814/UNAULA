using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPersonaMayorMenorEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona PersonaDatos = new ClsPersona();

            Console.WriteLine("Por favor ingrese su nombre");
            PersonaDatos.nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad");
            PersonaDatos.edad = int.Parse(Console.ReadLine());
            PersonaDatos.MayorMenor();

            Console.ReadKey();

        }
    }
}
