using System.Windows.Forms;

namespace PatientScheduler.Components.Main
{
    public partial class Home : UserControl
    {
        private LoginForm Login;

        public Home(LoginForm login)
        {
            InitializeComponent();
            Login = login;
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            ParentForm.Dispose();
            Login.Show();
        }
    }
}
