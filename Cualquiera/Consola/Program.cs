using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.Title = "Comercio Cualquiera";
            int op = menu.Inicio();
            
            switch (op)
            {
                case 1:
                    menu.IngresarAdmin();
                    menu.MenuAdmin();
                    break;
                case 2:
                    menu.MenuEmpleado();
                    break;
                default:
                    Console.WriteLine("No hay mas");
                    break;
            }

            Console.ReadKey();
        }
    }
}
