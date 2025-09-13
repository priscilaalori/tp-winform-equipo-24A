using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VerDetalle : Form
    {
        private Articulo articulo = null;
        public VerDetalle()
        {
            InitializeComponent();
        }
        public VerDetalle( Articulo articulo)
        {
            
            InitializeComponent();
            this.articulo = articulo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerDetalle_Load(object sender, EventArgs e)
        {
            labelCodigo.Text = articulo.CodArticulo;
            labelNombre.Text = articulo.NombreArticulo;
            labelDetalle.Text = articulo.Descripcion;
            labelMarca.Text = articulo.Marca.Descripcion;
            labelPrecio.Text = articulo.Precio.ToString();
            labelCategoria.Text = articulo.Categoria.Descripcion;
            try
            {
                pictureBox.Load(articulo.Imagen);
            }
            catch (Exception ex)
            {

                pictureBox.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
            }

        }
    }
}
