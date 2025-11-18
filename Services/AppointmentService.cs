using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.DTOs;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Programacionlll.Services
{
    public static class AppointmentService
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "appointments.json");

        // Cargar archivo JSON
        private static async Task<List<AppointmentResponseDto>> LoadAsync()
        {
            if (!File.Exists(FilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
                await File.WriteAllTextAsync(FilePath, "[]");
            }

            string json = await File.ReadAllTextAsync(FilePath);
            return JsonConvert.DeserializeObject<List<AppointmentResponseDto>>(json) ?? new();
        }

        // Guardar archivo JSON
        private static async Task SaveAsync(List<AppointmentResponseDto> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            await File.WriteAllTextAsync(FilePath, json);
        }

        // ------------------------------------------
        //  GET ALL
        // ------------------------------------------
        public static async Task<List<AppointmentResponseDto>?> GetAppointmentsAsync()
        {
            var appointments = await LoadAsync();

            // Cargar datos relacionados
            var patients = await PatientService.GetAllAsync() ?? new();
            var doctors = await DoctorService.GetDoctorsAsync() ?? new();
            var users = await UserService.GetAllAsync() ?? new();

            foreach (var a in appointments)
            {
                a.PatientFullName = patients.FirstOrDefault(p => p.Id == a.PatientId)?.FullName ?? "N/A";
                a.DoctorFullName = doctors.FirstOrDefault(d => d.Id == a.DoctorId)?.FullName ?? "N/A";
                a.UserFullName = users.FirstOrDefault(u => u.Id == a.CreatedByUserId)?.FullName ?? "N/A";
            }

            return appointments;
        }

        // ------------------------------------------
        //  CREATE
        // ------------------------------------------
        public static async Task<bool> CreateAppointmentAsync(AppointmentCreateDto dto)
        {
            var list = await LoadAsync();

            int newId = list.Any() ? list.Max(a => a.Id) + 1 : 1;

            var newAppointment = new AppointmentResponseDto
            {
                Id = newId,
                Date = dto.Date,
                Reason = dto.Reason,
                Price = dto.Price,
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                CreatedByUserId = dto.CreatedByUserId
            };

            list.Add(newAppointment);
            await SaveAsync(list);
            return true;
        }

        // ------------------------------------------
        //  UPDATE
        // ------------------------------------------
        public static async Task<bool> UpdateAppointmentAsync(int id, AppointmentCreateDto updated)
        {
            var list = await LoadAsync();
            var appointment = list.FirstOrDefault(a => a.Id == id);

            if (appointment == null)
                return false;

            appointment.Date = updated.Date;
            appointment.Reason = updated.Reason;
            appointment.Price = updated.Price;
            appointment.PatientId = updated.PatientId;
            appointment.DoctorId = updated.DoctorId;
            appointment.CreatedByUserId = updated.CreatedByUserId;

            await SaveAsync(list);
            return true;
        }

        // ------------------------------------------
        //  DELETE
        // ------------------------------------------
        public static async Task<bool> DeleteAppointmentAsync(int id)
        {
            var list = await LoadAsync();
            var appointment = list.FirstOrDefault(a => a.Id == id);

            if (appointment == null)
                return false;

            list.Remove(appointment);
            await SaveAsync(list);
            return true;
        }
    }
}
