using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menu
    {
        public static int Inicio()
        {
            Menu.dibujarInicio();
            int op;
            while (!(int.TryParse(Console.ReadLine(), out op)) || (op != 1 && op != 2)) //si es letra, y ninguna opcion entra
            {
                Console.WriteLine("Ingreso una opción incorrecta");
                Console.ReadKey();
                Console.Clear();
                Menu.dibujarInicio();
            }
            Console.WriteLine("Entraste como {0}", op);
            return op;
        }
        public static void IngresarAdmin()
        {
            Console.Write("Ingrese la contraseña (1111): ");
            while (Console.ReadLine() != Convert.ToString(1111))
            {
                Console.WriteLine("Contraseña incorrecta!!");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Ingrese la contraseña (1111): ");
            }
            Console.Clear();
        }
        public static void MenuAdmin()
        {
            int op;
            do
            {
                Console.WriteLine("Bienvenido Admin !");
                Console.WriteLine("1. Listar Empleados");
                Console.WriteLine("9. Salir");

                bool band = int.TryParse(Console.ReadLine(), out op);
                if (band)
                {
                    switch (op)
                    {
                        case 1:
                            MenuAdmin();
                            break;
                        case 2:
                            break;
                        default:
                            op = 9;
                            break;
                    }
                }
                else
                {
                    op = -1;
                    Console.WriteLine("Ingresó una opción incorrecta");
                }
                Console.ReadKey();
                Console.Clear();

            } while (op != 9);
            Console.ReadKey();
            Console.Clear();
        }
        static void dibujarInicio()
        {
            Console.WriteLine("¿Qué usuario es?");
            Console.WriteLine("1. Administrador");
            Console.WriteLine("2. Empleado");
        }
    }
}
