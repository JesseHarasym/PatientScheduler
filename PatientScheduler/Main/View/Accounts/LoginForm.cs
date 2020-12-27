using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Styling;
using PatientScheduler.Classes.Validation;
using PatientScheduler.Components;
using PatientScheduler.Components.Custom;
using PatientScheduler.Components.Main;
using PatientScheduler.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            Icon = Resources.StartupIcon;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, "username");
            TextBoxStyle.TextBoxEmpty(txtPassword, "password");
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, "username");
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtPassword, "password");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtUsername, "username", e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtPassword, "password", e);
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CenterToScreen();
            txtUsername.Clear();
            txtPassword.Clear();
            TextBoxStyle.TextBoxEmpty(txtUsername, "username");
            TextBoxStyle.TextBoxEmpty(txtPassword, "password");

            var registrationForm = new RegistrationForm(this);
            registrationForm.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var ad = new AccountsData();
            var sd = new StaffData();
            var message = new UserMessage();

            bool allInputsValid = ValidateInputs(username, password);
            var accountInfo = ad.GetAccountPassword(username, password);
            bool passwordMatch = accountInfo.Item1;
            Int32.TryParse(accountInfo.Item2, out var staffId);

            if (allInputsValid && passwordMatch)
            {
                var staff = sd.GetStaffInformation(staffId, username, password);
                Hide();
                var home = new CentralScreen(staff);
                home.ShowDialog();
            }
            else if (allInputsValid)
            {
                message.Show("Your password does not match the password we have stored for your account.");
            }
        }


        public bool ValidateInputs(string username, string password)
        {
            var ad = new AccountsData();
            var av = new AccountValidation();
            var message = new UserMessage();
            var passwordValidation = av.ValidatePassword(password, password);

            bool uniqueUsername = ad.CheckForExistingUsername(username);
            bool validUsername = av.ValidateUsername(username);
            bool validPassword = passwordValidation.Item2;


            if (!validUsername)
            {
                message.Show("This is not a valid username, please ensure its at least 3 characters and only letters and numbers");
                return false;
            }
            if (uniqueUsername)
            {
                message.Show("This username does not exist, please ensure you're typing it in correctly.");
                return false;
            }
            if (!validPassword)
            {
                message.Show("This is not a valid password, please ensure it is at least 6 characters long.");
                return false;
            }

            return true;
        }
    }
}
