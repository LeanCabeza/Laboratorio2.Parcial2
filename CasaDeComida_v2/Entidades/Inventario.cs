using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public static class Inventario
    {
        static Queue<Comida> cocinandose;
        static Queue<Comida> preparado;

       
         static Inventario()
        {
            cocinandose = new Queue<Comida>();
            preparado = new Queue<Comida>();
        }

        public static Queue<Comida> Cocinandose
        {
            get { return cocinandose; }
        }

        public static Queue<Comida> Preparado
        {
            get { return preparado; }
        }



        /// <summary>
        /// Carga las comidas que estan guardadas en el xml
        /// </summary>
        /// <returns></returns>
        /// 
        public static bool CargarComidasDelXml()
        {
 
            List<Comida> listaAux = new List<Comida>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidos.xml");

            Xml<List<Comida>> auxPedidos = new Xml<List<Comida>>();

            if(auxPedidos.Leer(path,out listaAux))
            {
                ///Si entro hasta aca es porque se pudo leer bien el xml ,ahi carga en la cola la lista de comidas en la cola.
                foreach (Comida c in listaAux)
                {
                    cocinandose.Enqueue(c);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
         * 
         * SERIALIZO PEDIDOS PARA GENERAR EL XML QUE DESPUES VOY A CARGAR :D 
         * 
                public static bool SerializarPedidos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidos.xml");
                    Xml<List<Comida>> auxPedidos = new Xml<List<Comida>>();

                    List<Comida> pedidos = new List<Comida>();

                    pedidos.Add(new Comida("Papa Frita", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Hamburgueza", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Empanada", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Pizza", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Panchito", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Fideos blancos con queso", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Bondiola", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Choripan", ETipo.ComidaRapida, 250));
                    pedidos.Add(new Comida("Choripan", ETipo.ComidaRapida, 250));

                    return auxPedidos.Guardar(path, pedidos);
                }
        */
    }
}
