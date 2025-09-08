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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From Categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria catAuxiliar = new Categoria();
                    catAuxiliar.IdCategoria = (int)datos.Lector["Id"];
                    catAuxiliar.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategorias.Add(catAuxiliar);

                }

                return listaCategorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Agregar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("insert into Categorias (Descripcion) values ('" + categoria.Descripcion +"')");
            datos.ejecutarAccion();
        }
    }
}
