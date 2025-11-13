using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.Models;
using System.Net.Http.Json;


namespace ProyectoFinal_Programacionlll.Services
{
    internal class AppointmentService
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5101/")
        };
        public static async Task<bool> CreateAppointmentAsync(AppointmentCreateDto dto)
        {
            try
            {
                var response = await client.PostAsJsonAsync("api/Appointment", dto);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<List<AppointmentResponseDto>?> GetAppointmentsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/Appointment");

            if (!response.IsSuccessStatusCode)
                return null;

            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<AppointmentResponseDto>>(json);
        }
        /////////////////////

        public static async Task<bool> UpdateAppointmentAsync(int id, AppointmentCreateDto updated)
        {
            var response = await client.PutAsJsonAsync($"api/Appointment/{id}", updated);
            if (!response.IsSuccessStatusCode)
                return false;
            return response.IsSuccessStatusCode;
            
        }

        /// ///////

        public static async Task<bool> DeleteAppointmentAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Appointment/{id}");
            return response.IsSuccessStatusCode;
        }
    }
    }
