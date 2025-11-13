namespace ProyectoFinal_Programacionlll.UserControls
{
    partial class UserForm
    {
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;
        private Button btnGuardar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
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

            lblEmail.Text = "Correo:";
            lblEmail.Location = new Point(20, 60);
            txtEmail.Location = new Point(150, 60);
            txtEmail.Width = 200;

            lblPassword.Text = "Contraseña:";
            lblPassword.Location = new Point(20, 100);
            txtPassword.Location = new Point(150, 100);
            txtPassword.Width = 200;
            txtPassword.PasswordChar = '*';

            lblRole.Text = "Rol:";
            lblRole.Location = new Point(20, 140);
            txtRole.Location = new Point(150, 140);
            txtRole.Width = 200;

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
                lblEmail, txtEmail,
                lblPassword, txtPassword,
                lblRole, txtRole,
                btnGuardar, btnCancelar
            });
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            ResumeLayout(false);
        }
    }
}
