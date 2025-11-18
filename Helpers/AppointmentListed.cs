using Newtonsoft.Json;
using ProyectoFinal_Programacionlll.DTOs;

namespace ProyectoFinal_Programacionlll.Helpers
{
    public static class AppointmentListed
    {
        private static readonly string FilePath = "Data/appointments.json";

        public static List<AppointmentResponseDto> Load()
        {
            if (!File.Exists(FilePath))
                return new List<AppointmentResponseDto>();

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<AppointmentResponseDto>>(json)
                   ?? new List<AppointmentResponseDto>();
        }
    }
}
