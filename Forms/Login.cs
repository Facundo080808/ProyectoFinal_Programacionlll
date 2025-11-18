using ProyectoFinal_Programacionlll.Controllers;
using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;
using ProyectoFinal_Programacionlll.Utils;
using System;
using System.Windows.Forms;
namespace ProyectoFinal_Programacionlll.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           // ThemeManager.ApplyTheme(this); 
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Centrar el contenedor
            panelContainer.Location = new Point(
                (this.ClientSize.Width - panelContainer.Width) / 2,
                (this.ClientSize.Height - panelContainer.Height) / 2
            );
        }

        // ✅ Se ejecuta cada vez que el usuario cambia el tamaño de la ventana
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Re-centrar el contenedor
            panelContainer.Location = new Point(
                (this.ClientSize.Width - panelContainer.Width) / 2,
                (this.ClientSize.Height - panelContainer.Height) / 2
            );
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (!Validators.IsValid(txtEmail.Text))
            {
                MessageBox.Show("Formato de correo invalido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Verificando...";

            var (success, user, message) = await UserService.LoginAsync(email, password);

            btnLogin.Enabled = true;
            btnLogin.Text = "Ingresar";

            if (!success || user == null)
            {
                MessageBox.Show("El email o contraseña incorrectos.",
                        "Usuario no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            UserSession.CurrentUser = user;
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

    }
}
