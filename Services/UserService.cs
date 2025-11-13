using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class UserService
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5101/")
        };

        public static async Task<(bool success, LoginResponse? user, string message)> LoginAsync(string email, string password)
        {
            try
            {
                email = email.Trim();
                password = password.Trim();

                var data = new LoginRequest { Email = email, Password = password };
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/User/login", content);

                string resultBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    // devolvemos status + body para diagnostico
                    return (false, null, $"Status: {(int)response.StatusCode} {response.ReasonPhrase}\nBody: {resultBody}");
                }

                var user = JsonConvert.DeserializeObject<LoginResponse>(resultBody);
                return (true, user, "OK");
            }
            catch (Exception ex)
            {
                return (false, null, $"Exception: {ex.Message}\n{ex.StackTrace}");
            }
        }

        ///////////////////
        ///
        public static async Task<List<UserResponseDto>?> GetAllAsync()
        {
            var response = await client.GetAsync("api/User");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<List<UserResponseDto>>();
        }

        public static async Task<bool> CreateAsync(UserCreateDto newUser)
        {
            var response = await client.PostAsJsonAsync("api/User", newUser);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> UpdateAsync(int id, UserUpdateDto updated)
        {
            var response = await client.PutAsJsonAsync($"api/User/{id}", updated);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            var response = await client.DeleteAsync($"api/User/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}
