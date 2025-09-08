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
    public partial class FmrInicio : Form
    {
        public FmrInicio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaProductos frmListaProductos = new frmListaProductos(); 
            frmListaProductos.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            fmrListaCategorias fmrListaCategorias = new fmrListaCategorias();
            fmrListaCategorias.ShowDialog();
        }

        private void FmrInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmListaMarcas frmListaMarcas = new frmListaMarcas(); 
            frmListaMarcas.ShowDialog();
        }
    }
}
