using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        { 
            List<Articulo> lista = new List<Articulo>();
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;

            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.setearConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,  " +
                                      "m.Id AS IdMarca, m.Descripcion AS Marca," +
                                      " c.Id AS IdCategoria, c.Descripcion AS Categoria," +
                                      " a.Precio " +
                                      "FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id");

                datos.ejecutarLectura();

                while (datos.Lector.Read()) 
                { 
                    Articulo articulo = new Articulo();
                    articulo.Marca = new Marca();
                    articulo.Categoria = new Categoria();

                    articulo.Id = datos.Lector.GetInt32(0);
                    articulo.CodArticulo = datos.Lector["Codigo"].ToString();
                    articulo.NombreArticulo = datos.Lector["Nombre"].ToString();
                    articulo.Descripcion = datos.Lector["Descripcion"].ToString();
                    articulo.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = datos.Lector["Marca"].ToString();
                    
                    articulo.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = datos.Lector["Categoria"].ToString();
                    articulo.Precio = Convert.ToDecimal(datos.Lector["Precio"]);

                    lista.Add(articulo);

                }

                
                return lista;
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
        public void agregar (Articulo nuevo) 
        {
            AccesoDatos datos = new AccesoDatos();

            try 
            {
                datos.setearConsulta("insert into Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + nuevo.CodArticulo + "', '"+nuevo.NombreArticulo+"', '"+nuevo.Descripcion+"', "+nuevo.Marca.IdMarca+ ", "+nuevo.Categoria.IdCategoria+", "+nuevo.Precio+")");
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
}
}
