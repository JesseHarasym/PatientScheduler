using PatientScheduler.Classes.Styling;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents
{
    public partial class AddSpecificBreaks : UserControl
    {
        public AddSpecificBreaks()
        {
            InitializeComponent();
            SetupTextBoxes();
        }

        public void SetupTextBoxes()
        {
            TextBoxStyle.TextBoxEmpty(txtMonth, "month");
            TextBoxStyle.TextBoxEmpty(txtDay, "day");
            TextBoxStyle.TextBoxEmpty(txtYear, "year");
            TextBoxStyle.TextBoxEmpty(txtBreakStart, "startBreak");
            TextBoxStyle.TextBoxEmpty(txtBreakEnd, "endBreak");
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

        private void txtBreakStart_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtBreakStart, "startBreak");
        }

        private void txtBreakEnd_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtBreakEnd, "endBreak");
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
