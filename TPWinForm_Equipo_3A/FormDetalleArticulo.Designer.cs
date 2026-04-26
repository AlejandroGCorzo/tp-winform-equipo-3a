namespace TPWinForm_Equipo_3A
{
    partial class FormDetalleArticulo
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblPrecio;
        private PictureBox pbxDetalle;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            pbxDetalle = new PictureBox();
            btnCerrar = new Button();

            ((System.ComponentModel.ISupportInitialize)pbxDetalle).BeginInit();
            SuspendLayout();

            lblCodigo.Location = new Point(20, 20);
            lblCodigo.Size = new Size(350, 20);

            lblNombre.Location = new Point(20, 50);
            lblNombre.Size = new Size(350, 20);

            lblDescripcion.Location = new Point(20, 80);
            lblDescripcion.Size = new Size(350, 40);

            lblMarca.Location = new Point(20, 130);
            lblMarca.Size = new Size(350, 20);

            lblCategoria.Location = new Point(20, 160);
            lblCategoria.Size = new Size(350, 20);

            lblPrecio.Location = new Point(20, 190);
            lblPrecio.Size = new Size(350, 20);

            pbxDetalle.Location = new Point(400, 20);
            pbxDetalle.Size = new Size(250, 250);
            pbxDetalle.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDetalle.BorderStyle = BorderStyle.FixedSingle;

            btnCerrar.Location = new Point(280, 300);
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            ClientSize = new Size(680, 360);

            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblMarca);
            Controls.Add(lblCategoria);
            Controls.Add(lblPrecio);
            Controls.Add(pbxDetalle);
            Controls.Add(btnCerrar);

            Text = "Detalle Artículo";
            StartPosition = FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)pbxDetalle).EndInit();
            ResumeLayout(false);
        }
    }
}