using Dominio;
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
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = ((TextBox)sender).Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            articuloNuevo.NombreArticulo = txtArticulo.Text;
           // string marca = txtMarca.Text;
            //string categoria = txtCategoria.Text;
            articuloNuevo.Precio = decimal.Parse(txtPrecio.Text);
            articuloNuevo.Descripcion = txtDescripcion.Text;

            
        }
    }
}
