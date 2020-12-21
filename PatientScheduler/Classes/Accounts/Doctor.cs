namespace PatientScheduler.Classes.Accounts
{
    class Doctor : AccountBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AccessLevel { get; set; }
        public Doctor(string firstName, string lastName, string username, string password, string email, int staffId, int accessLevel) :
            base(username, password, staffId)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Email = email;
            StaffId = staffId;
            AccessLevel = accessLevel;
        }
    }
}

