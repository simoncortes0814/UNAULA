using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicación
{
    class ClsMultiplicar
    {
        public int Numero;
        public int i;
        public int total;
        public string Salir;
        public ClsMultiplicar()
        {
            Numero = 0;
            i = 0;
            total = 0;
        }

        public void Multiplicación()
        {
            Console.WriteLine("Ingrese el número que desee multiplicar");
            Numero = int.Parse(Console.ReadLine());
            while (i<13)
            {
                total = Numero * i;
                Console.WriteLine(Numero + "*" + i + "=" + total);
                i += 1;
            }
            Console.WriteLine("Para finalizar el ejercicio escriba -1");
            Salir = Console.ReadLine();
            if (Salir == "-1")
            {
                Environment.Exit(0);
            }
            
            
            
        }

    }
}
