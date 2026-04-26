using System;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Dominio;

namespace TPWinForm_Equipo_3A
{
    public partial class FormDetalleArticulo : Form
    {
        public FormDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();

            lblCodigo.Text = "Código: " + articulo.Codigo;
            lblNombre.Text = "Nombre: " + articulo.Nombre;
            lblDescripcion.Text = "Descripción: " + articulo.Descripcion;
            lblMarca.Text = "Marca: " + articulo.Marca.Nombre;
            lblCategoria.Text = "Categoría: " + articulo.Categoria.Nombre;
            lblPrecio.Text = "Precio: $" + articulo.Precio;

            try
            {
                pbxDetalle.Load(articulo.ImagenUrl);
            }
            catch
            {
                pbxDetalle.Image = null;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}