using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Consola;


namespace Entidades
{
    class EventosManager : Manager
    {
        public EventosManager(CualquieraDBEntities _contexto) : base(_contexto)
        {
        }

        public void AgregarEvento(Evento evento)
        {
            UpdateContexto();
            contexto.Eventos.Add(evento);
            contexto.SaveChanges();
            Console.WriteLine("evento " + evento.id_evento + " dado de alta");
        }

        public List<Evento> ListarEventos()
        {
            UpdateContexto();
            return contexto.Eventos.ToList();
        }

    }
}
