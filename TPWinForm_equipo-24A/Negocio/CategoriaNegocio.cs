using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio

{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database= CATALOGO_P3_DB; integrated security = true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion From Categorias";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                
                while(lector.Read())
                {
                    Categoria catAuxiliar = new Categoria();
                    catAuxiliar.IdCategoria = (int)lector["Id"];
                    catAuxiliar.Descripcion = (string)lector["Descripcion"];

                    listaCategorias.Add(catAuxiliar);

                }
                conexion.Close(); 
                return listaCategorias;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

    }
}
