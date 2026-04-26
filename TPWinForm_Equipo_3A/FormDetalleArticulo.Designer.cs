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

        private Button btnAnterior;
        private Button btnSiguiente;
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

            btnAnterior = new Button();
            btnSiguiente = new Button();
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

            btnAnterior.Location = new Point(400, 280);
            btnAnterior.Size = new Size(75, 30);
            btnAnterior.Text = "<";
            btnAnterior.Click += btnAnterior_Click;

            btnSiguiente.Location = new Point(575, 280);
            btnSiguiente.Size = new Size(75, 30);
            btnSiguiente.Text = ">";
            btnSiguiente.Click += btnSiguiente_Click;

            btnCerrar.Location = new Point(280, 330);
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            ClientSize = new Size(680, 390);

            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblMarca);
            Controls.Add(lblCategoria);
            Controls.Add(lblPrecio);

            Controls.Add(pbxDetalle);

            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnCerrar);

            Text = "Detalle Artículo";
            StartPosition = FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)pbxDetalle).EndInit();
            ResumeLayout(false);
        }
    }
}