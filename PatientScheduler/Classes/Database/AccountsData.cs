using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Validation;
using System;
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
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Accounts WHERE Username = @username",
                    connection))
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
    }
}
