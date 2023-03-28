using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClsCuadrado Cuadrado = new ClsCuadrado();

            Console.WriteLine("Ingrese por favor el lado del cuadrado para así sacar la superficie y el perimetro ");
            Cuadrado.Lados = int.Parse(Console.ReadLine());

            //Llamamos los metodos para las formulas

            Cuadrado.PerimetroFormula();

            Cuadrado.SuperficieFormula();


            Console.ReadKey();
        }
    }

}
