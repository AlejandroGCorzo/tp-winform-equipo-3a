namespace TPWinForm_Equipo_3A
{
    partial class FormAltaArticulo
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtImagen;

        private ComboBox cboMarca;
        private ComboBox cboCategoria;

        private ListBox lstImagenes;

        private Button btnAgregarImagen;
        private Button btnQuitarImagen;
        private Button btnAceptar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtImagen = new TextBox();

            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();

            lstImagenes = new ListBox();

            btnAgregarImagen = new Button();
            btnQuitarImagen = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            txtCodigo.Location = new Point(20, 20);
            txtCodigo.Size = new Size(260, 23);
            txtCodigo.PlaceholderText = "Código";

            txtNombre.Location = new Point(20, 55);
            txtNombre.Size = new Size(260, 23);
            txtNombre.PlaceholderText = "Nombre";

            txtDescripcion.Location = new Point(20, 90);
            txtDescripcion.Size = new Size(260, 23);
            txtDescripcion.PlaceholderText = "Descripción";

            txtPrecio.Location = new Point(20, 125);
            txtPrecio.Size = new Size(260, 23);
            txtPrecio.PlaceholderText = "Precio";

            txtImagen.Location = new Point(20, 160);
            txtImagen.Size = new Size(260, 23);
            txtImagen.PlaceholderText = "URL Imagen";

            btnAgregarImagen.Location = new Point(20, 190);
            btnAgregarImagen.Size = new Size(125, 28);
            btnAgregarImagen.Text = "Agregar Imagen";
            btnAgregarImagen.Click += btnAgregarImagen_Click;

            btnQuitarImagen.Location = new Point(155, 190);
            btnQuitarImagen.Size = new Size(125, 28);
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.Click += btnQuitarImagen_Click;

            lstImagenes.Location = new Point(20, 225);
            lstImagenes.Size = new Size(260, 94);

            cboMarca.Location = new Point(20, 330);
            cboMarca.Size = new Size(260, 23);

            cboCategoria.Location = new Point(20, 365);
            cboCategoria.Size = new Size(260, 23);

            btnAceptar.Location = new Point(20, 410);
            btnAceptar.Size = new Size(120, 30);
            btnAceptar.Text = "Aceptar";
            btnAceptar.Click += btnAceptar_Click;

            btnCancelar.Location = new Point(160, 410);
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            ClientSize = new Size(305, 460);

            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtImagen);

            Controls.Add(btnAgregarImagen);
            Controls.Add(btnQuitarImagen);
            Controls.Add(lstImagenes);

            Controls.Add(cboMarca);
            Controls.Add(cboCategoria);

            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);

            Text = "Nuevo Artículo";
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}