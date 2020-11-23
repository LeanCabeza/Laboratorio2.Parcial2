using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        /*
         * 
         * SERIALIZO PEDIDOS POR SIMPLE GUSTO , PARA TENER ALGO QUE CARGAR AL PRINCIPIO CUANDO ARRANQUE EL PROGRAMA 
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

        public static bool CargarComidasDelXml()
        {

            List<Comida> listaAux = new List<Comida>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidos.xml");

            Xml<List<Comida>> auxPedidos = new Xml<List<Comida>>();

            auxPedidos.Leer(path,out listaAux);

            foreach (Comida c in listaAux)
            {
                cocinandose.Enqueue(c);
            }

            return true;


            //List<Comida> listaAux = new List<Comida>();
            /* 
             * Harcodeando datos datos a modo prueba 
             * 
             * 
             * listaAux.Add(new Comida("Papa Frita",ETipo.ComidaRapida,250));
             listaAux.Add(new Comida("Papa Con Cheddar", ETipo.ComidaRapida, 250));
             listaAux.Add(new Comida("Pizza", ETipo.ComidaRapida, 250));
             listaAux.Add(new Comida("Fideo moñito", ETipo.ComidaRapida, 250));
             listaAux.Add(new Comida("Hamburguesa", ETipo.ComidaRapida, 250));*/

        }
    }
}
