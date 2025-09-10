using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmListaMarcas : Form
    { 
        public frmListaMarcas()
        {
            InitializeComponent();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaMarcas_Load(object sender, EventArgs e)
        {
            cargar();                     
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.Listar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca frmAgregarMarca = new frmAgregarMarca();
            frmAgregarMarca.ShowDialog();
            cargar();
        }
       

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            frmAgregarMarca frmModificar = new frmAgregarMarca(seleccionado);
            frmModificar.ShowDialog();
            cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                { 
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdMarca);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }
    }
}
