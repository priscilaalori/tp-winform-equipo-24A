using Dominio;
using Negocio;
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
    public partial class frmListaProductos : Form
    {
        private List<Articulo> articulos;
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {

            cargar();

        }

        private void cargar()
        {
            ArticuloNegocio listaArticulos = new ArticuloNegocio();
            try
            {
               

                articulos = listaArticulos.listarArticulos();
                dgvArt.DataSource = articulos;
                cargarImagen(articulos[0].Imagen);
                // Oculto el Precio "real"
                dgvArt.Columns["Precio"].Visible = false;
                // Renombro la cabecera de PrecioFormateado
                dgvArt.Columns["PrecioFormateado"].HeaderText = "Precio";
                // Oculto el Marca que queda feo
                dgvArt.Columns["Marca"].Visible = false;
                dgvArt.Columns["Imagen"].Visible = false;
                dgvArt.Columns["Categoria"].Visible = false;

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void agregarArt_Click(object sender, EventArgs e)
        {
            frmCarga altaArticulo = new frmCarga();
            altaArticulo.ShowDialog();
            cargar();
        }

        private void dgvArt_SelectionChanged(object sender, EventArgs e)
        {
           Articulo seleccionado = (Articulo) dgvArt.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pictureBoxArt.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxArt.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
            }
            
        }
    }
}
