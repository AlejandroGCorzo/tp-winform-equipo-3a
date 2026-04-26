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

            Cargar();
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

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            FormAltaArticulo ventana = new FormAltaArticulo();
            ventana.ShowDialog();
            Cargar();
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            var listaFiltrada = listaArticulos
                .Where(x =>
                    x.Nombre.ToLower().Contains(filtro) ||
                    x.Codigo.ToLower().Contains(filtro) ||
                    x.Marca.Nombre.ToLower().Contains(filtro))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["ImagenUrl"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Image = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}