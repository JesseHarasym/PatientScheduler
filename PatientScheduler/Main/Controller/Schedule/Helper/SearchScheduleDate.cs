using System;
using System.Collections.Generic;

namespace PatientScheduler.Classes.Helper
{
    public class SearchScheduleDate
    {
        public string FixDateInput(string month, string day, string year)
        {
            if (month == "month..")
            {
                month = DateTime.Today.Month.ToString();
            }
            if (day == "day..")
            {
                day = DateTime.Today.Day.ToString();
            }
            if (year == "year..")
            {
                year = DateTime.Today.Year.ToString();
            }

            Dictionary<string, string> monthCheck = CreateMonthChecker();

            monthCheck.TryGetValue(month, out month);

            return string.Format("{0}-{1}-{2}", month, day, year);
        }

        public Dictionary<string, string> CreateMonthChecker()
        {
            Dictionary<string, string> monthCheck = new Dictionary<string, string>()
            {
                { "january", "01"},
                { "february", "02"},
                { "march", "03"},
                { "april", "04"},
                { "may", "05"},
                { "june", "06"},
                { "july", "07"},
                { "august", "08"},
                { "september", "09"},
                { "october", "10"},
                { "november", "11"},
                { "december", "12"},
            };

            return monthCheck;
        }

        public Tuple<bool, int, DateTime> CheckIfValidDate(string dateString)
        {
            bool validDate = false;
            int daysDifference = 0;

            if (DateTime.TryParse(dateString, out var dateTime))
            {
                daysDifference = (dateTime - DateTime.Today).Days;
                validDate = true;
            }

            return Tuple.Create(validDate, daysDifference, dateTime);
        }
    }
}
