namespace PatientScheduler.Classes.Accounts
{
    //base accounts for users, which is inherited on by different types of users
    public class AccountBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int StaffId { get; set; }

        public AccountBase(string username, string password, int staffId)
        {
            Username = username;
            Password = password;
            StaffId = staffId;
        }
    }
}
