using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum ETipo
    {
        Indefinido,
        ComidaRapida,
        ComidaGurmet,
        Postre
    }


    public class Comida 
    {
        
        string nombreComida;
        ETipo tipoComida;
        int precio;


        //CONSTRUCTOR

        public Comida()
        {
                
        }

        public Comida(string nombreComida, ETipo tipoComida, int precio)
        {
            this.nombreComida = nombreComida;
            this.tipoComida = tipoComida;
            this.precio = precio;
        }


        // Propiedades 


        public string NombreComida
        {
            get { return nombreComida; }
            set { this.nombreComida = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { this.precio = value; }
        }

        public string TipoComida
        {
            get 
            {
                switch (tipoComida)
                {
                    case ETipo.ComidaRapida:
                        return "Comida Rapida";
                    case ETipo.ComidaGurmet:
                        return "Comida Gurmet";
                    case ETipo.Postre:
                        return "Postre";
                    default:
                        return "Indefinido"; 
                }
            }
        }

    }
}
