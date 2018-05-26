using System.Collections.Generic;

namespace HighBarAppWF
{
    public class Appointment
    {
        public int recordId { get; set; }
        public int internalId { get; set; }
        public string namePatient { get; set; }
        public string appointmentTime { get; set; }
        public int appointmentId { get; set; }
        public string draftedBy { get; set; }
        public string completedBy { get; set; }
        public string drafted { get; set; }
        public string completed { get; set; }
        public string noAction { get; set; }
        public int[] itemsIds { get; set; }
    }
    public class AppointmetResult {
        public int userId { get; set; }
        public string nameDoctor { get; set; }
        public string appointmentDate { get; set; }
        public List<Appointment> appointments { get; set; }

    }
}