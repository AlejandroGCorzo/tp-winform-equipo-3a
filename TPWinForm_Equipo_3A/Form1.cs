```
using System;
using System.Windows.Forms;
using TPWinForm_Equipo_3A.Negocio;

namespace TPWinForm_Equipo_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Gestión de Artículos";
            StartPosition = FormStartPosition.CenterScreen;

            Cargar();
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                dataGridView1.DataSource = negocio.listar();

                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["ImagenUrl"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
```