using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Validation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PatientScheduler.Classes.Database
{
    class AccountsData
    {
        readonly string connectionString = Connection.ConnectionString;
        public bool AddAccount<T>(T account) where T : AccountBase
        {
            bool success = false;
            //hash password before entering it into the database
            var hp = new HashPasswords();
            string hashedPassword = hp.HashAccountPassword(account.Password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    $"INSERT INTO Accounts (Username, Password, StaffId)" +
                    $"VALUES (@username, @password, @staffid)", connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@username", account.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@staffid", account.StaffId);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There was an issue while creating this user " + ex);
                    }
                }
            }

            return success;
        }

        public Tuple<bool, string> GetAccountPassword(string username, string enteredPassword)
        {
            string savedPassword = "";
            string staffId = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Accounts WHERE Username = @username", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                savedPassword = reader["Password"].ToString();
                                staffId = reader["StaffId"].ToString();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("There was an issue retrieving the users password to unhash." + ex);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            //check currently stored hash password with the password the user entered, see if it's a match and return the results
            var hp = new HashPasswords();
            bool match = hp.UnHashAccountPassword(enteredPassword, savedPassword);

            return Tuple.Create(match, staffId);
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

        public bool CheckForExistingUsername(string username)
        {
            bool validUsername = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    $"SELECT COUNT(*) from Accounts WHERE Username = @username", connection))
                {
                    connection.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount == 0)
                        {
                            validUsername = true;
                        }
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There was an issue looking for this username" + ex);
                    }
                }
            }

            return validUsername;
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
