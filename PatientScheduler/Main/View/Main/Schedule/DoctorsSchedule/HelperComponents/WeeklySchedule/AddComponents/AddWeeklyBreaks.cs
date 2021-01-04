using PatientScheduler.Classes.Styling;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents
{
    public partial class AddWeeklyBreaks : UserControl
    {
        public AddWeeklyBreaks()
        {
            InitializeComponent();
            SetupTextBoxes();
            SetupCombos();
        }

        public void SetupTextBoxes()
        {
            TextBoxStyle.TextBoxEmpty(txtBreakStart, "startBreak");
            TextBoxStyle.TextBoxEmpty(txtBreakEnd, "endBreak");
        }

        public void SetupCombos()
        {
            //basic combo box styling
            boxDayChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDayChoice.Region = new Region(new Rectangle(3, 3, boxDayChoice.Width - 3, boxDayChoice.Height - 6));
            boxDayChoice.SelectedIndex = 0;
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

        private void btnComboDoctor_Click(object sender, System.EventArgs e)
        {
            boxDayChoice.DroppedDown = true;
        }
    }
}
