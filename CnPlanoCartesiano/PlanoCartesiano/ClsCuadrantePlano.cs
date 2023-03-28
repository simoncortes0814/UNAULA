using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoCartesiano
{
    class ClsCuadrantePlano
    {
       public int x, y;

        public ClsCuadrantePlano ()
        {
            x = 0;
            y = 0;

        }
        
        public void Cuadrantes ()
        {
            Console.WriteLine("Ingrese del punto en x : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese del punto en y : ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 & y > 0)
            {
                Console.WriteLine("(" + x + "," + y + ")");
                Console.WriteLine("Los siguientes puntos son positivos, por lo que se encuentran en el cuadrante número 1");

            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine("(" + x + "," + y + ")");
                Console.WriteLine("El primer punto es negativo y el segundo positivo, por lo que se encuentran en el cuadrante número 2");

            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine("(" + x + "," + y + ")");
                Console.WriteLine("Los dos puntos son negativos, por lo que se encuentran en el cuadrante número 3");

            }
            else if (x > 0 & y < 0)
            {

                Console.WriteLine("(" + x + "," + y + ")");
                Console.WriteLine("El primer punto es positivo y el segundo es negativo, por lo que se encuentran en el cuadrante número 4");

            }
        }
    }
}
