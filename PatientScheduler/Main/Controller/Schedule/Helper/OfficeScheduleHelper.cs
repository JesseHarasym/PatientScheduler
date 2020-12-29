using PatientScheduler.Classes.Database;
using PatientScheduler.Main.Controller.DataStructures.Schedule;
using System;
using System.Collections.Generic;

namespace PatientScheduler.Main.Controller.Helper
{
    public class OfficeScheduleHelper
    {
        public List<WeeklySchedule> GetScheduleData()
        {
            var sd = new ScheduleData();
            List<WeeklySchedule> weeklySchedule = sd.GetOfficeWeeklySchedule();
            return weeklySchedule;
        }

        public TimeSpan GetEarliestStartTime(List<WeeklySchedule> weeklySchedule)
        {
            TimeSpan earliestTime = new TimeSpan(0, 0, 0);

            foreach (var day in weeklySchedule)
            {
                if (day.Day == "Monday")
                {
                    earliestTime = day.OpenTime;
                }
                else if (day.OpenTime < earliestTime)
                {
                    earliestTime = day.OpenTime;
                }
            }

            return earliestTime;
        }

        public TimeSpan GetLatestEndTime(List<WeeklySchedule> weeklySchedule)
        {
            TimeSpan latestTime = new TimeSpan(0, 0, 0);

            foreach (var day in weeklySchedule)
            {
                if (day.Day == "Monday")
                {
                    latestTime = day.CloseTime;
                }
                else if (day.CloseTime > latestTime)
                {
                    latestTime = day.CloseTime;
                }
            }

            return latestTime;
        }
    }
}
