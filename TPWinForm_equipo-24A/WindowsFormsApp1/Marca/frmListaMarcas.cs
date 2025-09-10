using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmListaMarcas : Form
    {
        List<Marca> listaMarcas = new List<Marca>();

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
            listaMarcas = negocio.Listar();
            dgvMarcas.DataSource = listaMarcas;
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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = textFiltro.Text;

            if (filtro != "")
            {

            listaFiltrada = listaMarcas.FindAll(m => m.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            } else
            {
                listaFiltrada = listaMarcas; 
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltrada; 
        }
    }
}
