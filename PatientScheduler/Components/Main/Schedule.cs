using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Helper;
using PatientScheduler.Classes.Styling;
using PatientScheduler.Components.Custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components.Main
{
    public partial class Schedule : UserControl
    {
        public List<Appointments> AppointmentList = new List<Appointments>();
        public List<Doctors> DoctorList = new List<Doctors>();
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

            var sd = new ScheduleData();
            AppointmentList = sd.GetDoctorsAppointments();

            SetDateLabel();
            SetupDoctorChoices();
        }

        public void SetupDoctorChoices()
        {
            var ad = new AccountsData();
            DoctorList = ad.GetAllDoctors();

            foreach (var d in DoctorList)
            {
                boxDoctorChoice.ValueMember = "StaffId";
                boxDoctorChoice.DisplayMember = "LastName";
                boxDoctorChoice.DataSource = DoctorList;
            }
            boxDoctorChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDoctorChoice.SelectedIndex = 0;
            boxDoctorChoice.Region = new Region(new Rectangle(3, 3, boxDoctorChoice.Width - 3, boxDoctorChoice.Height - 6));

            DoctorScheduleSetup(boxDoctorChoice.SelectedValue.ToString());
        }

        private void btnChangeDoc_Click(object sender, EventArgs e)
        {
            DoctorScheduleSetup(boxDoctorChoice.SelectedValue.ToString());
        }

        public void DoctorScheduleSetup(string selectedDoctor)
        {
            var ss = new ScheduleSetup(dataSchedule, AppointmentList);
            dataSchedule = ss.GetDoctorsSchedule(selectedDoctor);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var message = new UserMessage();

            string month = txtMonth.Text;
            string day = txtDay.Text;
            string year = txtYear.Text;

            var ss = new ScheduleSearch();
            string dateString = ss.FixDateInput(month, day, year);

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

        public void SetDateLabel()
        {
            lblThisWeek.Text = $"{DateTime.Today.AddDays(+CurrentDayViewed):MMM dd} - " +
                               $"{DateTime.Today.AddDays(+CurrentDayViewed + 6):MMM dd, yyyy}";
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            CurrentDayViewed = 0;
            GetScheduledAppointments();
            ResetAfterSearch();
            var message = new UserMessage();
            message.Show($"Your view has returned to this week.");
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

        private void dataSchedule_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //gets rid of selection arrow on grid
            e.PaintBackground(e.CellBounds, false);
            e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
            e.Handled = true;
        }

        private void dataSchedule_SelectionChanged(object sender, EventArgs e)
        {
            dataSchedule.ClearSelection();
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

        private void btnCombo_Click(object sender, EventArgs e)
        {
            boxDoctorChoice.DroppedDown = true;
        }
    }
}
