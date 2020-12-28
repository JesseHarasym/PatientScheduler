using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Helper;
using PatientScheduler.Classes.Styling;
using PatientScheduler.Components.Custom;
using PatientScheduler.Main.View.ScheduleHelper;
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
        public string CurrentDoctor;

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            ResetAfterSearch();
            SetupDoctorInitial();
            GetScheduledAppointments();
        }

        public void GetScheduledAppointments()
        {
            var calender = new Calender(dataSchedule);
            calender.Day = CurrentDayViewed;
            dataSchedule = calender.CreateCalender();

            var sd = new ScheduleData();
            AppointmentList = sd.GetDoctorsAppointments();

            SampleData();
            SetDateLabel();
            DoctorScheduleSetup();
        }

        public void SetupDoctorInitial()
        {
            var sd = new StaffData();
            DoctorList = sd.GetAllDoctors();

            //setup doctor information into combo box
            boxDoctorChoice.ValueMember = "StaffId";
            boxDoctorChoice.DisplayMember = "LastName";
            boxDoctorChoice.DataSource = DoctorList;

            //basic combo box styling
            boxDoctorChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDoctorChoice.Region = new Region(new Rectangle(3, 3, boxDoctorChoice.Width - 3, boxDoctorChoice.Height - 6));

            //ensure first doctors schedule is displayed on load
            boxDoctorChoice.SelectedIndex = 0;
        }

        private void boxDoctorChoice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoctorScheduleSetup();
            var message = new UserMessage();
            message.Show($"You are now viewing {CurrentDoctor} schedule");
        }

        public void DoctorScheduleSetup()
        {
            CurrentDoctor = boxDoctorChoice.SelectedValue.ToString();
            var ss = new SetupSchedule(dataSchedule, AppointmentList);
            dataSchedule = ss.GetDoctorsSchedule(CurrentDoctor);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var message = new UserMessage();

            string month = txtMonth.Text;
            string day = txtDay.Text;
            string year = txtYear.Text;

            var ss = new SearchSchedule();
            string dateString = ss.FixDateInput(month, day, year);
            var validReturns = ss.CheckIfValidDate(dateString);
            bool validDate = validReturns.Item1;
            int daysDifference = validReturns.Item2;
            DateTime dateTime = validReturns.Item3;

            if (validDate)
            {
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

        private void btnDoctorSchedule_Click(object sender, EventArgs e)
        {
            var ds = new DoctorSchedule(DoctorList);
            ds.ShowDialog();
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

        //temp function for data to test with
        public void SampleData()
        {
            var rand = new Random();
            //Follow up, diagnoses, new patient, illness, lab work, other
            List<string> legend = new List<string>();
            legend.Add("Follow up");
            legend.Add("Diagnoses");
            legend.Add("New Patient");
            legend.Add("Illness");
            legend.Add("Lab Work");
            legend.Add("Other");


            for (int days = -365; days < 365; days++)
            {
                for (int i = 0; i < 7; i++)
                {
                    int classification = rand.Next(legend.Count);
                    int r = rand.Next(-15, 15);
                    int rt = rand.Next(0, 2);
                    int pid = rand.Next(15, 255);
                    AppointmentList.Add(new Appointments(100 + i + days, 2, pid, "", DateTime.Today.AddDays(days) + new TimeSpan(9 + i, 15 + (rt * 15), 0), 1, legend[classification], 45 + r));
                }
            }
        }
    }
}
