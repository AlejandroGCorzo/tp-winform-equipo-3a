using System;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Negocio;

namespace TPWinForm_Equipo_3A
{
    public partial class FormCatalogos : Form
    {
        public FormCatalogos()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            CatalogoNegocio negocio = new CatalogoNegocio();

            lstMarcas.DataSource = null;
            lstMarcas.DataSource = negocio.ListarMarcas();

            lstCategorias.DataSource = null;
            lstCategorias.DataSource = negocio.ListarCategorias();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Trim() == "") return;

            new CatalogoNegocio().AgregarMarca(txtMarca.Text.Trim());
            txtMarca.Clear();
            Cargar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Trim() == "") return;

            new CatalogoNegocio().AgregarCategoria(txtCategoria.Text.Trim());
            txtCategoria.Clear();
            Cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}