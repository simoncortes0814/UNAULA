using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSueldo
{
    class ClsEmpleado
    {
        private string nombre;
        private int sueldo;
        private string apellido;
       
        public string Nombre { get => nombre; set => nombre = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public ClsEmpleado()
        {
            Nombre = "";
            Sueldo = 0;
            Apellido = "";
       
        }

        public void CargarDatos()
        {
            Console.WriteLine("Señor Usuario, por favor ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Señor Usuario, por favor ingrese su apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Señor Usuario, por favor ingrese su sueldo");
            Sueldo = int.Parse(Console.ReadLine());
         

        }

        public void Imprimir()
        {
            Console.WriteLine("Señor " + Nombre + " " + Apellido);
            Console.WriteLine("Su sueldo es de: " + Sueldo + " Dolares" );
     
           
        }
        
        

        public void Impuesto()
        {
            if (Sueldo >= 3000)
            {
                Console.WriteLine("Señor " + Nombre + " usted debe de pagar impuesto.");
            }
            else
            {
                Console.WriteLine("Señor " + Nombre + " usted no debe de pagar impuesto.");
            }

        }

        


        

    }
}
