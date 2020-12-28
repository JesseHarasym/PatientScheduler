using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.ScheduleHelper
{
    public partial class DoctorSchedule : Form
    {
        private List<Doctors> DoctorList;
        public DoctorSchedule(List<Doctors> doctorList)
        {
            InitializeComponent();
            DoctorList = doctorList;
            SetupCombos();
        }

        public void SetupCombos()
        {
            var sd = new StaffData();
            DoctorList = sd.GetAllDoctors();

            //setup doctor information into combo box
            boxDoctorChoice.ValueMember = "StaffId";
            boxDoctorChoice.DisplayMember = "LastName";
            boxDoctorChoice.DataSource = DoctorList;

            //basic combo box styling
            boxDoctorChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDoctorChoice.Region = new Region(new Rectangle(3, 3, boxDoctorChoice.Width - 3, boxDoctorChoice.Height - 6));

            boxWeekChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            boxWeekChoice.Region = new Region(new Rectangle(3, 3, boxDoctorChoice.Width - 3, boxDoctorChoice.Height - 6));

            //ensure first doctors schedule is displayed on load
            boxDoctorChoice.SelectedIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void btnComboDoctor_Click(object sender, System.EventArgs e)
        {
            boxDoctorChoice.DroppedDown = true;
        }

        private void btnComboWeek_Click(object sender, System.EventArgs e)
        {
            boxWeekChoice.DroppedDown = true;
        }
    }
}
