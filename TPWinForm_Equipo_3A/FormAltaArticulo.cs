using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Dominio;
using TPWinForm_Equipo_3A.Negocio;

namespace TPWinForm_Equipo_3A
{
    public partial class FormAltaArticulo : Form
    {
        private List<string> imagenes = new();
        private Articulo articulo = null;

        public FormAltaArticulo()
        {
            InitializeComponent();
            CargarCombos();
        }

        public FormAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            CargarCombos();

            this.articulo = articulo;
            Text = "Modificar Artículo";

            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            txtImagen.Text = articulo.ImagenUrl;

            cboMarca.SelectedItem = articulo.Marca.Nombre;
            cboCategoria.SelectedItem = articulo.Categoria.Nombre;

            imagenes.Add(articulo.ImagenUrl);
            lstImagenes.DataSource = imagenes;
        }

        private void CargarCombos()
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Xiaomi");
            cboMarca.Items.Add("Nike");
            cboMarca.Items.Add("Adidas");
            cboMarca.Items.Add("Puma");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Calzado");

            cboMarca.SelectedIndex = 0;
            cboCategoria.SelectedIndex = 0;
        }

        private void btnAgregarImagen_Click(object? sender, EventArgs e)
        {
            if (txtImagen.Text.Trim() == "") return;

            imagenes.Add(txtImagen.Text.Trim());

            lstImagenes.DataSource = null;
            lstImagenes.DataSource = imagenes;

            txtImagen.Clear();
        }

        private void btnQuitarImagen_Click(object? sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem == null) return;

            imagenes.Remove(lstImagenes.SelectedItem.ToString());

            lstImagenes.DataSource = null;
            lstImagenes.DataSource = imagenes;
        }

        private void btnAceptar_Click(object? sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (articulo == null)
            {
                negocio.Agregar(
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    decimal.Parse(txtPrecio.Text),
                    cboMarca.Text,
                    cboCategoria.Text,
                    imagenes);
            }
            else
            {
                negocio.Modificar(
                    articulo.Id,
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    decimal.Parse(txtPrecio.Text),
                    cboMarca.Text,
                    cboCategoria.Text,
                    imagenes);
            }

            Close();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}