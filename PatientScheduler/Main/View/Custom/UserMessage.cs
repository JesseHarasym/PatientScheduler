using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components.Custom
{
    public partial class UserMessage : Form
    {
        public UserMessage()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        public void Show(string message)
        {
            lblMessage.Text = message;
            ShowDialog();
        }

        private void btnOkay_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
