using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using PatientScheduler.Main.Controller.DataStructures.Schedule;
using PatientScheduler.Main.View.Main.Schedule.ScheduleHelper;
using PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.ScheduleHelper
{
    public partial class DoctorSchedule : Form
    {
        private List<Doctors> DoctorList;
        public DoctorSchedule(List<Doctors> doctorList)
        {
            InitializeComponent();
            DoctorList = doctorList;
            SetupCombos();
            LoadWeeklyOfficeSchedule();
        }

        private void DoctorSchedule_Load(object sender, System.EventArgs e)
        {
            radioWeeklySchedule.Checked = true;
        }

        public void SetupCombos()
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

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void btnComboDoctor_Click(object sender, System.EventArgs e)
        {
            boxDoctorChoice.DroppedDown = true;
        }

        private void radioWeeklySchedule_CheckedChanged(object sender, System.EventArgs e)
        {
            ClearPanels();
            var dwsv = new DoctorWeeklyScheduleView();
            pnlSchedule.Controls.Add(dwsv);
            var dabv = new DoctorAddedBreaksView();
            pnlSeeBreaks.Controls.Add(dabv);
            pnlSchedule.Width = 696;
            pnlSeeBreaks.Show();
        }

        private void radioSpecialSchedule_CheckedChanged(object sender, System.EventArgs e)
        {
            ClearPanels();
            var dssv = new DoctorHolidayScheduleView();
            pnlSchedule.Controls.Add(dssv);
            pnlSchedule.Width = 1030;
            pnlSeeBreaks.Hide();
        }

        public void ClearPanels()
        {
            pnlSchedule.Controls.Clear();
            pnlSeeBreaks.Controls.Clear();
        }

        public void LoadWeeklyOfficeSchedule()
        {
            var sd = new ScheduleData();
            List<WeeklySchedule> weeklyOfficeSchedule = sd.GetOfficeWeeklySchedule();

            foreach (var day in weeklyOfficeSchedule)
            {
                string scheduleDay = day.Day;
                DateTime open = DateTime.Today.Add(day.OpenTime);
                DateTime close = DateTime.Today.Add(day.CloseTime);
                string openTime = open.ToString("hh:mm tt").ToLower();
                string closeTime = close.ToString("hh:mm tt").ToLower();

                switch (day.Day)
                {

                    case "Monday":
                        DisplayDaysSchedule(lblMonday, scheduleDay, openTime, closeTime);
                        break;
                    case "Tuesday":
                        DisplayDaysSchedule(lblTuesday, scheduleDay, openTime, closeTime);
                        break;
                    case "Wednesday":
                        DisplayDaysSchedule(lblWednesday, scheduleDay, openTime, closeTime);
                        break;
                    case "Thursday":
                        DisplayDaysSchedule(lblThursday, scheduleDay, openTime, closeTime);
                        break;
                    case "Friday":
                        DisplayDaysSchedule(lblFriday, scheduleDay, openTime, closeTime);
                        break;
                    case "Saturday":
                        DisplayDaysSchedule(lblSaturday, scheduleDay, openTime, closeTime);
                        break;
                    case "Sunday":
                        DisplayDaysSchedule(lblSunday, scheduleDay, openTime, closeTime);
                        break;
                }
            }
        }

        public void DisplayDaysSchedule(Label lblDay, string day, string openTime, string closeTime)
        {
            lblDay.Text = $"{day}: {openTime} to {closeTime}";
        }
    }
}
