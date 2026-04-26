namespace TPWinForm_Equipo_3A
{
    partial class FormCatalogos
    {
        private System.ComponentModel.IContainer components = null;

        private ListBox lstMarcas;
        private ListBox lstCategorias;

        private TextBox txtMarca;
        private TextBox txtCategoria;

        private Button btnAgregarMarca;
        private Button btnEliminarMarca;

        private Button btnAgregarCategoria;
        private Button btnEliminarCategoria;

        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstMarcas = new ListBox();
            lstCategorias = new ListBox();

            txtMarca = new TextBox();
            txtCategoria = new TextBox();

            btnAgregarMarca = new Button();
            btnEliminarMarca = new Button();

            btnAgregarCategoria = new Button();
            btnEliminarCategoria = new Button();

            btnCerrar = new Button();

            SuspendLayout();

            lstMarcas.Location = new Point(20, 20);
            lstMarcas.Size = new Size(180, 180);

            txtMarca.Location = new Point(20, 215);
            txtMarca.Size = new Size(180, 23);

            btnAgregarMarca.Location = new Point(20, 245);
            btnAgregarMarca.Size = new Size(180, 30);
            btnAgregarMarca.Text = "Agregar Marca";
            btnAgregarMarca.Click += btnAgregarMarca_Click;

            btnEliminarMarca.Location = new Point(20, 280);
            btnEliminarMarca.Size = new Size(180, 30);
            btnEliminarMarca.Text = "Eliminar Marca";
            btnEliminarMarca.Click += btnEliminarMarca_Click;

            lstCategorias.Location = new Point(240, 20);
            lstCategorias.Size = new Size(180, 180);

            txtCategoria.Location = new Point(240, 215);
            txtCategoria.Size = new Size(180, 23);

            btnAgregarCategoria.Location = new Point(240, 245);
            btnAgregarCategoria.Size = new Size(180, 30);
            btnAgregarCategoria.Text = "Agregar Categoría";
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;

            btnEliminarCategoria.Location = new Point(240, 280);
            btnEliminarCategoria.Size = new Size(180, 30);
            btnEliminarCategoria.Text = "Eliminar Categoría";
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;

            btnCerrar.Location = new Point(160, 335);
            btnCerrar.Size = new Size(120, 30);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            ClientSize = new Size(450, 390);

            Controls.Add(lstMarcas);
            Controls.Add(txtMarca);
            Controls.Add(btnAgregarMarca);
            Controls.Add(btnEliminarMarca);

            Controls.Add(lstCategorias);
            Controls.Add(txtCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(btnEliminarCategoria);

            Controls.Add(btnCerrar);

            Text = "Administrar Catálogos";
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}