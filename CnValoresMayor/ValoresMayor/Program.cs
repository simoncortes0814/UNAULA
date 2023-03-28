using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor.

            ClsValor Valores = new ClsValor();

            Valores.MayorMenor();

            Console.ReadKey();

        }
    }
}
