using PatientScheduler.Main.Controller.DataStructures.Schedule;
using PatientScheduler.Main.Controller.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Helper
{
    class Calender
    {
        private DataGridView DataSchedule;
        public Color OpenColor = Color.FromArgb(44, 41, 51);
        public Color ClosedColor = Color.FromArgb(68, 66, 74);
        public Color ForeColor = Color.WhiteSmoke;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Day { get; set; }

        public Calender(DataGridView dataSchedule)
        {
            DataSchedule = dataSchedule;
            DataSchedule.MouseWheel += MouseWheel;
            GetOfficeSchedule();
        }

        public DataGridView CreateCalender()
        {
            CalenderStyle();
            CalenderColumnSetup(Day);   //this day is set as our offset for which days to show (how many days from today's date)
            CalenderRowSetup();

            return DataSchedule;
        }

        //get office schedule so we know when the start and end time should be for the calender view 
        //calender only shows the timers in which their is a reason to, ei: scheduled appointments, open/close time, special scheduling
        public void GetOfficeSchedule()
        {
            var os = new OfficeScheduleHelper();
            List<WeeklySchedule> weeklySchedule = os.GetScheduleData();
            StartTime = os.GetEarliestStartTime(weeklySchedule);
            EndTime = os.GetLatestEndTime(weeklySchedule);
        }

        //the setup for column information (which is the date shown) for our custom calender component
        public void CalenderColumnSetup(int day)
        {
            //remove all previously shown information every time a new calender view is created
            DataSchedule.Columns.Clear();
            DataSchedule.Rows.Clear();
            DataSchedule.Refresh();

            //loop through 7 days from the date provided in parameter (calender is currently only a 7 day view)
            for (int i = 0; i < 7; i++)
            {
                var column = new DataGridViewTextBoxColumn();
                //make property and viewed name as the day we're currently on while looping
                column.DataPropertyName = DateTime.Today.AddDays(+day).ToLongDateString();
                column.Name = $"{DateTime.Today.AddDays(+day):dddd\nMMM dd}";
                //add this newly made column to our data grid
                DataSchedule.Columns.Add(column);
                //Auto Size these to fit in our data grid component
                DataSchedule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //don't allow click able sorting 
                DataSchedule.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                day += 1;
            }

            CalenderColumnStyle();
        }

        //setup the calenders rows (which are the time view for our calender)
        //note: this can eventually be replaced with TimeSpans built in Am/Pm functions to refactor
        public void CalenderRowSetup()
        {
            string currentAmOrPm;
            int currentHours = StartTime.Hours;
            int currentMinutes = StartTime.Minutes;
            int count = 0;

            for (; currentHours <= EndTime.Hours; currentHours++)
            {
                _ = currentHours < 12 ? currentAmOrPm = "am" : currentAmOrPm = "pm";

                for (; currentMinutes < 60; currentMinutes += 15)
                {
                    TimeSpan currentTime = new TimeSpan(currentHours, currentMinutes, 0);
                    TimeSpan endTime = new TimeSpan(EndTime.Hours, EndTime.Minutes, 0);

                    if (endTime >= currentTime)
                    {
                        DataSchedule.RowCount = DataSchedule.RowCount + 1;

                        int hours;
                        _ = currentHours < 13 ? hours = currentHours : hours = currentHours - 12;

                        string time = $"{hours}:{string.Format("{0:00}", currentMinutes)} {currentAmOrPm}";

                        DataSchedule.Rows[count].HeaderCell.Value = time;
                        count++;
                    }
                }
                currentMinutes = 0;
            }
            CalenderRowStyle();
        }

        //allows users to scroll with wheel since scrollbar is hidden
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && DataSchedule.FirstDisplayedScrollingRowIndex > 0)
            {
                DataSchedule.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                DataSchedule.FirstDisplayedScrollingRowIndex++;
            }
        }

        //all styles for the calender not directly related to columns or rows
        public void CalenderStyle()
        {
            //buffer to try to control flickering, large customizations of data grid has started to cause weird rendering issues
            typeof(Control)
                .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(DataSchedule, true, null);

            //basic color styling
            DataSchedule.Font = new Font("Century Gothic", 10);
            DataSchedule.DefaultCellStyle.BackColor = ClosedColor;
            DataSchedule.DefaultCellStyle.ForeColor = ForeColor;
            DataSchedule.DefaultCellStyle.SelectionBackColor = ClosedColor;
            DataSchedule.DefaultCellStyle.SelectionForeColor = ForeColor;
            //usability styling
            DataSchedule.ReadOnly = true;
            DataSchedule.ScrollBars = ScrollBars.None;
        }

        //basic column styling for calender
        public void CalenderColumnStyle()
        {
            //cell border styling
            DataSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            //column header styling
            DataSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataSchedule.ColumnHeadersDefaultCellStyle.BackColor = OpenColor;
            DataSchedule.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;
            //user interaction styling
            DataSchedule.EnableHeadersVisualStyles = false;
            DataSchedule.AllowUserToResizeColumns = false;
            DataSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }

        //basic row styling for calender
        public void CalenderRowStyle()
        {
            //basic row sizing
            DataSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataSchedule.RowHeadersWidth = 120;
            //cell style color styling
            DataSchedule.RowHeadersDefaultCellStyle.BackColor = OpenColor;
            DataSchedule.RowHeadersDefaultCellStyle.ForeColor = ForeColor;
            //user usability styling
            DataSchedule.AllowUserToAddRows = false;
            DataSchedule.AllowUserToResizeRows = false;
            DataSchedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }
    }
}
