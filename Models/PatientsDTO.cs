using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Programacionlll.Models
{
    internal class PatientsDTO
    {
    }
}
namespace ProyectoFinal_Programacionlll.Models
{
    public class PatientCreateDto
    {
        public string FullName { get; set; }
        public string DNI { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }

    public class PatientResponseDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DNI { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int AppointmentCount { get; set; }
    }

    public class PatientUpdateDto
    {
        public string? FullName { get; set; }
        public string? DNI { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}

