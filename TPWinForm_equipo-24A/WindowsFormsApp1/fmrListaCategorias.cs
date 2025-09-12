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
using Negocio;
namespace WindowsFormsApp1
{
    public partial class fmrListaCategorias : Form
    {
        private List<Categoria> listaCategorias;
        public fmrListaCategorias()
        {
            InitializeComponent();
        }
        private void fmrListaCategorias_Load(object sender, EventArgs e)
        {
            //CategoriaNegocio negocio = new CategoriaNegocio();
            //dgvCategoria.DataSource = negocio.Listar();
            cargar();

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.Listar();
            dgvCategoria.DataSource = listaCategorias;
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAltaCategoria frmAlta = new frmAltaCategoria();
            frmAlta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;

            seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            frmAltaCategoria frmModificar = new frmAltaCategoria(seleccionado);
            frmModificar.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            Categoria catSeleccionada = new Categoria();
            try
            {
                DialogResult respuesta= MessageBox.Show("¿Realmente desea eliminarlo?", "Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    catSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    catNegocio.Eliminar(catSeleccionada.IdCategoria);
                    cargar();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
      
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaCategoriaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {

                listaCategoriaFiltrada = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));

            }
            else
            {
                listaCategoriaFiltrada = listaCategorias;
            }
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = listaCategoriaFiltrada;
        }
    }
}
