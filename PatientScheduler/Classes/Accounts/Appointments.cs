using System;

namespace PatientScheduler.Classes.Accounts
{
    public class Appointments
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string ReasonForVisit { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int ScheduledById { get; set; }
        public string Classification { get; set; }
        public int AppointmentLength { get; set; }

        public Appointments(int appointmentId, int doctorId, int patientId, string reasonForVisit, DateTime appointmentDate, int scheduledById, string classification, int appointmentLength)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            ReasonForVisit = reasonForVisit;
            AppointmentDate = appointmentDate;
            ScheduledById = scheduledById;
            Classification = classification;
            AppointmentLength = appointmentLength;
        }
    }
}
