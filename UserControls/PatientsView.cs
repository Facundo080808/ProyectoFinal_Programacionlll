using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Services;
using System.Windows.Forms;
using static ProyectoFinal_Programacionlll.Helpers.DataGridStyles;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class PatientsView : UserControl
    {
        private List<PatientResponseDto> patients = new();

        public PatientsView()
        {
            InitializeComponent();
            DataGridStyles.ApplyStyle(dataGridView1);
            LoadPatients();
            ButtonsStyles.ApplyCreateStyle(btnAgregar);
        }

        public async void LoadPatients()
        {
            patients = await PatientService.GetAllAsync() ?? new();
            dataGridView1.DataSource = patients;
           
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn editBtn = new()
                {
                    Text = "✏️ Editar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Name = "Editar"
                };
                dataGridView1.Columns.Add(editBtn);

                DataGridViewButtonColumn delBtn = new()
                {
                    Text = "🗑️ Eliminar",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Name = "Eliminar"
                };
                dataGridView1.Columns.Add(delBtn);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPatients();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var patient = patients[e.RowIndex];

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var form = new PatientForm(patient);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadPatients();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Seguro deseas eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await PatientService.DeleteAsync(patient.Id);
                    LoadPatients();
                }
            }
        }
    }
}
