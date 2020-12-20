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
                    $"INSERT INTO Accounts (Name, Username, Password, Email, StaffId, AccessLevel) " +
                    $"VALUES (@name, @username, @password, @email, @staffid, @accessLevel)", connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@name", account.Name);
                        cmd.Parameters.AddWithValue("@username", account.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@email", account.Email);
                        cmd.Parameters.AddWithValue("@staffid", account.StaffId);
                        cmd.Parameters.AddWithValue("@accessLevel", account.AccessLevel);
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
    }
}
