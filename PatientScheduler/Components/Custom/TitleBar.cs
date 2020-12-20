using PatientScheduler.Classes.Styling;
using System;
using System.Windows.Forms;

namespace PatientScheduler.Components
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Classes.Styling.TitleBarStyle.ExitProgram();
        }

        private void lblTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Classes.Styling.TitleBarStyle.MoveTitleBar(e, Parent.Handle);
        }
    }
}
