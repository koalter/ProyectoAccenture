using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Consola
{
    class EmpleadosManager
    {
        CualquieraDBEntities contexto;
        public EmpleadosManager(CualquieraDBEntities _contexto)
        {
            contexto = _contexto;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            contexto.Empleadoes.Add(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de alta");
        }

        public void BajaEmpleado(int idempleado)
        {
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            for (int i = 0 ; i < empleados.Count(); i++)
            {
                if (empleados[i].Id == idempleado)
                {
                    contexto.Empleadoes.Remove(empleados[i]);
                    Console.WriteLine("empleado " + empleados[i].Id + " dado de baja");
                    break;
                }
            }
            contexto.SaveChanges();
        }

        public void EditarEstado(Empleado empleado, bool estado)
        {
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            for (int i = 0; i < empleados.Count(); i++)
            {
                if (empleados[i].Id == empleado.Id)
                {
                    empleado.Estado = estado;
                }
            }
            contexto.SaveChanges();
        }

        public bool ObtenerEstado(Empleado empleado)
        {
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            for (int i = 0; i < empleados.Count(); i++)
            {
                if (empleados[i].Id == empleado.Id)
                {
                    return empleado.Estado;
                }
            }
            return false;
        }

        public bool ObtenerEsjefe(int empleadoId)
        {
            List<Encargado> encargados = contexto.Encargadoes.ToList();
            for (int i = 0; i < encargados.Count(); i++)
            {
                if (encargados[i].id_empleado == empleadoId)
                {
                    return true;
                }
            }
            return false;
        }

        public void EditarSucursal(Empleado empleado, int idSucursal)
        {
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            for (int i = 0; i < empleados.Count(); i++)
            {
                if (empleados[i].Id == empleado.Id)
                {
                    empleado.Id_Sucursal = idSucursal;
                }
            }
            contexto.SaveChanges();
        }

        public List<Empleado> ListarEmpleados()
        {
            return contexto.Empleadoes.ToList();
        }

    }
}
