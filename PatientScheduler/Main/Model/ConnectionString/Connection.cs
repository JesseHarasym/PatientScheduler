using System.Configuration;

namespace PatientScheduler.Classes.Database
{
    static class Connection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["PatientSchedulerConnection"].ConnectionString;
    }
}
