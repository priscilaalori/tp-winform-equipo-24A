using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Articulo
    {
        public int CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }
        public float Precio {  get; set; }
        public string Descripcion { get; set; } 


    }
}
