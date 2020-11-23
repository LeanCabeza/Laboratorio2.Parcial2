using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar( Comida obj)
        {
            if (obj != null)
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + @"\" + "Ventas" + ".txt", true);
                using (streamWriter)
                {
                    streamWriter.Write(string.Format("\n -------------------------------------\n"
                                                    + DateTime.Now.ToString() 
                                                    + "\n El pedido fue de : " + obj.NombreComida.ToString() + "\n Tipo : " + obj.TipoComida.ToString() 
                                                    + "\n Precio $" + obj.Precio.ToString()));
                }
                return true;
            }
            else
            {
                return false;
            }
       
        }

    }
}
