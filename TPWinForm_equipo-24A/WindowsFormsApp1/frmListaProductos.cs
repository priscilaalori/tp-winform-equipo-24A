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
                ocultarColumnas();
                cargarImagen(articulos[0].Imagen);
                

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumnas()
        {
            dgvArt.Columns["Id"].Visible = false;
            // Oculto el Precio "real"
            dgvArt.Columns["Precio"].Visible = false;
            // Renombro la cabecera de PrecioFormateado
            dgvArt.Columns["PrecioFormateado"].HeaderText = "Precio";
            // Oculto el Marca que queda feo
            dgvArt.Columns["Marca"].Visible = false;
            dgvArt.Columns["Imagen"].Visible = false;
            dgvArt.Columns["Categoria"].Visible = false;

        }



        private void agregarArt_Click(object sender, EventArgs e)
        {
            frmCarga altaArticulo = new frmCarga();
            altaArticulo.ShowDialog();
            cargar();
        }

        private void dgvArt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArt.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo) dgvArt.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArt.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                
                frmCarga modificar = new frmCarga(seleccionado);
                modificar.ShowDialog();
                cargar();
                
                if (dgvArt.Rows.Count > 0)
                    dgvArt.Rows[0].Selected = true;

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArt.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Estas seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes) 
                    {
                        seleccionado = (Articulo)dgvArt.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();

                        if (dgvArt.Rows.Count > 0)
                            dgvArt.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Articulo> articulosFiltrados;
            string filtro = txtFiltro.Text;

            if (filtro != "")
                articulosFiltrados = articulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Precio.ToString().Contains(filtro) || x.IdMarca.ToString().Contains(filtro)
                || x.IdCategoria.ToString().Contains(filtro) );
            else
                articulosFiltrados = articulos;



            dgvArt.DataSource = null;
            dgvArt.DataSource = articulosFiltrados;
            ocultarColumnas();

            if (articulosFiltrados.Count > 0)
                dgvArt.Rows[0].Selected = true;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> articulosFiltrados;
            string filtro = txtFiltro.Text;

            if (filtro != "")
                articulosFiltrados = articulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Precio.ToString().Contains(filtro) || x.IdMarca.ToString().Contains(filtro)
                || x.IdCategoria.ToString().Contains(filtro));
            else
                articulosFiltrados = articulos;



            dgvArt.DataSource = null;
            dgvArt.DataSource = articulosFiltrados;
            ocultarColumnas();

            if (articulosFiltrados.Count > 0)
                dgvArt.Rows[0].Selected = true;

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> articulosFiltrados;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
                articulosFiltrados = articulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodArticulo.ToUpper().Contains(filtro.ToUpper()) ||
                x.Precio.ToString().Contains(filtro) || x.IdMarca.ToString().Contains(filtro)
                || x.IdCategoria.ToString().Contains(filtro));
            else
                articulosFiltrados = articulos;



            dgvArt.DataSource = null;
            dgvArt.DataSource = articulosFiltrados;
            ocultarColumnas();

            if (articulosFiltrados.Count > 0)
                dgvArt.Rows[0].Selected = true;

        }
    }
}
