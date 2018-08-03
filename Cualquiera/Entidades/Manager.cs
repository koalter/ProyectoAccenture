using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Manager
    {
        public CualquieraDBEntities contexto;

        public Manager(CualquieraDBEntities _contexto)
        {
            contexto = _contexto;
        }

        public void UpdateContexto()
        {
            contexto = new CualquieraDBEntities();
        }
    }
}
