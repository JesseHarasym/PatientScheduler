using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components.Main
{
    public partial class Schedule : UserControl
    {
        public List<Appointments> AppointmentList = new List<Appointments>();
        public Schedule()
        {
            InitializeComponent();
            GetScheduledAppointments();
            CreateCalender();
        }

        public void GetScheduledAppointments()
        {
            var sd = new ScheduleData();
            AppointmentList = sd.GetDoctorsAppointments();
        }

        public void CreateCalender()
        {
            var backColor = Color.FromArgb(44, 41, 51);
            var foreColor = Color.WhiteSmoke;
            dataSchedule.Font = new Font("Century Gothic", 10);
            dataSchedule.DefaultCellStyle.BackColor = backColor;
            dataSchedule.DefaultCellStyle.ForeColor = foreColor;
            dataSchedule.ColumnHeadersDefaultCellStyle.BackColor = backColor;
            dataSchedule.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
            dataSchedule.RowHeadersDefaultCellStyle.BackColor = backColor;
            dataSchedule.RowHeadersDefaultCellStyle.ForeColor = foreColor;
            dataSchedule.EnableHeadersVisualStyles = false;

            for (int i = 0; i < 7; i++)
            {
                var column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = DateTime.Today.AddDays(+i).ToLongDateString();
                column.Name = DateTime.Today.AddDays(+i).ToLongDateString();
                dataSchedule.Columns.Add(column);
                dataSchedule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }

        }

    }
}
