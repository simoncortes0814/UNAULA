using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Qué temperatura desea ingresar?");
            Console.WriteLine("Si desea ingresar temperatura en Farenheit por favor presione el número 1");
            Console.WriteLine("Si desea ingresar temperatura en Celsius por favor presione el número 2");
            int TipoTemperatura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura en la que estes por favor: ");
            double Temperatura = Convert.ToInt32(Console.ReadLine());

            if (TipoTemperatura == 1)
            {

                Console.WriteLine(" La temperatura en Farenheit es de:" + Farenheit(Temperatura) + "F°");

                
            }
            else if (TipoTemperatura == 2)
            {

                Console.WriteLine(" La temperatura en Celsius es:" + Celsius(Temperatura) + "C°");


               
            }



            Console.ReadKey();

        }



        private static double Farenheit(double Temperatura)
        {
            double Farenheit = (int)((Temperatura * 9 / 5) + 32);
            Temperatura = Farenheit;
            return Temperatura;
        }


        private static double Celsius(double Temperatura)
        {

            double Celsius = (int)((Temperatura - 32) * 5 / 9);
            Temperatura = Celsius;
            return Temperatura;
        
    }
    }
}
