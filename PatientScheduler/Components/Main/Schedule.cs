using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Helper;
using PatientScheduler.Classes.Styling;
using PatientScheduler.Components.Custom;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PatientScheduler.Components.Main
{
    public partial class Schedule : UserControl
    {
        public List<Appointments> AppointmentList = new List<Appointments>();
        public int CurrentDayViewed;

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            ResetAfterSearch();
            GetScheduledAppointments();
        }

        public void GetScheduledAppointments()
        {
            var calender = new Calender(dataSchedule);
            calender.Day = CurrentDayViewed;
            calender.StartTime = new TimeSpan(9, 0, 0);
            calender.EndTime = new TimeSpan(16, 30, 0);
            dataSchedule = calender.CreateCalender();
            SetDateLabel();

            var sd = new ScheduleData();
            AppointmentList = sd.GetDoctorsAppointments();
        }

        private void dataSchedule_SelectionChanged(object sender, EventArgs e)
        {
            dataSchedule.ClearSelection();
        }

        private void dataSchedule_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, false);
            e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
            e.Handled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentDayViewed += 7;
            GetScheduledAppointments();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentDayViewed -= 7;
            GetScheduledAppointments();
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            CurrentDayViewed = 0;
            GetScheduledAppointments();
            ResetAfterSearch();
            var message = new UserMessage();
            message.Show($"Your view has returned to this week.");
        }

        public void SetDateLabel()
        {
            lblThisWeek.Text = $"{DateTime.Today.AddDays(+CurrentDayViewed):MMM dd} - " +
                               $"{DateTime.Today.AddDays(+CurrentDayViewed + 7):MMM dd, yyyy}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var message = new UserMessage();

            string month = txtMonth.Text;
            string day = txtDay.Text;
            string year = txtYear.Text;

            string dateString = FixDateInput(month, day, year);

            if (DateTime.TryParse(dateString, out var dateTime))
            {
                int daysDifference = (dateTime - DateTime.Today).Days;

                CurrentDayViewed = daysDifference;
                GetScheduledAppointments();

                ResetAfterSearch();

                message.Show($"Your {dateTime.ToShortDateString()} has been searched successfully.");
            }
            else
            {
                message.Show($"Your input of {dateString} is not a valid date.");
            }
        }

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

            foreach (var m in monthCheck)
            {
                if (month.ToLower().Contains(m.Key))
                {
                    month = m.Value;
                }
            }

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

        public void ResetAfterSearch()
        {
            txtMonth.Clear();
            txtDay.Clear();
            txtYear.Clear();

            TextBoxStyle.TextBoxEmpty(txtMonth, "month");
            TextBoxStyle.TextBoxEmpty(txtDay, "day");
            TextBoxStyle.TextBoxEmpty(txtYear, "year");
        }

        private void txtMonth_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtMonth, "month");
        }

        private void txtDay_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtDay, "day");
        }

        private void txtYear_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtYear, "year");
        }

        private void txtMonth_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtMonth, "month", e);
        }

        private void txtDay_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtDay, "day", e);
        }

        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtYear, "year", e);
        }
    }
}
