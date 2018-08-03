using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockManager
    {
        /*
        CualquieraDBEntities contexto;
        public StockManager()
        {
            contexto = new Entidades.CualquieraDBEntities();
        }

        public void AgregarStock(Stock stock)
        {
            // aca se sube un articulo a la base de datos
            contexto.Articulos.Add(stock);
            contexto.SaveChanges();
            Console.WriteLine("stock " + stock.IDArt + " dado de alta");
        }

        public void BajaStock(int stockId)
        {
            List<Stock> stocks = contexto.Stocks.ToList();
            for (int i = 0; i < stocks.Count(); i++)
            {
                if (stocks[i].IDArt == stockId)
                {
                    contexto.Stocks.Remove(stocks[i]);
                    Console.WriteLine("Stock" + stocks[i] + "dado de baja");
                    break;
                }
            }
            
        }

        public void EditarStock(int idStock)
        {

        }

        public List<Stock> BuscarStock()
        {
            return contexto.Stocks.toList();
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
        }
        */
    }
}
