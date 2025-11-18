using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Services;
using ProyectoFinal_Programacionlll.Helpers;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class PatientForm : Form
    {
        private readonly PatientResponseDto? existing;

        public PatientForm(PatientResponseDto? patient = null)
        {
            InitializeComponent();
            existing = patient;

            if (existing != null)
            {
                txtFullName.Text = existing.FullName;
                txtDNI.Text = existing.DNI;
                txtPhone.Text = existing.PhoneNumber;
                txtAddress.Text = existing.Address;
                Text = "Editar Paciente";
            }
            else
            {
                Text = "Nuevo Paciente";
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Nombre y DNI son obligatorios");
                return;
            }

            if (existing == null)
            {
                var dto = new PatientCreateDto
                {
                    FullName = txtFullName.Text,
                    DNI = txtDNI.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtAddress.Text
                };
                await PatientService.CreateAsync(dto);
            }
            else
            {
                var dto = new PatientUpdateDto
                {
                    FullName = txtFullName.Text,
                    DNI = txtDNI.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtAddress.Text
                };
                await PatientService.UpdateAsync(existing.Id, dto);
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

        private void txtDNI_TextChanged(object sender, KeyPressEventArgs e)
        {
            Validators.NumbersOnly(sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.NumbersOnly(sender, e);
        }
    }
}
