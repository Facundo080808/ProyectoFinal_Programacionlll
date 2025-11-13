using ProyectoFinal_Programacionlll.Forms;
using ProyectoFinal_Programacionlll.Utils;

namespace ProyectoFinal_Programacionlll
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = new Login();
            ThemeManager.ApplyTheme(mainForm);
            Application.Run(mainForm);
        }
    }
}