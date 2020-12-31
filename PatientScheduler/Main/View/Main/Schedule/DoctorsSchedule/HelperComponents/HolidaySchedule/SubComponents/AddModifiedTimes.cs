using PatientScheduler.Classes.Styling;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    public partial class AddModifiedTimes : UserControl
    {
        public AddModifiedTimes()
        {
            InitializeComponent();
            SetupTextBoxes();
        }

        public void SetupTextBoxes()
        {
            TextBoxStyle.TextBoxEmpty(txtStartTime, "startTime");
            TextBoxStyle.TextBoxEmpty(txtEndTime, "endTime");
        }

        private void txtStartTime_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtStartTime, "startTime");
        }

        private void txtEndTime_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtEndTime, "endTime");
        }

        private void txtStartTime_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtStartTime, "startTime", e);
        }

        private void txtEndTime_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtEndTime, "endTime", e);
        }
    }
}
