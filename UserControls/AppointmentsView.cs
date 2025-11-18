using ProyectoFinal_Programacionlll.Forms;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ProyectoFinal_Programacionlll.Helpers.DataGridStyles;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class AppointmentsView : UserControl
    {
        public AppointmentsView()
        {
            InitializeComponent();

            // Aplicar estilo al botón
            ButtonsStyles.ApplyCreateStyle(btnCreateAppointment);
            btnCreateAppointment.Click += BtnCreateAppointment_Click;

            // Estilos de la grilla
            DataGridStyles.ApplyStyle(dgvAppointments);

            dgvAppointments.CellClick += dgvAppointments_CellClick;

            LoadAppointments();
        }

       


        private async void LoadAppointments()
        {
            var appointments = await AppointmentService.GetAppointmentsAsync();
            if (appointments == null)
            {
                MessageBox.Show("No se pudieron cargar los turnos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvAppointments.DataSource = appointments;

            // Agregar columnas de acción
            if (!dgvAppointments.Columns.Contains("Edit"))
            {
                var editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "✏️ Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvAppointments.Columns.Add(editColumn);
            }

            if (!dgvAppointments.Columns.Contains("Delete"))
            {
                var deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "🗑️ Borrar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvAppointments.Columns.Add(deleteColumn);
            }
        }

        private async void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int id = Convert.ToInt32(dgvAppointments.Rows[e.RowIndex].Cells["Id"].Value);
            var columnName = dgvAppointments.Columns[e.ColumnIndex].Name;

            if (columnName == "Delete")
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro que querés eliminar la ficha #{id}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool success = await AppointmentService.DeleteAppointmentAsync(id);
                    if (success)
                    {
                        MessageBox.Show("Ficha médica eliminada correctamente ✅");
                        LoadAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la ficha médica ❌");
                    }
                }
            }
            else if (columnName == "Edit")
            {
                var selected = new
                {
                    Id = id,
                    Date = Convert.ToDateTime(dgvAppointments.Rows[e.RowIndex].Cells["Date"].Value),
                    Reason = dgvAppointments.Rows[e.RowIndex].Cells["Reason"].Value.ToString(),
                    Price = Convert.ToDecimal(dgvAppointments.Rows[e.RowIndex].Cells["Price"].Value),
                    PatientId = Convert.ToInt32(dgvAppointments.Rows[e.RowIndex].Cells["PatientId"].Value),
                    DoctorId = Convert.ToInt32(dgvAppointments.Rows[e.RowIndex].Cells["DoctorId"].Value)
                };

                using var form = new EditAppointmentForm(selected);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadAppointments();
            }
        }

        private void BtnCreateAppointment_Click(object sender, EventArgs e)
        {
            using var form = new AddAppointmentForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }
    }
}
