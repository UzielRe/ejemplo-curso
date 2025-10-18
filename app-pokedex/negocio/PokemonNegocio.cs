using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {

            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB;integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero,Nombre,e.Descripcion, UrlImagen, e.Descripcion tipo, d.Descripcion debilidad from POKEMONS p, ELEMENTOS e ,ELEMENTOS d where e.Id = p.IdTipo and d.Id = p.IdDebilidad\r\n";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();  
                    aux.numero = lector.GetInt32(0);
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.urlimagen = (string)lector["Urlimagen"];
                    aux.tipo = new Elemento();
                    aux.tipo.descripcion = (string)lector["tipo"];
                    aux.debilidad = new Elemento();
                    aux.debilidad.descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);
                }
                conexion.Close();


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        public void agregar (Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS(numero, Nombre, Descripcion, Activo) values(" + nuevo.numero + ", '" + nuevo.nombre + "', '" + nuevo.descripcion + "', 1)");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar (Pokemon modificar) { }

    }
}
       

