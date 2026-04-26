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
        private List<Articulo> listaArticulos = new List<Articulo>();

        public Form1()
        {
            InitializeComponent();

            Text = "Gestión de Artículos";
            StartPosition = FormStartPosition.CenterScreen;

            txtBuscar.TextChanged += txtBuscar_TextChanged;

            Cargar();
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaArticulos;

                ConfigurarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ConfigurarGrilla()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["ImagenUrl"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            List<Articulo> listaFiltrada;

            if (filtro == "")
            {
                listaFiltrada = listaArticulos;
            }
            else
            {
                listaFiltrada = listaArticulos
                    .Where(x =>
                        x.Nombre.ToLower().Contains(filtro) ||
                        x.Codigo.ToLower().Contains(filtro) ||
                        x.Marca.Nombre.ToLower().Contains(filtro) ||
                        x.Categoria.Nombre.ToLower().Contains(filtro))
                    .ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;

            ConfigurarGrilla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}