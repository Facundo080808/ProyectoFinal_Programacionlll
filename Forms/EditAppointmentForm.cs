using ProyectoFinal_Programacionlll.Models;
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
            _appointmentId = appointment.Id;

            // Pre-cargar los valores existentes
            dtpFecha.Value = appointment.Date;
            txtMotivo.Text = appointment.Reason;
            txtPrecio.Text = appointment.Price.ToString();
            txtPacienteId.Text = appointment.PatientId.ToString();
            txtDoctorId.Text = appointment.DoctorId.ToString();
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
                PatientId = int.Parse(txtPacienteId.Text),
                DoctorId = int.Parse(txtDoctorId.Text),
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
