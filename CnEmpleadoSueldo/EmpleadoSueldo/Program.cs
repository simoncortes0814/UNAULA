using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmpleado Empleado = new ClsEmpleado();

            Empleado.CargarDatos();
            Empleado.Imprimir();
            Empleado.Impuesto();


            Console.ReadKey();

            
        }
    }
}
