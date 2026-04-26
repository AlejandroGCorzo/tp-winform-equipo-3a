using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Dominio;
using TPWinForm_Equipo_3A.Negocio;

namespace TPWinForm_Equipo_3A
{
    public partial class FormDetalleArticulo : Form
    {
        private List<string> imagenes = new();
        private int indice = 0;

        public FormDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();

            lblCodigo.Text = "Código: " + articulo.Codigo;
            lblNombre.Text = "Nombre: " + articulo.Nombre;
            lblDescripcion.Text = "Descripción: " + articulo.Descripcion;
            lblMarca.Text = "Marca: " + articulo.Marca.Nombre;
            lblCategoria.Text = "Categoría: " + articulo.Categoria.Nombre;
            lblPrecio.Text = "Precio: $" + articulo.Precio;

            ArticuloNegocio negocio = new ArticuloNegocio();
            imagenes = negocio.ListarImagenes(articulo.Id);

            MostrarImagen();
        }

        private void MostrarImagen()
        {
            if (imagenes.Count == 0)
            {
                pbxDetalle.Image = null;
                return;
            }

            try
            {
                pbxDetalle.Load(imagenes[indice]);
            }
            catch
            {
                pbxDetalle.Image = null;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indice--;

            if (indice < 0)
                indice = imagenes.Count - 1;

            MostrarImagen();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indice++;

            if (indice >= imagenes.Count)
                indice = 0;

            MostrarImagen();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}