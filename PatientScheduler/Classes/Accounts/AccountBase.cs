namespace PatientScheduler.Classes.Accounts
{
    class AccountBase
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
