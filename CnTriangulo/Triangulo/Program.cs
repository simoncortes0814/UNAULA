using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos: inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.
            ClsLados Triangulo = new ClsLados();

            Console.WriteLine("Por favor ingrese el primer lado");
            Triangulo.Lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo lado");
            Triangulo.Lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer lado");
            Triangulo.Lado3 = int.Parse(Console.ReadLine());

            Triangulo.Ladomayor();
            Triangulo.trianguloequilatero();

            Console.ReadKey();
        }


    }
}
