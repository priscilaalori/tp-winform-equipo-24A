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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,  " +
                                      "m.Id AS IdMarca, m.Descripcion AS Marca," +
                                      " c.Id AS IdCategoria, c.Descripcion AS Categoria," +
                                      " a.Precio " +
                                      "FROM ARTICULOS a INNER JOIN MARCAS m ON a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                { 
                    Articulo articulo = new Articulo();
                    articulo.Marca = new Marca();
                    articulo.Categoria = new Categoria();

                    //articulo.Id = lector.GetInt32(0);
                    //articulo.CodArticulo = lector.GetInt32(0);
                    //articulo.NombreArticulo = (string)lector["Nombre"];
                    //articulo.Descripcion = (string)lector["Descripcion"];
                    //articulo.Marca.IdMarca = lector.GetInt32(0);
                    //articulo.Categoria.IdCategoria = lector.GetInt32(0);
                    //articulo.Precio = (decimal)lector["Precio"];

                    articulo.Id = lector.GetInt32(0);
                    articulo.CodArticulo = lector["Codigo"].ToString();
                    articulo.NombreArticulo = lector["Nombre"].ToString();
                    articulo.Descripcion = lector["Descripcion"].ToString();
                    articulo.Marca.IdMarca = (int)lector["IdMarca"];
                    articulo.Marca.Descripcion = lector["Marca"].ToString();
                    articulo.Categoria.IdCategoria = (int)lector["IdCategoria"];
                    articulo.Categoria.Descripcion = lector["Categoria"].ToString();
                    articulo.Precio = (decimal)lector["Precio"];

                    lista.Add(articulo);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
