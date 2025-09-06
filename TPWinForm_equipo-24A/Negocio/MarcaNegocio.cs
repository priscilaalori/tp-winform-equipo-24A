using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            AccesoDatos datos = new AccesoDatos();  

            try
            {
                datos.setearConsulta( "Select Id, Descripcion From Marcas");
                datos.ejecutarLecura();


                while (datos.Lector.Read())
                {
                    Marca marcaAuxiliar = new Marca();
                    marcaAuxiliar.IdMarca = (int)datos.Lector["Id"];
                    marcaAuxiliar.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(marcaAuxiliar);
                }

               
                return listaMarcas;
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

        public void agregar (Marca nuevaMarca)  
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES ('" + nuevaMarca.Descripcion + "')");
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
