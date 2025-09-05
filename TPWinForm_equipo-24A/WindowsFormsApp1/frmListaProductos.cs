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
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            Metodos listaArticulos = new Metodos();
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
            Metodos listaArticulos = new Metodos();
            var lista = listaArticulos.listarArticulos();

            MessageBox.Show("Se encontraron " + lista.Count + " artículos.");

            dgvArt.DataSource = lista;
        }
    }
}
