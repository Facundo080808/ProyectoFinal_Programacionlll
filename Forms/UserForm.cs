using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class UserForm : Form
    {
        private readonly UserResponseDto? existing;

        public UserForm(UserResponseDto? user = null)
        {
            InitializeComponent();
            existing = user;

            if (existing != null)
            {
                txtFullName.Text = existing.FullName;
                txtEmail.Text = existing.Email;
                txtRole.Text = existing.Role;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
                Text = "Editar Usuario";
            }
            else
            {
                Text = "Nuevo Usuario";
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nombre y correo son obligatorios");
                return;
            }
            if (!Validators.IsValid(txtEmail.Text))
            {
                MessageBox.Show("Formato de correo invalido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existing == null)
            {
                var dto = new UserCreateDto
                {
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Role = txtRole.Text
                };
                await UserService.CreateAsync(dto);
            }
            else
            {
                var dto = new UserUpdateDto
                {
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    Role = txtRole.Text
                };
                await UserService.UpdateAsync(existing.Id, dto);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.AllowOnlyLetters(sender, e);
        }

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.AllowOnlyLetters(sender, e);
        }
    }
}
