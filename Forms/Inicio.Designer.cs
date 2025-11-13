namespace ProyectoFinal_Programacionlll
{
    partial class Inicio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnDoctores = new Button();
            btnUsuarios = new Button();
            btnPacientes = new Button();
            btnHome = new Button();
            panelContent = new Panel();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 40, 40);
            panelMenu.Controls.Add(btnDoctores);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnPacientes);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 20, 0, 0);
            panelMenu.Size = new Size(200, 500);
            panelMenu.TabIndex = 1;
            // 
            // btnDoctores
            // 
            btnDoctores.FlatAppearance.BorderSize = 0;
            btnDoctores.FlatStyle = FlatStyle.Flat;
            btnDoctores.ForeColor = Color.White;
            btnDoctores.Location = new Point(10, 170);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(180, 40);
            btnDoctores.TabIndex = 0;
            btnDoctores.Text = "\U0001fa7a  Doctores";
            btnDoctores.Click += BtnDoctores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(10, 120);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(180, 40);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "👤 Usuarios";
            btnUsuarios.Click += BtnUsuarios_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(10, 70);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(180, 40);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "\U0001f9cd  Pacientes";
            btnPacientes.Click += BtnPacientes_Click;

            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(10, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 40);
            btnHome.TabIndex = 3;
            btnHome.Text = "🏠  Home";
            btnHome.Click += BtnTurnos_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblRolUsuario);
            panelContent.Controls.Add(lblNombreUsuario);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(700, 500);
            panelContent.TabIndex = 0;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(387, 45);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(38, 15);
            lblRolUsuario.TabIndex = 1;
            lblRolUsuario.Text = "label1";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(282, 45);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(38, 15);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "label1";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 500);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnUsuarios;
        private Button btnPacientes;
        private Button btnHome;
        private Button btnDoctores;
        private Panel panelContent;
        private Label lblNombreUsuario;
        private Label lblRolUsuario;
    }
}
