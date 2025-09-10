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
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoriaSeleccionada)
        {
            InitializeComponent();
            this.categoria = categoriaSeleccionada;
            Text = "Modificar categoría";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                categoria.Descripcion = txtDescripcion.Text;
                catNegocio.Agregar(categoria);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            
            else if (categoria != null)
            {
       
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                categoria.Descripcion = txtDescripcion.Text;
                catNegocio.Modificar(categoria);

                MessageBox.Show("Modificado exitosamente");
                Close();
            }
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
       
            if(categoria != null)
                txtDescripcion.Text = categoria.Descripcion;
                
        
        }

        private void frmListaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
