using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            ArticuloNegocio listaArticulos = new ArticuloNegocio();
            dgvArt.DataSource = listaArticulos.listarArticulos();
            // Oculto el Precio "real"
            dgvArt.Columns["Precio"].Visible = false;
            // Renombro la cabecera de PrecioFormateado
            dgvArt.Columns["PrecioFormateado"].HeaderText = "Precio";
            // Oculto el Marca que queda feo
            dgvArt.Columns["Marca"].Visible = false;

        }

        private void frmLista_warning(object sender, EventArgs e)
        {
            ArticuloNegocio listaArticulos = new ArticuloNegocio();
            var lista = listaArticulos.listarArticulos();

            MessageBox.Show("Se encontraron " + lista.Count + " artículos.");

            dgvArt.DataSource = lista;
        }

        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
