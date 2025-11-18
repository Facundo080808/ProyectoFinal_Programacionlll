using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using System.Text;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class UserService
    {
        private static readonly string filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "users.json");

        // Asegura que exista el archivo
        private static void EnsureFile()
        {
            string dir = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "[]");
        }

        // Leer
        private static List<UserInternalModel> LoadFile()
        {
            EnsureFile();
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<UserInternalModel>>(json) ?? new();
        }

        // Guardar
        private static void SaveFile(List<UserInternalModel> users)
        {
            EnsureFile();
            File.WriteAllText(filePath, JsonConvert.SerializeObject(users, Formatting.Indented));
        }

        // Modelo interno (incluye Password)
        private class UserInternalModel
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }   // Solo interno
            public string Role { get; set; }
        }

        // ---------------------------------------------------------
        // LOGIN
        // ---------------------------------------------------------
        public static async Task<(bool success, LoginResponse? user, string message)>
            LoginAsync(string email, string password)
        {
            try
            {
                var users = LoadFile();
                var u = users.FirstOrDefault(x =>
                    x.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    x.Password == password.Trim()
                );

                if (u == null)
                    return (false, null, "Email o contraseña incorrectos");

                var loginResponse = new LoginResponse
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Email = u.Email,
                    Role = u.Role
                };

                return (true, loginResponse, "OK");
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        // ---------------------------------------------------------
        // GET ALL
        // ---------------------------------------------------------
        public static async Task<List<UserResponseDto>?> GetAllAsync()
        {
            var users = LoadFile();
            var appointments = AppointmentListed.Load();  // 🔥 cargar fichas

            return users.Select(u => new UserResponseDto
            {
                Id = u.Id,
                FullName = u.FullName,
                Email = u.Email,
                Role = u.Role,
                CreatedAppointmentsCount = appointments.Count(a => a.CreatedByUserId == u.Id)
            }).ToList();
        }

        // ---------------------------------------------------------
        // CREATE
        // ---------------------------------------------------------
        public static async Task<bool> CreateAsync(UserCreateDto newUser)
        {
            var users = LoadFile();

            if (users.Any(u => u.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase)))
                return false; // email duplicado

            int newId = (users.Count == 0) ? 1 : users.Max(u => u.Id) + 1;

            var model = new UserInternalModel
            {
                Id = newId,
                FullName = newUser.FullName,
                Email = newUser.Email,
                Password = newUser.Password, // texto plano (puedo encriptarlo si querés)
                Role = newUser.Role
            };

            users.Add(model);
            SaveFile(users);
            return true;
        }

        // ---------------------------------------------------------
        // UPDATE
        // ---------------------------------------------------------
        public static async Task<bool> UpdateAsync(int id, UserUpdateDto updated)
        {
            var users = LoadFile();
            var u = users.FirstOrDefault(x => x.Id == id);

            if (u == null)
                return false;

            if (!string.IsNullOrWhiteSpace(updated.FullName))
                u.FullName = updated.FullName;

            if (!string.IsNullOrWhiteSpace(updated.Email))
                u.Email = updated.Email;

            if (!string.IsNullOrWhiteSpace(updated.Role))
                u.Role = updated.Role;

            SaveFile(users);
            return true;
        }

        // ---------------------------------------------------------
        // DELETE
        // ---------------------------------------------------------
        public static async Task<bool> DeleteAsync(int id)
        {
            var users = LoadFile();
            var u = users.FirstOrDefault(x => x.Id == id);

            if (u == null)
                return false;

            users.Remove(u);
            SaveFile(users);
            return true;
        }
    }
}
