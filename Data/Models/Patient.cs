namespace ProyectoFinal_Programacionlll.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DNI { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        
        public List<int> AppointmentIds { get; set; } = new();
    }
}
