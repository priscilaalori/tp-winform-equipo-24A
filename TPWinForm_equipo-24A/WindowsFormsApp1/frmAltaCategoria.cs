using Dominio;
using Negocio;
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
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria(); 
            CategoriaNegocio catNegocio = new CategoriaNegocio();

            nuevaCategoria.Descripcion = txtDescripcion.Text;
            catNegocio.Agregar(nuevaCategoria);

            MessageBox.Show("Agregado exitosamente");
            Close();
        }

        private void frmListaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
