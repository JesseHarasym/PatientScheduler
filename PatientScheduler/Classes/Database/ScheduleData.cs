using PatientScheduler.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PatientScheduler.Classes.Database
{
    class ScheduleData
    {
        readonly string connectionString = Connection.ConnectionString;
        public List<Appointments> GetDoctorsAppointments()
        {
            List<Appointments> appointmentList = new List<Appointments>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Appointments", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string appointmentId = reader["AppointmentId"].ToString();
                                string doctorId = reader["DoctorId"].ToString();
                                string patientId = reader["PatientId"].ToString();
                                string reasonForVisit = reader["ReasonForVisit"].ToString();
                                string appointmentDate = reader["AppointmentDate"].ToString();
                                string scheduledById = reader["ScheduledById"].ToString();

                                var appointment = new Appointments(Convert.ToInt32(appointmentId), Convert.ToInt32(doctorId), Convert.ToInt32(patientId), reasonForVisit, Convert.ToDateTime(appointmentDate), Convert.ToInt32(scheduledById));
                                appointmentList.Add(appointment);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("There was an issue retrieving the scheduled appointments." + ex);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return appointmentList;
        }
    }
}
