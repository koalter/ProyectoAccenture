using Consola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArticulosManager : Manager
    {
        
        public ArticulosManager(CualquieraDBEntities _contexto) : base(_contexto)
        {
        }

        public void AgregarArticulo(int param)
        {
            UpdateContexto();
            Stock stock = CrearStock();
            Articulo articulo = CrearArticulo();
            contexto.Articulos.Add(articulo);
            contexto.Stocks.Add(stock);
            contexto.SaveChanges();
            Console.WriteLine("articulo " + articulo.articuloID + " dado de alta");
        }

        private Stock CrearStock()
        {
            return new Stock();
        }
        private Articulo CrearArticulo()
        {
            return new Articulo();
        }

        public void BajaArticulo(int idArticulo)
        {
            UpdateContexto();
            Stock stock = contexto.Stocks.Find(idArticulo);
            contexto.Articulos.Remove(stock.Articulo);
            contexto.Stocks.Remove(stock);
            Console.WriteLine("articulo " + stock.Articulo.articuloID + " dado de baja");
            contexto.SaveChanges();
        }

        public void EditarArticulo(int idArticulo)
        {

        }

        public List<Articulo> ListarArticulos()
        {
            UpdateContexto();
            return contexto.Articulos.ToList();
        }


        public List<Articulo> BuscarArticulosPorCAtegoria(string pCategoria)
        {
            UpdateContexto();
            List<Articulo> retorno = contexto.Articulos.Where(f => f.categoria == pCategoria).ToList();
            int i = 0;
            for (i = 0; i < retorno.Count(); i++)
            {
                retorno.Add(retorno[i]);
            }
            Console.WriteLine(" " + i + " articulos encontrados en la categoria " + pCategoria);
            return retorno;
        }
    }
}
