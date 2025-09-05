using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }
        public decimal Precio {  get; set; }
        public string Descripcion { get; set; } 

        public string Imagen {  get; set; }

        public string PrecioFormateado
        {
            get { return Precio.ToString("N2"); }
        }

        public string NombreMarca
        {
            get { return Marca != null ? Marca.NombreMarca : ""; }
        }

        public string NombreCategoria
        {
            get { return Categoria != null ? Categoria.Descripcion : ""; }
        }


    }
}
