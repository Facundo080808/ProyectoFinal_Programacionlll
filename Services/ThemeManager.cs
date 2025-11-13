using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoFinal_Programacionlll.Utils
{
    public static class ThemeManager
    {
        // ---- WinAPI para bordes redondeados ----
        private const int DWMWINDOWATTRIBUTE = 33; // DWMWA_WINDOW_CORNER_PREFERENCE
        private const int DWMWCP_ROUND = 2;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public static bool IsDarkMode()
        {
            const string key = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            var registryKey = Registry.CurrentUser.OpenSubKey(key);

            if (registryKey != null)
            {
                var value = registryKey.GetValue("AppsUseLightTheme");
                return value is int v && v == 0; // 0 = Dark
            }

            return false;
        }

        public static void ApplyTheme(Form form)
        {
            bool dark = IsDarkMode();

            // ---- Estilo general del formulario ----
            form.BackColor = dark ? Color.FromArgb(32, 32, 32) : Color.White;
            form.ForeColor = dark ? Color.White : Color.Black;

            // Bordes redondeados estilo Windows 11
            ApplyRoundedCorners(form);

            // Aplicar a controles
            ApplyToControls(form.Controls, dark);

            form.Refresh();
        }

        private static void ApplyRoundedCorners(Form form)
        {
            int attribute = DWMWCP_ROUND;
            DwmSetWindowAttribute(form.Handle, DWMWINDOWATTRIBUTE, ref attribute, sizeof(int));
        }

        private static void ApplyToControls(Control.ControlCollection controls, bool dark)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    // ----- Botones -----
                    case Button btn:
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = dark ? Color.FromArgb(55, 55, 55) : Color.FromArgb(240, 240, 240);
                        btn.ForeColor = dark ? Color.White : Color.Black;
                        btn.Font = new Font("Segoe UI", 10);
                        break;

                    // ----- TextBox -----
                    case TextBox txt:
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.BackColor = dark ? Color.FromArgb(45, 45, 45) : Color.White;
                        txt.ForeColor = dark ? Color.White : Color.Black;
                        break;

                    // ----- Labels -----
                    case Label lbl:
                        lbl.ForeColor = dark ? Color.White : Color.Black;
                        lbl.Font = new Font("Segoe UI", 10);
                        break;
                }

                // Paneles, groupboxes, etc.
                if (control.HasChildren)
                    ApplyToControls(control.Controls, dark);
            }
        }
    }

}
