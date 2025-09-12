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

        private bool validarRequerido(string texto)
        {
            if(texto == "")
            {
                return false;
            }
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                categoria.Descripcion = txtDescripcion.Text;

                if(validarRequerido(categoria.Descripcion)== true)
                {
                    catNegocio.Agregar(categoria);
                    MessageBox.Show("Agregado exitosamente");
                    Close();
                }
                else { MessageBox.Show("Ingrese descripción");
                    return;
                }
               
            }
            
            else if (categoria != null)
            {
       
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                categoria.Descripcion = txtDescripcion.Text;
                
                if(validarRequerido(categoria.Descripcion) == true)
                {
                    catNegocio.Modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                }
                else {
                    MessageBox.Show("Ingrese una nueva descripción");
                        return; }
             
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
