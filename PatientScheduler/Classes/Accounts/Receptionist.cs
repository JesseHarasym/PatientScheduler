namespace PatientScheduler.Classes.Accounts
{
    class Receptionist : AccountBase
    {

        public Receptionist(string name, string username, string password, string email, int staffId) :
            base(name, username, password, email, staffId)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            StaffId = staffId;
            AccessLevel = 0;
        }
    }
}
