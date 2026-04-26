using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Dominio;
using TPWinForm_Equipo_3A.Negocio;

namespace TPWinForm_Equipo_3A
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos = new();

        public Form1()
        {
            InitializeComponent();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCatalogos.Click += btnCatalogos_Click;

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            Cargar();
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            new FormCatalogos().ShowDialog();
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            listaArticulos = negocio.listar();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaArticulos;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["ImagenUrl"].Visible = false;

            if (listaArticulos.Count > 0)
                CargarImagen(listaArticulos[0].ImagenUrl);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FormAltaArticulo().ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Articulo art =
                (Articulo)dataGridView1.CurrentRow.DataBoundItem;

            new FormAltaArticulo(art).ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Articulo art =
                (Articulo)dataGridView1.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                "¿Eliminar artículo?",
                "Eliminar",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                new ArticuloNegocio().Eliminar(art.Id);
                Cargar();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Articulo art =
                (Articulo)dataGridView1.CurrentRow.DataBoundItem;

            new FormDetalleArticulo(art).ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            var lista = listaArticulos
                .Where(x =>
                    x.Nombre.ToLower().Contains(filtro) ||
                    x.Codigo.ToLower().Contains(filtro) ||
                    x.Marca.Nombre.ToLower().Contains(filtro))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["ImagenUrl"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Articulo art =
                (Articulo)dataGridView1.CurrentRow.DataBoundItem;

            CargarImagen(art.ImagenUrl);
        }

        private void CargarImagen(string url)
        {
            try { pbxArticulo.Load(url); }
            catch { pbxArticulo.Image = null; }
        }
    }
}