using ProyectoFinal_Programacionlll.Models;
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
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtPacienteId.Text) ||
                string.IsNullOrWhiteSpace(txtDoctorId.Text))
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
                PatientId = int.Parse(txtPacienteId.Text),
                DoctorId = int.Parse(txtDoctorId.Text),
                CreatedByUserId = UserSession.CurrentUser.Id
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

        

       

    }
}
