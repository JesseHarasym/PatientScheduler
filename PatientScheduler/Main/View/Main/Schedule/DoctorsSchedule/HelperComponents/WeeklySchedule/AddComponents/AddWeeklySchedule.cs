using PatientScheduler.Classes.Styling;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    public partial class AddWeeklySchedule : UserControl
    {
        public AddWeeklySchedule()
        {
            InitializeComponent();
            SetupTextBoxes();
        }

        public void SetupTextBoxes()
        {
            TextBoxStyle.TextBoxEmpty(txtMondayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtMondayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtTuesdayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtTuesdayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtWednesdayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtWednesdayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtThursdayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtThursdayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtFridayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtFridayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtSaturdayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtSaturdayEnd, "endTime");
            TextBoxStyle.TextBoxEmpty(txtSundayStart, "startTime");
            TextBoxStyle.TextBoxEmpty(txtSundayEnd, "endTime");


        }

        private void txtMondayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtMondayStart, "startTime");
        }

        private void txtMondayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtMondayEnd, "endTime");
        }

        private void txtTuesdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtTuesdayStart, "startTime");
        }

        private void txtTuesdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtTuesdayEnd, "endTime");
        }

        private void txtWednesdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtWednesdayStart, "startTime");
        }

        private void txtWednesdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtWednesdayEnd, "endTime");
        }

        private void txtThursdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtThursdayStart, "startTime");
        }

        private void txtThursdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtThursdayEnd, "endTime");
        }

        private void txtFridayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtFridayStart, "startTime");
        }

        private void txtFridayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtFridayEnd, "endTime");
        }

        private void txtSaturdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSaturdayStart, "startTime");
        }

        private void txtSaturdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSaturdayEnd, "endTime");
        }

        private void txtSundayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSundayStart, "startTime");
        }

        private void txtSundayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSundayEnd, "endTime");
        }

        private void txtMondayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtMondayStart, "startTime", e);
        }

        private void txtMondayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtMondayEnd, "endTime", e);
        }

        private void txtTuesdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtTuesdayStart, "startTime", e);
        }

        private void txtTuesdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtTuesdayEnd, "endTime", e);
        }

        private void txtWednesdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtWednesdayStart, "startTime", e);
        }

        private void txtWednesdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtWednesdayEnd, "endTime", e);
        }

        private void txtThursdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtThursdayStart, "startTime", e);
        }

        private void txtThursdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtThursdayEnd, "endTime", e);
        }

        private void txtFridayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtFridayStart, "startTime", e);
        }

        private void txtFridayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtFridayEnd, "endTime", e);
        }

        private void txtSaturdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSaturdayStart, "startTime", e);
        }

        private void txtSaturdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSaturdayEnd, "endTime", e);
        }

        private void txtSundayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSundayStart, "startTime", e);
        }

        private void txtSundayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSundayEnd, "endTime", e);
        }
    }
}
