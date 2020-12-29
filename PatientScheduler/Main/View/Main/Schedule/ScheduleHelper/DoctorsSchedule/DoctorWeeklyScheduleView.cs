using PatientScheduler.Classes.Styling;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    public partial class DoctorWeeklyScheduleView : UserControl
    {
        public DoctorWeeklyScheduleView()
        {
            InitializeComponent();
            SetupTextBoxes();
        }

        public void SetupTextBoxes()
        {
            TextBoxStyle.TextBoxEmpty(txtMondayStart, "startMonday");
            TextBoxStyle.TextBoxEmpty(txtMondayEnd, "endMonday");
            TextBoxStyle.TextBoxEmpty(txtTuesdayStart, "startTuesday");
            TextBoxStyle.TextBoxEmpty(txtTuesdayEnd, "endTuesday");
            TextBoxStyle.TextBoxEmpty(txtWednesdayStart, "startWednesday");
            TextBoxStyle.TextBoxEmpty(txtWednesdayEnd, "endWednesday");
            TextBoxStyle.TextBoxEmpty(txtThursdayStart, "startThursday");
            TextBoxStyle.TextBoxEmpty(txtThursdayEnd, "endThursday");
            TextBoxStyle.TextBoxEmpty(txtFridayStart, "startFriday");
            TextBoxStyle.TextBoxEmpty(txtFridayEnd, "endFriday");
            TextBoxStyle.TextBoxEmpty(txtSaturdayStart, "startSaturday");
            TextBoxStyle.TextBoxEmpty(txtSaturdayEnd, "endSaturday");
            TextBoxStyle.TextBoxEmpty(txtSundayStart, "startSunday");
            TextBoxStyle.TextBoxEmpty(txtSundayEnd, "endSunday");
            TextBoxStyle.TextBoxEmpty(txtBreakStart, "startBreak");
            TextBoxStyle.TextBoxEmpty(txtBreakEnd, "endBreak");

            boxDayChoice.Region = new Region(new Rectangle(3, 3, boxDayChoice.Width - 3, boxDayChoice.Height - 6));
        }

        private void txtMondayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtMondayStart, "startMonday");
        }

        private void txtMondayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtMondayEnd, "endMonday");
        }

        private void txtTuesdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtTuesdayStart, "startTuesday");
        }

        private void txtTuesdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtTuesdayEnd, "endTuesday");
        }

        private void txtWednesdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtWednesdayStart, "startWednesday");
        }

        private void txtWednesdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtWednesdayEnd, "endWednesday");
        }

        private void txtThursdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtThursdayStart, "startThursday");
        }

        private void txtThursdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtThursdayEnd, "endThursday");
        }

        private void txtFridayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtFridayStart, "startFriday");
        }

        private void txtFridayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtFridayEnd, "endFriday");
        }

        private void txtSaturdayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSaturdayStart, "startSaturday");
        }

        private void txtSaturdayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSaturdayEnd, "endSaturday");
        }

        private void txtSundayStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSundayStart, "startSunday");
        }

        private void txtSundayEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtSundayEnd, "endSunday");
        }

        private void txtMondayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtMondayStart, "startMonday", e);
        }

        private void txtMondayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtMondayEnd, "endMonday", e);
        }

        private void txtTuesdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtTuesdayStart, "startTuesday", e);
        }

        private void txtTuesdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtTuesdayEnd, "endTuesday", e);
        }

        private void txtWednesdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtWednesdayStart, "startWednesday", e);
        }

        private void txtWednesdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtWednesdayEnd, "endWednesday", e);
        }

        private void txtThursdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtThursdayStart, "startThursday", e);
        }

        private void txtThursdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtThursdayEnd, "endThursday", e);
        }

        private void txtFridayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtFridayStart, "startFriday", e);
        }

        private void txtFridayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtFridayEnd, "endFriday", e);
        }

        private void txtSaturdayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSaturdayStart, "startSaturday", e);
        }

        private void txtSaturdayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSaturdayEnd, "endSaturday", e);
        }

        private void txtSundayStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSundayStart, "startSunday", e);
        }

        private void txtSundayEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtSundayEnd, "endSunday", e);
        }

        private void txtBreakStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtBreakStart, "startBreak");
        }

        private void txtBreakEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtBreakEnd, "endBreak");
        }

        private void txtBreakStart_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtBreakStart, "startBreak", e);
        }

        private void txtBreakEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtBreakEnd, "endBreak", e);
        }
    }
}
