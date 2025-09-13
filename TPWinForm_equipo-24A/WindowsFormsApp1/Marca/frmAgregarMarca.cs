using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAgregarMarca : Form
    {

        private Marca marca = null;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(Marca marcaNueva)

        {
            InitializeComponent();
            Text = "Modificar Marca";
            this.marca = marcaNueva;
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
            // Marca nuevaMarca = new Marca(); 
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (textMarca.Text.Length > 0)
                {
                    if (marca == null)
                    {
                        marca = new Marca();
                    }
                    marca.Descripcion = textMarca.Text;

                    if (marca.IdMarca != 0)
                    {
                        negocio.modificar(marca);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        negocio.agregar(marca);
                        MessageBox.Show("Marca Agregada");
                    }

                    Close();
                }
                else { MessageBox.Show("No es posible agregar marca vacia"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                textMarca.Text = marca.Descripcion;
            }
        }
    }
}
