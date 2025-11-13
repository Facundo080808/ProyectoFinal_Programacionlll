namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class PatientForm
    {
        private TextBox txtFullName;
        private TextBox txtDNI;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label lblFullName;
        private Label lblDNI;
        private Label lblPhone;
        private Label lblAddress;
        private Button btnGuardar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtDNI = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblFullName = new Label();
            lblDNI = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // Labels y Textboxes
            // 
            lblFullName.Text = "Nombre Completo:";
            lblFullName.Location = new Point(20, 20);
            txtFullName.Location = new Point(150, 20);
            txtFullName.Width = 200;

            lblDNI.Text = "DNI:";
            lblDNI.Location = new Point(20, 60);
            txtDNI.Location = new Point(150, 60);
            txtDNI.Width = 200;

            lblPhone.Text = "Teléfono:";
            lblPhone.Location = new Point(20, 100);
            txtPhone.Location = new Point(150, 100);
            txtPhone.Width = 200;

            lblAddress.Text = "Dirección:";
            lblAddress.Location = new Point(20, 140);
            txtAddress.Location = new Point(150, 140);
            txtAddress.Width = 200;

            // 
            // Botones
            // 
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(80, 200);
            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(200, 200);
            btnCancelar.Click += btnCancelar_Click;

            // 
            // Form
            // 
            ClientSize = new Size(400, 260);
            Controls.AddRange(new Control[] {
                lblFullName, txtFullName,
                lblDNI, txtDNI,
                lblPhone, txtPhone,
                lblAddress, txtAddress,
                btnGuardar, btnCancelar
            });
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paciente";
            ResumeLayout(false);
        }
    }
}
