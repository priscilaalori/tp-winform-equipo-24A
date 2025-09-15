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
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FrmImagenes : Form
    {
        private int IdProducto {  get; set; }
        public FrmImagenes(int id)
        {
            IdProducto = id;
            InitializeComponent();
        }

        private void FrmImagenes_Load(object sender, EventArgs e)
        {
            cargar();

        }
        private void cargar()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();


            List<Imagen> imagenes = imagenNegocio.listar(IdProducto);

            dvgImagen.DataSource = imagenes;

            if (imagenes.Count > 0)
            {
                cargarImagen(imagenes[0].UTlImagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                picImagen.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtURL.Text != "")
            {
                Imagen imagen = new Imagen();
                ImagenNegocio negImg = new ImagenNegocio();

                imagen.NumeroArticulo = IdProducto;
                imagen.UTlImagen = txtURL.Text;
                negImg.Agregar(imagen);
                cargar();
                MessageBox.Show("Agregado exitosamente");
            }
            else
            {
                MessageBox.Show("Ingrese URL");
                return;
            }
            
        }

        private void dvgImagen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgImagen_SelectionChanged(object sender, EventArgs e)
        {
            Imagen imagen = dvgImagen.CurrentRow.DataBoundItem as Imagen;
            cargarImagen(imagen.UTlImagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negImg = new ImagenNegocio();
            
            DialogResult respuesta = MessageBox.Show("¿Realmente desea eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Imagen imagen = dvgImagen.CurrentRow.DataBoundItem as Imagen;
                negImg.Eliminar(imagen.IDimagen);
                cargar();
            }
        }
    }

}
