using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.UserControls;
using ProyectoFinal_Programacionlll.Utils;

namespace ProyectoFinal_Programacionlll
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            var user = UserSession.CurrentUser;
            bool isAdmin = user.Role.ToLower() == "admin";

            if (!isAdmin)
            {
                // Oculta todo el panel lateral
                panelMenu.Visible = false;

                // Ajusta el panelContent para ocupar toda la pantalla
                panelContent.Dock = DockStyle.Fill;
            }
            LoadView(new UserControls.AppointmentsView());
        }

        private void LoadView(UserControl view)
        {
            panelContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelContent.Controls.Add(view);
        }
        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            LoadView(new UserControls.AppointmentsView());
        }

        private void BtnDoctores_Click(object sender, EventArgs e)
        {
            LoadView(new UserControls.DoctorsView());
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            LoadView(new UserControls.PatientsView());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            LoadView(new UserControls.UsersView());
        }
    }
}
