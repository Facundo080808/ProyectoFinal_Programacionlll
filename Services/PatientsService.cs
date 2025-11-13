using ProyectoFinal_Programacionlll.Models;
using System.Net.Http.Json;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class PatientService
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5101/")
        };

        public static async Task<List<PatientResponseDto>?> GetAllAsync()
        {
            var response = await client.GetAsync("api/Patient");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<List<PatientResponseDto>>();
        }

        public static async Task<bool> CreateAsync(PatientCreateDto newPatient)
        {
            var response = await client.PostAsJsonAsync("api/Patient", newPatient);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> UpdateAsync(int id, PatientUpdateDto updated)
        {
            var response = await client.PutAsJsonAsync($"api/Patient/{id}", updated);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            var response = await client.DeleteAsync($"api/Patient/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
