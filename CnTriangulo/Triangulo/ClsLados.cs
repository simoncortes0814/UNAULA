using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class ClsLados
    {
        public int Lado1, Lado2, Lado3;

        //Metodo constructor
        public ClsLados()
        {
            Lado1 = 0;
            Lado2 = 0;
            Lado3 = 0;
        }

        //Declaramos metodo para saber cual es el lado mayor
        public void Ladomayor()
        {
            if (Lado1 > Lado2 & Lado1 > Lado3)
            {
                Console.WriteLine("El lado mayor es el lado número 1, mide: " + Lado1 + "Cm");

            }
            else if (Lado2 > Lado1 & Lado2 > Lado3)
            {
                Console.WriteLine("El lado mayor es el lado número 2, mide: " + Lado2 + "Cm");
            }
            else if (Lado3 > Lado1 & Lado3 > Lado2) 
            {
                Console.WriteLine("El lado mayor es el lado número 3 , mide: " + Lado3 + "Cm");
            }
            else
            {
                Console.WriteLine("Todos los lados ingresados son iguales");
            }


        }
        public void trianguloequilatero()
        {
            if (Lado1 == Lado2 & Lado1 == Lado3)
            {
                Console.WriteLine("El triangulo ingresado segun sus lados es un triangulo equilatero");

            }
            else
            {
                Console.WriteLine("No es un triangulo equilatero ");
            }
        }



    }
}
