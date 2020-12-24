using PatientScheduler.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Helper
{
    public class ScheduleSetup
    {
        private DataGridView DataSchedule;
        private List<Appointments> AppointmentList;

        public ScheduleSetup(DataGridView dataSchedule, List<Appointments> appointmentList)
        {
            AppointmentList = appointmentList;
            DataSchedule = dataSchedule;
        }

        public DataGridView GetDoctorsSchedule(string selectedDoctor)
        {
            List<Appointments> doctorsAppointments = new List<Appointments>();

            foreach (var a in AppointmentList)
            {
                if (a.DoctorId.ToString() == selectedDoctor)
                {
                    doctorsAppointments.Add(a);
                }
            }
            SetupDoctorsSchedule(doctorsAppointments);
            return DataSchedule;
        }

        public void SetupDoctorsSchedule(List<Appointments> doctorsAppointments)
        {
            foreach (var a in doctorsAppointments)
            {
                string date = a.AppointmentDate.ToLongDateString();
                string time = a.AppointmentDate.ToShortTimeString().ToLower();

                int row = GetRowIndex(time);
                var colRes = GetColumnIndex(date);
                int col = colRes.Item1;
                bool dateFound = colRes.Item2;  //ensure the date is in view of user

                int length = a.AppointmentLength / 15;  //because calender shows in 15 minute intervals

                if (dateFound)
                {
                    for (int i = 0; i < length; i++)
                    {
                        DataSchedule.Rows[row + i].Cells[col].Style.BackColor = AppointmentColorSetup(a.Classification);

                        //need to create patient tables and then retrieve name val
                        DataSchedule.Rows[row].SetValues(a.PatientId);
                    }
                }
            }
        }

        public Tuple<int, bool> GetColumnIndex(string date)
        {
            for (int i = 0; i < DataSchedule.ColumnCount; i++)
            {
                if (DataSchedule.Columns[i].DataPropertyName == date)
                {
                    return Tuple.Create(i, true);
                }
            }

            return Tuple.Create(0, false);
        }

        public int GetRowIndex(string time)
        {
            for (int i = 0; i < DataSchedule.RowCount; i++)
            {
                if (DataSchedule.Rows[i].HeaderCell.Value.ToString() == $"{time}")
                {
                    return i;
                }
            }

            return 0;
        }


        public Color AppointmentColorSetup(string classification)
        {
            Color apptColor = Color.LightSlateGray;

            switch (classification)
            {
                case "Follow up":
                    apptColor = Color.MediumSlateBlue;
                    break;
                case "Illness":
                    apptColor = Color.DeepSkyBlue;
                    break;
                case "Diagnoses":
                    apptColor = Color.MediumTurquoise;
                    break;
                case "Lab Work":
                    apptColor = Color.LimeGreen;
                    break;
                case "New Patient":
                    apptColor = Color.LightSalmon;
                    break;
                case "Other":
                    apptColor = Color.IndianRed;
                    break;
            }

            return apptColor;
        }
    }
}
