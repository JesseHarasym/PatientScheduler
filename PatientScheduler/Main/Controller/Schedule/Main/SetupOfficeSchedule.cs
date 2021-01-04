using PatientScheduler.Main.Controller.DataStructures.Schedule;
using PatientScheduler.Main.Controller.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.Controller.Schedule
{
    public class SetupOfficeSchedule
    {
        private DataGridView DataSchedule;

        public SetupOfficeSchedule(DataGridView dataSchedule)
        {
            DataSchedule = dataSchedule;
        }

        //get the weekly schedule for the office
        public DataGridView GetOfficesWeeklySchedule()
        {
            var os = new OfficeScheduleHelper();
            var weeklySchedule = os.GetScheduleData();
            //add the schedule to the calender and return the new data grid
            SetupOfficesWeeklySchedule(weeklySchedule);
            return DataSchedule;
        }

        public void SetupOfficesWeeklySchedule(List<WeeklySchedule> weeklySchedule)
        {
            foreach (var d in weeklySchedule)
            {
                string day = d.Day;
                TimeSpan openTime = d.OpenTime;
                TimeSpan closeTime = d.CloseTime;

                //find which row and column indexes belong to the time and date of each day in the offices weekly schedule
                int rowStart = GetRowIndex(openTime);
                int rowEnd = GetRowIndex(closeTime);
                var colRes = GetColumnIndex(day);
                int col = colRes.Item1;
                bool dayInView = colRes.Item2;  //ensure the date is in view of user

                //if that day of the schedule is currently being viewed by the user
                if (dayInView)
                {
                    try
                    {
                        //add open office color to each index that corresponds with a time or date the office is open
                        for (; rowStart <= rowEnd; rowStart++)
                        {
                            DataSchedule.Rows[rowStart].Cells[col].Style.BackColor = Color.FromArgb(44, 41, 51);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was an issue while loading weekly office schedule " + e);
                    }

                }
            }
        }

        //these functions are not duplicates of SearchSchedule.cs, they search different requirements within the row/columns

        //get the index of the column for the schedules day
        public Tuple<int, bool> GetColumnIndex(string day)
        {
            for (int i = 0; i < DataSchedule.ColumnCount; i++)
            {
                if (DataSchedule.Columns[i].HeaderText.Contains(day))
                {
                    return Tuple.Create(i, true);
                }
            }

            return Tuple.Create(0, false);
        }

        //get the index of the row for the schedules time
        public int GetRowIndex(TimeSpan time)
        {
            string testableTime = MakeTimeGridSearchable(time);

            for (int i = 0; i < DataSchedule.RowCount; i++)
            {
                if (DataSchedule.Rows[i].HeaderCell.Value.ToString() == testableTime)
                {
                    return i;
                }
            }

            return 0;
        }

        //change formatting as needed to ensure the times can match up correctly
        //note: this can be refactored and done with a built in method in TimeSpan
        public string MakeTimeGridSearchable(TimeSpan time)
        {
            string currentAmOrPm;
            int timeHours;

            _ = time.Hours < 12 ? currentAmOrPm = "am" : currentAmOrPm = "pm";
            _ = time.Hours > 12 ? timeHours = time.Hours - 12 : timeHours = time.Hours;

            return $"{timeHours}:{string.Format("{0:00}", time.Minutes)} {currentAmOrPm}";
        }
    }
}
