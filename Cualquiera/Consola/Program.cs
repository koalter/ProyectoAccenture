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
            Console.Title = "Comercio Cualquiera";
            int op = Menu.Inicio();
            if (op == 1)
            {
                Menu.IngresarAdmin();
                Menu.MenuAdmin();
            }
            else
            {
                Console.WriteLine("No hay mas");
            }
            Console.ReadKey();
        }
    }
}
