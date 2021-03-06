﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Consola;

namespace Entidades
{
    class EmpleadosManager : Manager
    {
        public EmpleadosManager(CualquieraDBEntities _contexto) : base(_contexto)
        {
        }

        public void AgregarEmpleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal)
        {
            UpdateContexto();
            Empleado empleado = CrearEmpleado(id, nombre, apellido, ingreso, egreso, estado, telefono, cuil, sucursal);
            contexto.Empleadoes.Add(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de alta");
        }
        public void AgregarEmpleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal, int contraseña,
            int idencargado, int clave)
        {
            UpdateContexto();
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
            UpdateContexto();
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            contexto.Empleadoes.Remove(empleado);
            contexto.SaveChanges();
            Console.WriteLine("empleado " + empleado.Id + " dado de baja");
        }

        public void EditarEstado(int idempleado, bool estado)
        {
            UpdateContexto();
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            empleado.Estado = estado;
            contexto.SaveChanges();
        }

        public bool ObtenerEstado(int empleadoid)
        {
            UpdateContexto();
            Empleado empleado = contexto.Empleadoes.Find(empleadoid);
            if (empleado != null)
            {
                return empleado.Estado;
            }
            return false;
        }

        public bool ObtenerEsjefe(int empleadoId)
        {
            UpdateContexto();
            Encargado encargado = contexto.Encargadoes.Find(empleadoId);
            if (encargado != null)
            {
                return true;
            }
            return false;
        }

        public void EditarSucursal(int idempleado, int idSucursal)
        {
            UpdateContexto();
            Empleado empleado = contexto.Empleadoes.Find(idempleado);
            empleado.Id_Sucursal = idSucursal;
            contexto.SaveChanges();
        }

        public void ListarEmpleados()
        {
            UpdateContexto();
            List<Empleado> empleados = contexto.Empleadoes.ToList();
            foreach (Empleado empleado in empleados)
            {
                Console.Write("Legajo: " + empleado.Id +
                    "\nNombre: " + empleado.Nombre +
                    "\t\t\t\tApellido: " + empleado.Apellido +
                    "\nCuil: " + empleado.Cuil);
                if(empleado.Estado)
                {
                    Console.Write("\t\t\tEstado: trabajando");
                }
                else
                {
                    Console.Write("\t\t\tEstado: suspendido");
                }
                Console.WriteLine(
                    "\nTelefono: " + empleado.Telefono +
                    "\t\t\tSucursal: " + empleado.Sucursal.nombre +
                    "\nFecha_de_Ingreso: " + empleado.Fecha_de_Ingreso +
                    "\tFecha_de_Egreso: " + empleado.Fecha_de_Egreso +
                    "\n");
            }
        }

    }
}
