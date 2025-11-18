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
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 20);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 1;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(150, 140);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(200, 23);
            txtRole.TabIndex = 7;
            txtRole.KeyPress += txtRol_KeyPress;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Nombre Completo:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Correo:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(20, 140);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 6;
            lblRole.Text = "Rol:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // UserForm
            // 
            ClientSize = new Size(400, 260);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
