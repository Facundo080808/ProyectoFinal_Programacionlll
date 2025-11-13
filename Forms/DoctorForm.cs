using ProyectoFinal_Programacionlll.Models;
using ProyectoFinal_Programacionlll.Services;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacionlll.Forms
{
    public partial class AddDoctorForm : Form
    {
        private readonly int? doctorId = null;

        public AddDoctorForm(int? id = null, string fullName = "", string specialty = "", int dni = 0)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                doctorId = id;
                txtFullName.Text = fullName;
                txtSpecialty.Text = specialty;
                txtDNI.Text = dni.ToString();
                Text = "Editar Doctor";
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtSpecialty.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor completá todos los campos.", "Error");
                return;
            }

            var dto = new DoctorCreateDto
            {
                FullName = txtFullName.Text,
                Specialty = txtSpecialty.Text,
                DNI = int.Parse(txtDNI.Text)
            };

            bool success = doctorId == null
                ? await DoctorService.CreateDoctorAsync(dto)
                : await DoctorService.UpdateDoctorAsync(doctorId.Value, dto);

            if (success)
            {
                MessageBox.Show("✅ Operación exitosa");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("❌ Error al guardar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
