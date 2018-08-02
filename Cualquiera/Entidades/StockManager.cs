using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockManager
    {
        /*private List<Stock> lista;
        CualquieraDBEntities contexto;
        public StockManager()
        {
            lista = new List<Stock>();
            contexto = new Entidades.CualquieraDBEntities();
        }

        public void AgregarStock(Stock articulo)
        {
            // aca se sube un articulo a la base de datos
            contexto.Articulos.Add(articulo);
            contexto.SaveChanges();
            lista.Add(articulo);
        }

        public void BajaStock(int stockId)
        {
            // aca se da la baja de un Articulo de la base de datos
            List<Stock> Stock = contexto.Stock.ToList();
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].Id == stockId)
                {
                    contexto.Stock.Remove(lista[i]);
                    lista.Remove(lista[i]);
                    break;
                }
            }
            Console.WriteLine("Stock" + StockId + "dado de baja");
        }

        public void EditarStock(int idStock)
        {

        }

        public List<Stock> BuscarStock()
        {
            return contexto.Stock.toList();
        }

        public List<Stock> BuscarStockPorSucursal(int idSucursal)
        {
            List<Stock> Stock = BuscarStock();
            List<Stock> retorno = new List<Stock>();
            for (int i = 0; i < Stock.Count(); i++)
            {
                if (Stock[i].IDSuc == idSucursal)
                {
                    retorno.Add(Stock[i]);
                }
            }

            return retorno;
        }*/
    }
}
