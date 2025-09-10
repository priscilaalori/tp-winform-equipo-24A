using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public  class Marca
    {
        public static object descripcion { get; set; }
        public int IdMarca { get; set; }

        [DisplayName( "Descripción")]
        public string Descripcion { get; set; }

    }
}
