using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Helper
{
    class Calender
    {
        private DataGridView DataSchedule;
        public Color BackColor = Color.FromArgb(44, 41, 51);
        public Color ForeColor = Color.WhiteSmoke;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Day { get; set; }

        public Calender(DataGridView dataSchedule)
        {
            DataSchedule = dataSchedule;
            DataSchedule.MouseWheel += MouseWheel;
        }

        public DataGridView CreateCalender()
        {
            CalenderStyle();
            CalenderColumnSetup(Day);
            CalenderRowSetup();

            return DataSchedule;
        }

        public void CalenderColumnSetup(int day)
        {
            DataSchedule.Columns.Clear();
            DataSchedule.Rows.Clear();
            DataSchedule.Refresh();
            for (int i = 0; i < 7; i++)
            {
                var column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = DateTime.Today.AddDays(+day).ToLongDateString();
                column.Name = $"{DateTime.Today.AddDays(+day):dddd\nMMM dd}";
                DataSchedule.Columns.Add(column);
                DataSchedule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                day += 1;
            }

            CalenderColumnStyle();
        }

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

        public void CalenderStyle()
        {
            typeof(Control)
                .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(DataSchedule, true, null);

            DataSchedule.Font = new Font("Century Gothic", 10);
            DataSchedule.DefaultCellStyle.BackColor = BackColor;
            DataSchedule.DefaultCellStyle.ForeColor = ForeColor;
            DataSchedule.DefaultCellStyle.SelectionBackColor = BackColor;
            DataSchedule.DefaultCellStyle.SelectionForeColor = ForeColor;
            DataSchedule.ReadOnly = true;
            DataSchedule.ScrollBars = ScrollBars.None;
        }

        public void CalenderColumnStyle()
        {
            DataSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataSchedule.ColumnHeadersDefaultCellStyle.BackColor = BackColor;
            DataSchedule.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;
            DataSchedule.EnableHeadersVisualStyles = false;
            DataSchedule.AllowUserToResizeColumns = false;
            DataSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }

        public void CalenderRowStyle()
        {
            DataSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataSchedule.RowHeadersWidth = 120;
            DataSchedule.RowHeadersDefaultCellStyle.BackColor = BackColor;
            DataSchedule.RowHeadersDefaultCellStyle.ForeColor = ForeColor;
            DataSchedule.AllowUserToAddRows = false;
            DataSchedule.AllowUserToResizeRows = false;
            DataSchedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }
    }
}
