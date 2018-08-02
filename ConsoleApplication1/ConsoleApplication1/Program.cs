using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comercio Cualquiera";
            Console.WriteLine("¿Qué usuario es?");
            Console.WriteLine("1. Administrador");
            Console.WriteLine("2. Empleado");
            int op;
            if(int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine(op);
            }
            else
            {
                Console.WriteLine("Ingreso una opción incorrecta");
            }
            Console.ReadKey();
        }
    }
}
