using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    class EmpleadosManager
    {
        CualquieraDBEntities contexto;
        public EmpleadosManager(CualquieraDBEntities _contexto)
        {
            contexto = _contexto;
        }

        public void AgregarEmpleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal)
        {
            Empleado empleado = CrearEmpleado(id, nombre, apellido, ingreso, egreso, estado, telefono, cuil, sucursal);
            contexto.Empleadoes.Add(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de alta");
        }
        public void AgregarEmpleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal, int contraseña,
            int idencargado, int clave)
        {
            Empleado empleado = CrearEmpleado(id, nombre, apellido, ingreso, egreso, estado, telefono, cuil, sucursal);
            Encargado encargado = CrearEncargado(id, idencargado, clave);
            empleado.Encargadoes.Add(encargado);
            contexto.Empleadoes.Add(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de alta");
        }

        private Empleado CrearEmpleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal)
        {
            return new Empleado(id, nombre, apellido, ingreso, egreso, estado, telefono, cuil, sucursal);
        }
        private Encargado CrearEncargado(int id, int idencargado, int clave)
        {
            Encargado encargado = new Encargado();
            encargado.id_empleado = id;
            encargado.id_encargado = idencargado;
            encargado.clave = clave;
            return encargado;
        }

        public void BajaEmpleado(int idempleado)
        {
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            contexto.Empleadoes.Remove(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de baja");
        }

        public void EditarEstado(int idempleado, bool estado)
        {
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            empleado.Estado = estado;
            contexto.SaveChanges();
        }

        public bool ObtenerEstado(int empleadoid)
        {
            Empleado empleado = contexto.Empleadoes.Find(empleadoid);
            if (empleado != null)
            {
                return empleado.Estado;
            }
            return false;
        }

        public bool ObtenerEsjefe(int empleadoId)
        {
            Encargado encargado = contexto.Encargadoes.Find(empleadoId);
            if (encargado != null)
            {
                return true;
            }
            return false;
        }

        public void EditarSucursal(int idempleado, int idSucursal)
        {
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            empleado.Id_Sucursal = idSucursal;
            contexto.SaveChanges();
        }

        public void ListarEmpleados()
        {
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            Console.WriteLine("\t" + "Id" +
                   "\t" + "Nombre" +
                   "\t" + "Apellido" +
                   "\t" + "Cuil" +
                   "\t" + "Estado" +
                   "\t" + "Telefono" +
                   "\t" + "Sucursal" +
                   "\t" + "Fecha_de_Ingreso" +
                   "\t" + "Fecha_de_Egreso" +
                   "\t" + "Encargadoes");
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine("\t" + empleado.Id +
                    "\t" + empleado.Nombre +
                    "\t" + empleado.Apellido +
                    "\t" + empleado.Cuil +
                    "\t" + empleado.Estado +
                    "\t" + empleado.Telefono +
                    "\t" + empleado.Sucursal + 
                    "\t" + empleado.Fecha_de_Ingreso +
                    "\t" + empleado.Fecha_de_Egreso +
                    "\t" + empleado.Encargadoes);
            }
        }

    }
}
