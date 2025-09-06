using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database= CATALOGO_P3_DB; integrated security = true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion From Marcas";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca marcaAuxiliar = new Marca();
                    marcaAuxiliar.IdMarca = (int)lector["Id"];
                    marcaAuxiliar.Descripcion = (string)lector["Descripcion"];

                    listaMarcas.Add(marcaAuxiliar);
                }

                conexion.Close();
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
