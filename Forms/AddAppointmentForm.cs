using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;
using ProyectoFinal_Programacionlll.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinal_Programacionlll.Forms
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            LoadComboData();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(cmbPaciente.Text) ||
                string.IsNullOrWhiteSpace(cmbDoctor.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal price))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newAppointment = new AppointmentCreateDto
            {
                Date = dtpFecha.Value,
                Reason = txtMotivo.Text,
                Price = price,
                PatientId = (int)cmbPaciente.SelectedValue,
                DoctorId = (int)cmbDoctor.SelectedValue,
                CreatedByUserId = UserSession.CurrentUser.Id
                //CreatedByUserId = 1 // Temporal hasta implementar sesión de usuario
            };

            bool success = await AppointmentService.CreateAppointmentAsync(newAppointment);

            if (success)
            {
                MessageBox.Show("Ficha médica creada correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK; // Cierra el modal con éxito
                Close();
            }
            else
            {
                MessageBox.Show("Error al crear la ficha médica ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.NumbersOnly(sender, e);
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
