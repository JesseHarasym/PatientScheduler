using PatientScheduler.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PatientScheduler.Classes.Database
{
    class StaffData
    {
        readonly string connectionString = Connection.ConnectionString;
        public bool CheckForValidStaffId(int staffId)
        {
            bool valid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    $"SELECT COUNT(*) from Staff WHERE StaffId = @staffId", connection))
                {
                    connection.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount == 1)
                        {
                            valid = true;
                        }
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There was an issue looking for this staff Id" + ex);
                    }
                }
            }

            return valid;
        }

        public StaffAccount GetStaffInformation(int staffId, string username, string password)
        {
            string firstName = "";
            string lastName = "";
            string email = "";
            string position = "";
            string accessLevel = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Staff WHERE StaffId = @staffId", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@staffId", staffId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                email = reader["Email"].ToString();
                                position = reader["Position"].ToString();
                                accessLevel = reader["AccessLevel"].ToString();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("There was an issue retrieving the users staff information." + ex);
                            }
                        }
                    }
                    connection.Close();
                }
            }

            var staff = new StaffAccount(firstName, lastName, username, password, email, position, staffId, Convert.ToInt32(accessLevel));
            return staff;
        }

        public bool CheckIfStaffIdHasAccount(int staffId)
        {
            bool validStaffId = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    $"SELECT COUNT(*) from Accounts WHERE StaffId = @staffId", connection))
                {
                    connection.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount == 0)
                        {
                            validStaffId = true;
                        }
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There was an issue looking for this staff id" + ex);
                    }
                }
            }

            return validStaffId;
        }

        public List<Doctors> GetAllDoctors()
        {
            List<Doctors> doctorList = new List<Doctors>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Staff WHERE Position = @doctor", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@doctor", "Doctor");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string staffId = reader["StaffId"].ToString();
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                string email = reader["Email"].ToString();
                                string position = reader["Position"].ToString();
                                string accessLevel = reader["AccessLevel"].ToString();

                                var doctor = new Doctors(firstName, lastName, email, position, Convert.ToInt32(staffId), Convert.ToInt32(accessLevel));
                                doctorList.Add(doctor);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("There was an issue retrieving the users staff information." + ex);
                            }
                        }
                    }
                    connection.Close();
                }
            }

            return doctorList;
        }
    }
}

