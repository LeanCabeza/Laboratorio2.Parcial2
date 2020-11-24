using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// Cuenta el total del dinero acumulado 
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="tipo"></param>
        /// <returns>la cantidad de pedidos consultada</returns>
        public static int PrecioTotal(this Queue<Comida> pedidos,string totalStr, int total)
        {
            foreach (Comida item in pedidos)
            {
                total = item.Precio + total;
                
            }

            totalStr = total.ToString();

            return total ;
        }

    }
}
