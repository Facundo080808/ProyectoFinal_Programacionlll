using ProyectoFinal_Programacionlll.Services;
using ProyectoFinal_Programacionlll.Models;
using ProyectoFinal_Programacionlll.Helpers;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class DoctorsView : UserControl
    {
        public DoctorsView()
        {
            InitializeComponent();

            // Aplicamos los estilos del helper
            DataGridStyles.ApplyStyle(dgvDoctors);

            dgvDoctors.CellContentClick += DgvDoctors_CellContentClick;

            LoadDoctors();
        }

        private async void LoadDoctors()
        {
            var doctors = await DoctorService.GetDoctorsAsync();

            if (doctors == null)
            {
                MessageBox.Show("No se pudieron cargar los doctores.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvDoctors.DataSource = doctors;

            // Añadimos columnas de acción si no existen
            if (!dgvDoctors.Columns.Contains("Edit"))
            {
                var editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "✏️ Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvDoctors.Columns.Add(editColumn);
            }

            if (!dgvDoctors.Columns.Contains("Delete"))
            {
                var deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "🗑️ Borrar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvDoctors.Columns.Add(deleteColumn);
            }
        }

        private async void DgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var columnName = dgvDoctors.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dgvDoctors.Rows[e.RowIndex].Cells["Id"].Value);

            if (columnName == "Delete")
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro que querés eliminar el doctor #{id}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = await DoctorService.DeleteDoctorAsync(id);
                    if (success)
                    {
                        MessageBox.Show("Doctor eliminado correctamente ✅");
                        LoadDoctors();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el doctor ❌");
                    }
                }
            }

            if (columnName == "Edit")
            {
                int dni = Convert.ToInt32(dgvDoctors.Rows[e.RowIndex].Cells["DNI"].Value);
                string fullName = dgvDoctors.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                string specialty = dgvDoctors.Rows[e.RowIndex].Cells["Specialty"].Value.ToString();

                var form = new Forms.AddDoctorForm(id, fullName, specialty, dni);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadDoctors();
            }
        }
    }
}
