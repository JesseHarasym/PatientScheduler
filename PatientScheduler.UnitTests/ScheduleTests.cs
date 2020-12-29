using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientScheduler.Classes.Helper;
using PatientScheduler.Main.Controller.DataStructures.Schedule;
using PatientScheduler.Main.Controller.Helper;
using System;
using System.Collections.Generic;

namespace PatientScheduler.UnitTests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void ScheduleSearch_ValidFixDateInput_ReturnsAreEqual()
        {
            var ss = new SearchScheduleDate();
            string dateString = ss.FixDateInput("april", "26", "2020");
            Assert.AreEqual(dateString, "04-26-2020");
        }

        [TestMethod]
        public void ScheduleSearch_InvalidFixDateInput_ReturnsAreNotEqual()
        {
            var ss = new SearchScheduleDate();
            string dateString = ss.FixDateInput("april", "26", "2020");
            Assert.AreNotEqual(dateString, "april-26-2020");
        }

        [TestMethod]
        public void ScheduleSearch_ValidCheckIfValidDate_ReturnsTrue()
        {
            var ss = new SearchScheduleDate();
            var checkResponse = ss.CheckIfValidDate("04-26-2020");
            bool validDate = checkResponse.Item1;
            Assert.IsTrue(validDate);
        }

        [TestMethod]
        public void ScheduleSearch_InvalidCheckIfValidDate_ReturnsFalse()
        {
            var ss = new SearchScheduleDate();
            var checkResponse = ss.CheckIfValidDate("13-26-2020");
            bool validDate = checkResponse.Item1;
            Assert.IsFalse(validDate);
        }

        [TestMethod]
        public void ScheduleSearch_ValidMonthChecker_ReturnsAreEqual()
        {
            var ss = new SearchScheduleDate();
            Dictionary<string, string> monthCheck = ss.CreateMonthChecker();
            monthCheck.TryGetValue("april", out string month);
            Assert.AreEqual("04", month);
        }

        [TestMethod]
        public void ScheduleSearch_InvalidMonthChecker_ReturnsAreNotEqual()
        {
            var ss = new SearchScheduleDate();
            Dictionary<string, string> monthCheck = ss.CreateMonthChecker();
            monthCheck.TryGetValue("april", out string month);
            Assert.AreNotEqual("05", month);
        }

        public List<WeeklySchedule> ScheduleMockData()
        {
            List<WeeklySchedule> weeklySchedule = new List<WeeklySchedule>();
            weeklySchedule.Add(new WeeklySchedule("Monday", TimeSpan.Parse("10:30"), TimeSpan.Parse("16:30")));
            weeklySchedule.Add(new WeeklySchedule("Tuesday", TimeSpan.Parse("9:30"), TimeSpan.Parse("13:30")));
            weeklySchedule.Add(new WeeklySchedule("Wednesday", TimeSpan.Parse("10:30"), TimeSpan.Parse("16:00")));
            weeklySchedule.Add(new WeeklySchedule("Thursday", TimeSpan.Parse("8:00"), TimeSpan.Parse("13:30")));
            weeklySchedule.Add(new WeeklySchedule("Friday", TimeSpan.Parse("11:30"), TimeSpan.Parse("17:00")));
            return weeklySchedule;
        }

        [TestMethod]
        public void OfficeSchedule_ValidEarliestTime_ReturnsAreEqual()
        {
            TimeSpan expectedEarliest = new TimeSpan(8, 0, 0);
            List<WeeklySchedule> weeklySchedule = ScheduleMockData();
            var os = new OfficeScheduleHelper();
            TimeSpan earliestTime = os.GetEarliestStartTime(weeklySchedule);
            Assert.AreEqual(expectedEarliest, earliestTime);
        }

        [TestMethod]
        public void OfficeSchedule_InvalidEarliestTime_ReturnsAreNotEqual()
        {
            TimeSpan expectedEarliest = new TimeSpan(9, 30, 0);
            List<WeeklySchedule> weeklySchedule = ScheduleMockData();
            var os = new OfficeScheduleHelper();
            TimeSpan earliestTime = os.GetEarliestStartTime(weeklySchedule);
            Assert.AreNotEqual(expectedEarliest, earliestTime);
        }

        [TestMethod]
        public void OfficeSchedule_ValidLatestTime_ReturnsAreEqual()
        {
            TimeSpan expectedLatest = new TimeSpan(17, 0, 0);
            List<WeeklySchedule> weeklySchedule = ScheduleMockData();
            var os = new OfficeScheduleHelper();
            TimeSpan latestTime = os.GetLatestEndTime(weeklySchedule);
            Assert.AreEqual(expectedLatest, latestTime);
        }
        [TestMethod]
        public void OfficeSchedule_InvalidLatestTime_ReturnsAreNotEqual()
        {
            TimeSpan expectedLatest = new TimeSpan(16, 30, 0);
            List<WeeklySchedule> weeklySchedule = ScheduleMockData();
            var os = new OfficeScheduleHelper();
            TimeSpan latestTime = os.GetLatestEndTime(weeklySchedule);
            Assert.AreNotEqual(expectedLatest, latestTime);
        }
    }
}
