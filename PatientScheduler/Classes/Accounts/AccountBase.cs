namespace PatientScheduler.Classes.Accounts
{
    class AccountBase
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int StaffId { get; set; }
        public int AccessLevel { get; set; }

        public AccountBase(string name, string username, string password, string email, int staffId)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            StaffId = staffId;
        }
    }
}
