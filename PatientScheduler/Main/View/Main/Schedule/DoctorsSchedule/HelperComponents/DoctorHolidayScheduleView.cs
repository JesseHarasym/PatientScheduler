using PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    public partial class DoctorHolidayScheduleView : UserControl
    {
        public DoctorHolidayScheduleView()
        {
            InitializeComponent();
            radioModifiedTime.Checked = true;
        }

        private void radioModifiedTime_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlChoice.Controls.Clear();
            var dhmt = new DoctorHolidayModifiedTimes();
            pnlChoice.Controls.Add(dhmt);
        }

        private void radioTakeDayOff_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlChoice.Controls.Clear();
            var dhmdo = new DoctorHolidayModifiedDaysOff();
            pnlChoice.Controls.Add(dhmdo);
        }
    }
}
