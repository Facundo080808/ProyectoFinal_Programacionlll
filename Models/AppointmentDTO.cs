namespace ProyectoFinal_Programacionlll.Models
{
    public class AppointmentResponseDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public decimal Price { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int CreatedByUserId { get; set; }
        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }
        public string UserFullName { get; set; }
    };

        public class AppointmentCreateDto
        {
            public DateTime Date { get; set; }
            public string Reason { get; set; }
            public decimal Price { get; set; }
            public int PatientId { get; set; }
            public int DoctorId { get; set; }
            public int CreatedByUserId { get; set; }
        }
    }

