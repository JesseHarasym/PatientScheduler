using PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.HelperComponents
{
    public partial class AddNewBreak : UserControl
    {
        public AddNewBreak()
        {
            InitializeComponent();
            SetupAddNewBreak();
        }

        public void SetupAddNewBreak()
        {
            radioWeeklyBreak.Checked = true;
        }

        private void radioWeeklyBreak_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlAddBreak.Controls.Clear();
            var dswb = new WeeklyBreaks();
            pnlAddBreak.Controls.Add(dswb);
        }

        private void radioSpecificDate_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlAddBreak.Controls.Clear();
            var dssdb = new SpecifyBreakDate();
            pnlAddBreak.Controls.Add(dssdb);
        }
    }
}
