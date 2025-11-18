using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Services;
using ProyectoFinal_Programacionlll.Helpers;
using System.Windows.Forms;

namespace ProyectoFinal_Programacionlll.UserControls
{
    public partial class UsersView : UserControl
    {
        private List<UserResponseDto> users = new();

        public UsersView()
        {
            InitializeComponent();
            DataGridStyles.ApplyStyle(dataGridView1);
            LoadUsers();
            ButtonsStyles.ApplyCreateStyle(btnAgregar);
        }

        private async void LoadUsers()
        {
            users = await UserService.GetAllAsync() ?? new();
            dataGridView1.DataSource = users;

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
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var user = users[e.RowIndex];

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var form = new UserForm(user);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadUsers();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Seguro deseas eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await UserService.DeleteAsync(user.Id);
                    LoadUsers();
                }
            }
        }
    }
}
