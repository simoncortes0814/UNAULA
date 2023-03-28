using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresMayor
{
    class ClsValor
    {
        public int valor1, valor2, valor3;

        public ClsValor()
        {
            valor1 = 0;
            valor2 = 0;
            valor3 = 0;
        }

        public void MayorMenor()
        {
            Console.WriteLine("Por favor ingrese el primer valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo valor");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer valor");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 & valor1 > valor3 & valor2 > valor3)
            {
                Console.WriteLine("El valor mayor es: " + valor1 + " El valor menor es" + valor3);
            }
            else if (valor1 > valor2 & valor1 > valor3 & valor2 < valor3)
            {
                Console.WriteLine("El valor mayor es: " + valor1 + " El valor menor es" + valor2);
            }
            else if (valor2 > valor1 & valor2 > valor3 & valor3 > valor1)
            {
                Console.WriteLine("El valor mayor es: " + valor2 + " El valor menor es" + valor1);
            
            }
            else if (valor2 > valor1 & valor2 > valor3 & valor3 < valor1)
            {
                Console.WriteLine("El valor mayor es: " + valor2 + " El valor menor es" + valor3);
            }
            else if (valor3 > valor1 & valor3 > valor2 & valor2 > valor1)
            {
                Console.WriteLine("El valor mayor es: " + valor3 + "El valor menor es " + valor1);
            }
            else if (valor3 > valor1 & valor3 > valor2 & valor2 < valor1)
            {
                Console.WriteLine("El valor mayor es: " + valor3 + "El valor menor es " + valor2 );
            }

        }

    }

}
