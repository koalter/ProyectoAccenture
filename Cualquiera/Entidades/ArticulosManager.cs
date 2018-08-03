using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArticulosManager
    {
        CualquieraDBEntities contexto;
        public ArticulosManager(CualquieraDBEntities _contexto)
        {
            contexto = _contexto;
        }

        public void AgregarArticulo(Articulo articulo, Stock stock)
        {
            if (articulo.articuloID == stock.IDArt)
            {
                contexto.Articulos.Add(articulo);
                contexto.Stocks.Add(stock);
                contexto.SaveChanges();
                Console.WriteLine("articulo " + articulo.articuloID + " dado de alta");
            }
            else
                Console.WriteLine("la id del articulo no corresponde con la id del stock");
        }

        public void BajaArticulo(int idArticulo)
        {
            List<Stock> stocks = contexto.Stocks.ToList();
            for (int i = 0; i < stocks.Count(); i++)
            {
                if (stocks[i].Articulo.articuloID == idArticulo)
                {
                    contexto.Articulos.Remove(stocks[i].Articulo);
                    contexto.Stocks.Remove(stocks[i]);
                    Console.WriteLine("articulo " + stocks[i].Articulo.articuloID + " dado de baja");
                    break;
                }
            }
            contexto.SaveChanges();
        }

        public void EditarArticulo(int idArticulo)
        {

        }

        public List<Articulo> ListarArticulos()
        {
            return contexto.Articulos.ToList();
        }


        public List<Articulo> BuscarArticulosPorCAtegoria(string pCategoria)
        {
            List<Articulo> articulos = ListarArticulos();
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
