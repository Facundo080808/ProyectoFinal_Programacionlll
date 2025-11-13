using ProyectoFinal_Programacionlll.Models;
using ProyectoFinal_Programacionlll.UserControls;
using ProyectoFinal_Programacionlll.Utils;

namespace ProyectoFinal_Programacionlll
{

    public partial class Inicio : Form
    {
        //private AppointmentsView appointmentsView;
        public Inicio()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            var user = UserSession.CurrentUser;

            lblNombreUsuario.Text = user.FullName;
            lblRolUsuario.Text = user.Role;
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
