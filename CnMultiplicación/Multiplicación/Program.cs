using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicación
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
            ClsMultiplicar Multiplicacion = new ClsMultiplicar();

            Multiplicacion.Multiplicación();
            Console.ReadKey();

        }
    }
}
