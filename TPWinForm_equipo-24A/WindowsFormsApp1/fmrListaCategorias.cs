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
    public partial class fmrListaCategorias : Form
    {
        public fmrListaCategorias()
        {
            InitializeComponent();
        }

        private void fmrListaCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategoria.DataSource = negocio.Listar();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
