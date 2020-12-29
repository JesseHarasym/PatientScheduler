using PatientScheduler.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Helper
{
    public class SetupDoctorsAppointment
    {
        private DataGridView DataSchedule;
        private List<Appointments> AppointmentList;

        public SetupDoctorsAppointment(DataGridView dataSchedule, List<Appointments> appointmentList)
        {
            AppointmentList = appointmentList;
            DataSchedule = dataSchedule;
        }

        public DataGridView GetDoctorsAppointments(string selectedDoctor)
        {
            List<Appointments> doctorsAppointments = new List<Appointments>();

            foreach (var a in AppointmentList)
            {
                if (a.DoctorId.ToString() == selectedDoctor)
                {
                    doctorsAppointments.Add(a);
                }
            }

            SetupDocAppointments(doctorsAppointments);
            return DataSchedule;
        }

        public void SetupDocAppointments(List<Appointments> doctorsAppointments)
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
                        try
                        {
                            DataSchedule.Rows[row + i].Cells[col].Style.BackColor = SetupAppointmentColor(a.Classification);
                            //need to create patient tables and then retrieve name val
                            DataSchedule[col, row].Value = a.PatientId;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("There was an issue while loading doctors appointments " + e);
                        }

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

        public Color SetupAppointmentColor(string classification)
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

        //this function allows the default back color to return before each doctor selection so that we have a fresh background to work with
        public void ResetDatGrid()
        {
            for (int i = 0; i < DataSchedule.ColumnCount; i++)
            {
                for (int j = 0; j < DataSchedule.RowCount; j++)
                {
                    DataSchedule.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(44, 41, 51);
                    DataSchedule[i, j].Value = "";
                }
            }
        }
    }
}
