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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarcaNegocio elementoNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                // Marcas
                cboIdMarca.DataSource = elementoNegocio.Listar();
                cboIdMarca.DisplayMember = "IdMarca"; 

                // Categorias
                cboIdCat.DataSource = categoriaNegocio.Listar();
                cboIdCat.DisplayMember = "IdCategoria";   

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = ((TextBox)sender).Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try 
            {

                articuloNuevo.CodArticulo = txtCodigo.Text;
                articuloNuevo.NombreArticulo = txtNombre.Text;
                articuloNuevo.Descripcion  = txtDes.Text;
                articuloNuevo.Marca = (Marca)cboIdMarca.SelectedItem;
                articuloNuevo.Categoria = (Categoria)cboIdCat.SelectedValue;
                articuloNuevo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(articuloNuevo);
                MessageBox.Show("Agregado correctamente");
                this.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
