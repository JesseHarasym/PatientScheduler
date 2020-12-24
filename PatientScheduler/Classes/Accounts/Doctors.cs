namespace PatientScheduler.Classes.Accounts
{
    public class Doctors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int StaffId { get; set; }
        public int AccessLevel { get; set; }
        public Doctors(string firstName, string lastName, string email, string position, int staffId, int accessLevel)

        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            StaffId = staffId;
            AccessLevel = accessLevel;
        }
    }
}
