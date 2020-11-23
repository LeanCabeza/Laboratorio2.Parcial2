using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ConexionBD
    {
        static SqlConnection conexionBD;


        static ConexionBD()
        {
            conexionBD = new SqlConnection("Data Source = DESKTOP-DCNPJDC\\SQLEXPRESS ; Initial Catalog = CasaDeComida;Integrated Security=true");
        }                                                       //("Data Source = DESKTOP-DCNPJDC\\SQLEXPRESS ; Initial Catalog = CasaDeComida;Integrated Security=true");

        // Pasa de string a etipo , por defecto pone indefinido.
        public static ETipo MapeoStringAeTipo (string aux )
        {
            switch (aux)
            {
                case "Comida Rapida":
                    return ETipo.ComidaRapida;
                case "Comida Gurmet":
                    return ETipo.ComidaGurmet;
                case "Postre":
                    return ETipo.Postre;
                default:
                    return ETipo.Indefinido; 
            }
        }

        // El get comidas no se usa , hubo un cambio de planes.
        /// <summary>
        /// Trae la lista de comidas de la base de datos
        /// </summary>
        /// <returns>Retorna la lista de comidas </returns>
        public static List<Comida> GetComidas()
        {
            try
            {
                List<Comida> auxComidas = new List<Comida>();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Comidas.v2";

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }

                SqlDataReader datosDevueltos = comando.ExecuteReader();


                while (datosDevueltos.Read())
                {
                    auxComidas.Add(new Comida(datosDevueltos["NombreComida"].ToString(),
                                                MapeoStringAeTipo(datosDevueltos["TipoComida"].ToString()),
                                                int.Parse(datosDevueltos["Precio"].ToString())));
                }
                return auxComidas;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                conexionBD.Close();
            }

        }

        /// <summary>
        /// Sube comidas a la base de dato
        /// </summary>
        /// <param name="auxComida"></param>
        public static void SubirComida(Comida auxComida)
        {
            try
            {
                List<Comida> auxComidas = new List<Comida>();
                SqlCommand comando = new SqlCommand();

                // LA CONSULTA QUE ES ENVIADA A LA BASE DE DATOS
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[Comidas.v2] VALUES (@nombre,@tipo,@precio) ";

                // PARA EVITAR LA INYECCION DE INFORMACION 

                comando.Parameters.Add(new SqlParameter("@nombre", auxComida.NombreComida));
                comando.Parameters.Add(new SqlParameter("@tipo", auxComida.TipoComida));
                comando.Parameters.Add(new SqlParameter("@precio", auxComida.Precio));

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }

                comando.ExecuteNonQuery();

            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                conexionBD.Close();
            }

        }


        /// Esto servia para buscar por id una comidad y actualizarle algun campo. Funciona pero al final no la use.

        /*public static void ActualizarEstado(Comida auxComida)
        {
            try
            {
                List<Comida> auxComidas = new List<Comida>();
                SqlCommand comando = new SqlCommand();

                // LA CONSULTA QUE ES ENVIADA A LA BASE DE DATOS
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE [dbo].[Comidas] SET Estado = 'Entregado' WHERE IdComida=@id ";



                  // PARA EVITAR LA INYECCION DE INFORMACION 

                comando.Parameters.Add(new SqlParameter("@id", auxComida.IdComida));
          

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }

                comando.ExecuteNonQuery();

            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                conexionBD.Close();
            }

        }*/


    }

}