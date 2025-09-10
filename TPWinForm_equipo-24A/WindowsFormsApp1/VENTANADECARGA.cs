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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class frmCarga : Form
    {

        private Articulo articulo = null;
        public frmCarga()
        {
            InitializeComponent();
        }

        public frmCarga(Articulo articulo)
        {
            InitializeComponent();
            this.articulo=articulo;
            Text = "Modificar articulo";
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            MarcaNegocio elementoNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                // Marcas
                cboIdMarca.DataSource = elementoNegocio.Listar();
                cboIdMarca.DisplayMember = "IdMarca";
                cboIdMarca.ValueMember = "IdMarca";

                // Categorias
                cboIdCat.DataSource = categoriaNegocio.Listar();
                cboIdCat.DisplayMember = "IdCategoria";
                cboIdCat.ValueMember = "IdCategoria";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodArticulo;
                    txtNombre.Text = articulo.NombreArticulo;
                    txtDes.Text = articulo.Descripcion;
                    cboIdMarca.SelectedValue = articulo.Marca.IdMarca;
                    cboIdCat.SelectedValue = articulo.Categoria.IdCategoria;

                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                    txtUrlImagen.Text = articulo.Imagen;
                    //txtUrlImagen.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = ((TextBox)sender).Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // Articulo articuloNuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();


                articulo.CodArticulo = txtCodigo.Text;
                articulo.NombreArticulo = txtNombre.Text;
                articulo.Descripcion = txtDes.Text;
                articulo.Marca = (Marca)cboIdMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboIdCat.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagen = txtUrlImagen.Text;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado correctamente");
                }
                else 
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado correctamente");
                }

               
                
                this.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
           
                cargarImagen(txtUrlImagen.Text);

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
