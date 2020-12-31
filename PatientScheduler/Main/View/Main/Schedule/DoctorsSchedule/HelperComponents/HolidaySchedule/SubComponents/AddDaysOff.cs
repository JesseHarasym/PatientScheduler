using PatientScheduler.Classes.Styling;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    public partial class AddDaysOff : UserControl
    {
        public AddDaysOff()
        {
            InitializeComponent();
            TextBoxStyle.TextBoxEmpty(txtDaysOff, "daysOff");
        }

        private void txtDaysOff_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtDaysOff, "daysOff");
        }

        private void txtDaysOff_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtDaysOff, "daysOff", e);
        }
    }
}
