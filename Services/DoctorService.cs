using ProyectoFinal_Programacionlll.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class DoctorService
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5101/")
        };

        public static async Task<List<DoctorResponseDto>?> GetDoctorsAsync()
        {
            return await client.GetFromJsonAsync<List<DoctorResponseDto>>("api/Doctor");
        }

        public static async Task<bool> DeleteDoctorAsync(int id)
        {
            var response = await client.DeleteAsync($"api/Doctor/{id}");
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> CreateDoctorAsync(DoctorCreateDto doctor)
        {
            var response = await client.PostAsJsonAsync("api/Doctor", doctor);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> UpdateDoctorAsync(int id, DoctorCreateDto doctor)
        {
            var response = await client.PutAsJsonAsync($"api/Doctor/{id}", doctor);
            return response.IsSuccessStatusCode;
        }
    }
}
