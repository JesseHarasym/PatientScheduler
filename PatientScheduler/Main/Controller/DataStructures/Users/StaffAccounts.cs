namespace PatientScheduler.Classes.Accounts
{
    //accounts for staff inherited from our accounts base so that we are able to create new users and log them in
    public class StaffAccounts : AccountBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int AccessLevel { get; set; }
        public StaffAccounts(string firstName, string lastName, string username, string password, string email, string position, int staffId, int accessLevel) :
            base(username, password, staffId)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Email = email;
            Position = position;
            StaffId = staffId;
            AccessLevel = accessLevel;
        }
    }
}
