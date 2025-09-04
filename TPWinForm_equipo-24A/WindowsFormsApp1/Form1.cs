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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            string nombre = txtArticulo.Text;
            string marca = txtMarca.Text;
            string categoria = txtCategoria.Text;
            string precio = txtPrecio.Text;
            string descripcion = txtDescripcion.Text;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = ((TextBox)sender).Text;
        }
    }
}
