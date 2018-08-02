using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ProyectoIntegrador
    {
        const string nombreAdministrador = "";

        public ProyectoIntegrador()
        {

        }
        public string Authentication(string nom)
        {
            string nombre = nom;
            // aca se pregunta el nombre del empleado
            return nombre;
        }
        void OnAccess(string nombre)
        {
            if (nombre == nombreAdministrador)
            {

            }

        }
        void Deinit()
        {

        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
