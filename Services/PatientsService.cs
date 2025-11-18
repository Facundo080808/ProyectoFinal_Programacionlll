using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using ProyectoFinal_Programacionlll.Models;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class PatientService
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "patients.json");

        // ============================
        // Crear archivo si no existe
        // ============================
        static PatientService()
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));

            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "[]");
        }

        // ============================
        // Helpers internos
        // ============================
        private static async Task<List<PatientResponseDto>> LoadFileAsync()
        {
            string json = await File.ReadAllTextAsync(FilePath);
            return JsonConvert.DeserializeObject<List<PatientResponseDto>>(json) ?? new();
        }

        private static async Task SaveFileAsync(List<PatientResponseDto> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            await File.WriteAllTextAsync(FilePath, json);
        }

        // ============================
        // Métodos públicos
        // ============================
        public static async Task<List<PatientResponseDto>> GetAllAsync()
        {
            var patients = await LoadFileAsync();               
            var appointments = AppointmentListed.Load();    

            foreach (var p in patients)
            {
                p.AppointmentCount = appointments.Count(a => a.PatientId == p.Id);
            }

            return patients;
        }

        public static async Task<PatientResponseDto?> GetByIdAsync(int id)
        {
            var list = await LoadFileAsync();
            return list.FirstOrDefault(x => x.Id == id);
        }

        public static async Task<bool> CreateAsync(PatientCreateDto dto)
        {
            var list = await LoadFileAsync();

            int newId = list.Any() ? list.Max(x => x.Id) + 1 : 1;

            var newPatient = new PatientResponseDto
            {
                Id = newId,
                FullName = dto.FullName,
                DNI = dto.DNI,
                PhoneNumber = dto.PhoneNumber,
                Address = dto.Address,
                AppointmentCount = 0
            };

            list.Add(newPatient);
            await SaveFileAsync(list);

            return true;
        }

        public static async Task<bool> UpdateAsync(int id, PatientUpdateDto dto)
        {
            var list = await LoadFileAsync();
            var patient = list.FirstOrDefault(x => x.Id == id);

            if (patient == null)
                return false;

            if (dto.FullName != null) patient.FullName = dto.FullName;
            if (dto.DNI != null) patient.DNI = dto.DNI;
            if (dto.PhoneNumber != null) patient.PhoneNumber = dto.PhoneNumber;
            if (dto.Address != null) patient.Address = dto.Address;

            await SaveFileAsync(list);
            return true;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            var list = await LoadFileAsync();
            var patient = list.FirstOrDefault(x => x.Id == id);

            if (patient == null)
                return false;

            list.Remove(patient);
            await SaveFileAsync(list);
            return true;
        }
    }
}
