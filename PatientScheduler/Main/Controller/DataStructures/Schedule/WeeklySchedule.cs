using System;

namespace PatientScheduler.Main.Controller.DataStructures.Schedule
{
    //base class used to store weekly schedules into a list
    public class WeeklySchedule
    {
        public string Day;
        public TimeSpan OpenTime;
        public TimeSpan CloseTime;

        public WeeklySchedule(string day, TimeSpan openTime, TimeSpan closeTime)
        {
            Day = day;
            OpenTime = openTime;
            CloseTime = closeTime;
        }
    }
}
