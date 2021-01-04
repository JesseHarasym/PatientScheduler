using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule
{
    public partial class ViewAddedHoliday : UserControl
    {
        public ViewAddedHoliday()
        {
            InitializeComponent();
            SetupInitial();
        }

        public void SetupInitial()
        {
            radioModifiedTimes.Checked = true;
        }

        private void radioModifiedTimes_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlHolidayViewChoice.Controls.Clear();
            var vamt = new ViewAllModifiedTimes();
            pnlHolidayViewChoice.Controls.Add(vamt);
        }

        private void radioDaysTakenOff_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlHolidayViewChoice.Controls.Clear();
            var vadto = new ViewAllDaysTakenOff();
            pnlHolidayViewChoice.Controls.Add(vadto);
        }
    }
}
