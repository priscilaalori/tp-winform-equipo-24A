using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void labelAgregarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {   
            Marca nuevaMarca = new Marca(); 
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nuevaMarca.Descripcion = textMarca.Text;
                negocio.agregar(nuevaMarca);
                MessageBox.Show("Marca Agregada");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
