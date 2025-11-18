using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacionlll.Forms
{
    public partial class EditAppointmentForm : Form
    {
        private int _appointmentId;

        public EditAppointmentForm(dynamic appointment)
        {
            InitializeComponent();
            LoadComboData();
            _appointmentId = appointment.Id;

            // Pre-cargar los valores existentes
            dtpFecha.Value = appointment.Date;
            txtMotivo.Text = appointment.Reason;
            txtPrecio.Text = appointment.Price.ToString();
            cmbPaciente.SelectedValue = appointment.PatientId.ToString();
            cmbDoctor.SelectedValue = appointment.DoctorId.ToString();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completá todos los campos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updated = new AppointmentCreateDto
            {
                Date = dtpFecha.Value,
                Reason = txtMotivo.Text,
                Price = decimal.Parse(txtPrecio.Text),
                PatientId = (int)cmbPaciente.SelectedValue,
                DoctorId = (int)cmbDoctor.SelectedValue,
                CreatedByUserId = UserSession.CurrentUser.Id
            };

            bool success = await AppointmentService.UpdateAppointmentAsync(_appointmentId, updated);

            if (success)
            {
                MessageBox.Show("Ficha médica actualizada correctamente ✅", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar la ficha médica ❌", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadComboData()
        {
            // Cargar pacientes
            var patients = await PatientService.GetAllAsync();

            var patientDisplayList = patients?.Select(p => new
            {
                Id = p.Id,
                DisplayText = $"{p.FullName} - {p.DNI}"
            }).ToList();

            cmbPaciente.DataSource = patientDisplayList;
            cmbPaciente.DisplayMember = "DisplayText"; // se ve Nombre - DNI
            cmbPaciente.ValueMember = "Id"; // sigue usando Id como valor real

            // Cargar doctores normalmente (puedes hacer lo mismo si querés mostrar DNI)
            var doctors = await DoctorService.GetDoctorsAsync();
            var doctorDisplayList = doctors?.Select(p => new
            {
                Id = p.Id,
                DisplayText = $"{p.FullName} - {p.DNI}"
            }).ToList();
            cmbDoctor.DataSource = doctorDisplayList;
            cmbDoctor.DisplayMember = "DisplayText"; // o "FullName - DNI"
            cmbDoctor.ValueMember = "Id";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.NumbersOnly(sender, e);
        }

        private void lblDoctor_Click(object sender, EventArgs e)
        {

        }
        private void lblPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
