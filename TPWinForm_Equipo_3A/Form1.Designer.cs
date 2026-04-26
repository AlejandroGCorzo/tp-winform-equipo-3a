namespace TPWinForm_Equipo_3A
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCatalogos;
        private PictureBox pbxArticulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCatalogos = new Button();
            pbxArticulo = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulo).BeginInit();
            SuspendLayout();

            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Size = new Size(260, 23);

            btnAgregar.Location = new Point(290, 10);
            btnAgregar.Size = new Size(90, 27);
            btnAgregar.Text = "Agregar";

            btnModificar.Location = new Point(390, 10);
            btnModificar.Size = new Size(90, 27);
            btnModificar.Text = "Modificar";

            btnEliminar.Location = new Point(490, 10);
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.Text = "Eliminar";

            btnCatalogos.Location = new Point(590, 10);
            btnCatalogos.Size = new Size(110, 27);
            btnCatalogos.Text = "Catálogos";

            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Size = new Size(700, 500);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            pbxArticulo.Location = new Point(730, 50);
            pbxArticulo.Size = new Size(240, 240);
            pbxArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxArticulo.BorderStyle = BorderStyle.FixedSingle;

            ClientSize = new Size(984, 561);

            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCatalogos);
            Controls.Add(pbxArticulo);

            Text = "Gestión de Artículos";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}