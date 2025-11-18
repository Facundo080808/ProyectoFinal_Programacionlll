using ProyectoFinal_Programacionlll.DTOs;
using ProyectoFinal_Programacionlll.Helpers;
using System.Text.Json;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class DoctorService
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "doctors.json");

        // ============================
        // Helper: Lee el archivo JSON
        // ============================
        private static async Task<List<DoctorResponseDto>> LoadFileAsync()
        {
            if (!File.Exists(FilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
                await File.WriteAllTextAsync(FilePath, "[]");
            }

            string json = await File.ReadAllTextAsync(FilePath);
            return JsonSerializer.Deserialize<List<DoctorResponseDto>>(json)
                   ?? new List<DoctorResponseDto>();
        }

        // ============================
        // Helper: Guarda el JSON
        // ============================
        private static async Task SaveFileAsync(List<DoctorResponseDto> list)
        {
            var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(FilePath, json);
        }

        // ============================
        // GET — Obtener todos los doctores
        // ============================
        public static async Task<List<DoctorResponseDto>?> GetDoctorsAsync()
        {
            var doctors = await LoadFileAsync();                
            var appointments = AppointmentListed.Load();   

            foreach (var d in doctors)
            {
                d.AppointmentCount = appointments.Count(a => a.DoctorId == d.Id);

                // Pacientes únicos atendidos por el doctor
                d.PatientCount = appointments
                    .Where(a => a.DoctorId == d.Id)
                    .Select(a => a.PatientId)
                    .Distinct()
                    .Count();
            }

            return doctors;
        }

        // ============================
        // POST — Crear doctor
        // ============================
        public static async Task<bool> CreateDoctorAsync(DoctorCreateDto dto)
        {
            var doctors = await LoadFileAsync();

            int newId = doctors.Any() ? doctors.Max(d => d.Id) + 1 : 1;

            doctors.Add(new DoctorResponseDto
            {
                Id = newId,
                FullName = dto.FullName,
                Specialty = dto.Specialty,
                DNI = dto.DNI,
                AppointmentCount = 0,
                PatientCount = 0
            });

            await SaveFileAsync(doctors);
            return true;
        }

        // ============================
        // PUT — Actualizar doctor
        // ============================
        public static async Task<bool> UpdateDoctorAsync(int id, DoctorCreateDto dto)
        {
            var doctors = await LoadFileAsync();

            var doctor = doctors.FirstOrDefault(x => x.Id == id);
            if (doctor == null) return false;

            doctor.FullName = dto.FullName;
            doctor.Specialty = dto.Specialty;
            doctor.DNI = dto.DNI;

            await SaveFileAsync(doctors);
            return true;
        }

        // ============================
        // DELETE — Eliminar doctor
        // ============================
        public static async Task<bool> DeleteDoctorAsync(int id)
        {
            var doctors = await LoadFileAsync();
            var doctor = doctors.FirstOrDefault(d => d.Id == id);

            if (doctor == null) return false;

            doctors.Remove(doctor);
            await SaveFileAsync(doctors);
            return true;
        }
    }
}
