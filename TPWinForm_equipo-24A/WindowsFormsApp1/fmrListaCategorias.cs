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
            dgvCategoria.DataSource = negocio.Listar();
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
                catSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                catNegocio.Eliminar(catSeleccionada.IdCategoria);
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
                
          
            }
        }
    }
}
