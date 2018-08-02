using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArticulosManager
    {
        private List<Articulo> lista;
        CualquieraDBEntities contexto;
        public ArticulosManager()
        {
            lista = new List<Articulo>();
            contexto = new Entidades.CualquieraDBEntities();
        }

        public void AgregarArticulo(Articulo articulo)
        {
            // aca se sube un articulo a la base de datos
            contexto.Articulos.Add(articulo);
            contexto.SaveChanges();
            lista.Add(articulo);
        }

        public void BajaArticulo(Articulo articuloId)
        {
            // aca se da la baja de un Articulo de la base de datos
            List<Articulo> articulos = contexto.Articulos.ToList();
            foreach (var item in articulos)
            {
                if (item == articuloId)
                {
                    contexto.Articulos.Remove(item);
                    lista.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Articulo" + articuloId + "dado de baja");
        }

        public void EditarArticulo(int idArticulo)
        {

        }

        public List<Articulo> BuscarArticulo()
        {
            return contexto.Articulos.ToList();
        }


        public List<Articulo> BuscarArticulosPorCAtegoria(string pCategoria)
        {
            List<Articulo> articulos = BuscarArticulo();
            List<Articulo> retorno = new List<Articulo>();

            for (int i = 0; i < articulos.Count(); i++)
            {
                if (pCategoria == articulos[i].categoria)
                {
                    retorno.Add(articulos[i]);
                }
            }

            return retorno;
        }
    }
}
