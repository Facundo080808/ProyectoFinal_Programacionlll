namespace ProyectoFinal_Programacionlll.Models
{
    // DTO para mostrar datos del doctor (GET)
    public class DoctorResponseDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public int DNI { get; set; }

        
        public int PatientCount { get; set; }
        public int AppointmentCount { get; set; }
    }

    // DTO para crear un nuevo doctor (POST)
    public class DoctorCreateDto
    {
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public int DNI { get; set; }
    }

    // DTO para actualizar un doctor existente (PUT)
    public class DoctorUpdateDto
    {
        public string? FullName { get; set; }
        public string? Specialty { get; set; }
        public int? DNI { get; set; }
    }
}
