using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClsCuadrado
    {
        public int lado;
        public int total;

        public ClsCuadrado()
        {

            lado = 0;
            total = 0;

        }

        public void PerimetroCuadrado ()
        {
            total = lado * 4;
            Console.WriteLine("El perimetro equivale a: " + total + "Cm");
        }

        public void SuperficieCuadrado ()
        {
            total = lado * lado;
            Console.WriteLine("La superficie del cuadrado es igual a: " + total + "Cm cuadrados");
        }

        
    }
}
