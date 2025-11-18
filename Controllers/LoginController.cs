using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Services;
using System.Threading.Tasks;

namespace ProyectoFinal_Programacionlll.Controllers
{
    public class LoginController
    {
        public async Task<LoginResponse?> LoginAsync(string email, string password)
        {
            // Validación del lado del cliente
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return null;

            // Llamada al servicio que devuelve: (success, user, message)
            var result = await UserService.LoginAsync(email, password);

            // Si falla (status code != 200, excepción, etc.)
            if (!result.success || result.user == null)
                return null;

            // Logueo exitoso: guardar sesión
            UserSession.CurrentUser = result.user;

            return result.user;
        }
    }
}
