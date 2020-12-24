using PatientScheduler.Classes.Accounts;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components.Main
{
    public partial class CentralScreen : Form
    {
        public StaffAccount Staff;
        public int OffSet = 28;

        public CentralScreen(StaffAccount staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void CentralScreen_Load(object sender, System.EventArgs e)
        {
            lblWelcome.Text = $"{Staff.FirstName} {Staff.LastName} \n\n Username: {Staff.Username}";
            lblPosition.Text = $"{Staff.Position} \n\n Access Level: {Staff.AccessLevel}";
            btnLogo.Enabled = false;
            var home = new Home();
            pnlMain.Controls.Add(home);
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlHome.Height;
            pnlChoice.Top = pnlHome.Top + OffSet;
            pnlMain.Controls.Clear();
            var home = new Home();
            pnlMain.Controls.Add(home);
        }

        private void btnSchedule_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlSchedule.Height;
            pnlChoice.Top = pnlSchedule.Top + OffSet;
            pnlMain.Controls.Clear();
            var schedule = new Schedule();
            pnlMain.Controls.Add(schedule);
        }

        private void btnPatients_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlPatients.Height;
            pnlChoice.Top = pnlPatients.Top + OffSet;
            pnlMain.Controls.Clear();
            var patients = new Patients();
            pnlMain.Controls.Add(patients);
        }

        private void btnStaff_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlStaff.Height;
            pnlChoice.Top = pnlStaff.Top + OffSet;
            pnlMain.Controls.Clear();
            var staff = new Staff();
            pnlMain.Controls.Add(staff);
        }

        private void btnReports_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlReports.Height;
            pnlChoice.Top = pnlReports.Top + OffSet;
            pnlMain.Controls.Clear();
            var reports = new Reports();
            pnlMain.Controls.Add(reports);
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            pnlChoice.Height = pnlSettings.Height;
            pnlChoice.Top = pnlSettings.Top + OffSet;
            pnlMain.Controls.Clear();
            var settings = new Settings();
            pnlMain.Controls.Add(settings);
        }


    }
}
