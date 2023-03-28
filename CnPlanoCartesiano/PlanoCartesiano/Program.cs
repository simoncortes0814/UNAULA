using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsCuadrantePlano Plano = new ClsCuadrantePlano();

            Plano.Cuadrantes();
            Console.ReadKey();
        }
    }
}
