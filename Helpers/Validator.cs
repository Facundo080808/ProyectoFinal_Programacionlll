using System.Text.RegularExpressions;
namespace ProyectoFinal_Programacionlll.Helpers
{
    public static class Validators
    {
        private static readonly Regex _emailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled
        );

        public static bool IsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return _emailRegex.IsMatch(email);
        }
        public static void AllowOnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }
        public static void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Permitir Backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
