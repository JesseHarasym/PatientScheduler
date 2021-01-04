using PatientScheduler.Classes.Styling;
using PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    public partial class AddHolidaySchedule : UserControl
    {
        public AddHolidaySchedule()
        {
            InitializeComponent();
            SetupTextBoxes();
            radioModifiedTime.Checked = true;
        }

        private void radioModifiedTime_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlHolidayAddChoice.Controls.Clear();
            var dhmt = new AddModifiedTimes();
            pnlHolidayAddChoice.Controls.Add(dhmt);
        }

        private void radioTakeDayOff_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlHolidayAddChoice.Controls.Clear();
            var dhmdo = new AddDaysOff();
            pnlHolidayAddChoice.Controls.Add(dhmdo);
        }

        public void SetupTextBoxes()
        {
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
