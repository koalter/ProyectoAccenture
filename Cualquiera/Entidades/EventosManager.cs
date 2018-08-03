using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    class EventosManager
    {
        CualquieraDBEntities contexto;
        public EventosManager(CualquieraDBEntities _contexto)
        {
            contexto = _contexto;
        }

        public void AgregarEvento(Evento evento)
        {
            contexto.Eventos.Add(evento);
            contexto.SaveChanges();
            Console.WriteLine("evento " + evento.id_evento + " dado de alta");
        }

        public List<Evento> ListarEventos()
        {
            return contexto.Eventos.ToList();
        }

    }
}
