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

        #region Constructor 

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Comida()
        {
                
        }

        /// <summary>
        /// Constructor de Comida.
        /// </summary>
        /// <param name="nombreComida">nombre</param>
        /// <param name="tipoComida">tipo</param>
        /// <param name="precio">precio</param>
        public Comida(string nombreComida, ETipo tipoComida, int precio)
        {
            this.nombreComida = nombreComida;
            this.tipoComida = tipoComida;
            this.precio = precio;
        }

        #endregion
        // Propiedades 
        #region Propiedades

        /// <summary>
        /// Get y set de nombre
        /// </summary>
        public string NombreComida
        {
            get { return nombreComida; }
            set { this.nombreComida = value; }
        }
        /// <summary>
        /// Get y set de precio
        /// </summary>
        public int Precio
        {
            get { return precio; }
            set { this.precio = value; }
        }

        /// <summary>
        /// Get parseado a string del tipo de comida
        /// </summary>
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
        #endregion
    }
}
