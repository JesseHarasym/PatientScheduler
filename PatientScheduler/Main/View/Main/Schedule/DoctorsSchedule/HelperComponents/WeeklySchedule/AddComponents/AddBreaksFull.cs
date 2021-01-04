using PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.HelperComponents
{
    public partial class AddBreaksFull : UserControl
    {
        public AddBreaksFull()
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
            var dswb = new AddWeeklyBreaks();
            pnlAddBreak.Controls.Add(dswb);
        }

        private void radioSpecificDate_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlAddBreak.Controls.Clear();
            var dssdb = new AddSpecificBreaks();
            pnlAddBreak.Controls.Add(dssdb);
        }
    }
}
