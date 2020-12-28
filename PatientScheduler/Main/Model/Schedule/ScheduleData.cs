﻿using PatientScheduler.Classes.Accounts;
using PatientScheduler.Main.Controller.DataStructures.Schedule;
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
                                string classification = reader["Classification"].ToString();
                                string appointmentLength = reader["AppointmentLength"].ToString();

                                var appointment = new Appointments(Convert.ToInt32(appointmentId), Convert.ToInt32(doctorId), Convert.ToInt32(patientId), reasonForVisit, Convert.ToDateTime(appointmentDate), Convert.ToInt32(scheduledById), classification, Convert.ToInt32(appointmentLength));
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

        public List<WeeklySchedule> GetOfficeSchedule()
        {
            List<WeeklySchedule> weeklySchedule = new List<WeeklySchedule>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM WeeklySchedule", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string day = reader["Day"].ToString();
                                string open = reader["OpenTime"].ToString();
                                string close = reader["CloseTime"].ToString();

                                weeklySchedule.Add(new WeeklySchedule(day, TimeSpan.Parse(open), TimeSpan.Parse(close)));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("There was an issue retrieving the weekly schedule." + ex);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return weeklySchedule;
        }
    }
}