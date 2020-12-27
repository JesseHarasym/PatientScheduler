using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientScheduler.Classes.Helper;
using System.Collections.Generic;

namespace PatientScheduler.UnitTests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void ScheduleSearch_ValidFixDateInput_ReturnsAreEqual()
        {
            var ss = new ScheduleSearch();
            string dateString = ss.FixDateInput("april", "26", "2020");
            Assert.AreEqual(dateString, "04-26-2020");
        }

        [TestMethod]
        public void ScheduleSearch_InvalidFixDateInput_ReturnsAreNotEqual()
        {
            var ss = new ScheduleSearch();
            string dateString = ss.FixDateInput("april", "26", "2020");
            Assert.AreNotEqual(dateString, "april-26-2020");
        }

        [TestMethod]
        public void ScheduleSearch_ValidCheckIfValidDate_ReturnsTrue()
        {
            var ss = new ScheduleSearch();
            var checkResponse = ss.CheckIfValidDate("04-26-2020");
            bool validDate = checkResponse.Item1;
            Assert.IsTrue(validDate);
        }

        [TestMethod]
        public void ScheduleSearch_InvalidCheckIfValidDate_ReturnsFalse()
        {
            var ss = new ScheduleSearch();
            var checkResponse = ss.CheckIfValidDate("13-26-2020");
            bool validDate = checkResponse.Item1;
            Assert.IsFalse(validDate);
        }

        [TestMethod]
        public void ScheduleSearch_ValidMonthChecker_ReturnsAreEqual()
        {
            var ss = new ScheduleSearch();
            Dictionary<string, string> monthCheck = ss.CreateMonthChecker();
            monthCheck.TryGetValue("april", out string month);
            Assert.AreEqual("04", month);
        }

        [TestMethod]
        public void ScheduleSearch_InvalidMonthChecker_ReturnsAreNotEqual()
        {
            var ss = new ScheduleSearch();
            Dictionary<string, string> monthCheck = ss.CreateMonthChecker();
            monthCheck.TryGetValue("april", out string month);
            Assert.AreNotEqual("05", month);
        }
    }
}
