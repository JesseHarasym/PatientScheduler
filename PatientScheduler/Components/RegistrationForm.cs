using PatientScheduler.Classes.Styling;
using System;
using System.Windows.Forms;

namespace PatientScheduler.Components
{
    public partial class RegistrationForm : Form
    {
        private LoginForm Login;
        public string UsernamePhrase = "Enter your username..";
        public string PasswordPhrase = "Enter your password..";
        public string EmailPhrase = "Enter your email..";
        public string StaffIdPhrase = "Enter your staff Id..";

        public RegistrationForm(LoginForm login)
        {
            InitializeComponent();
            Login = login;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, UsernamePhrase);
            TextBoxStyle.TextBoxEmpty(txtPassword, PasswordPhrase);
            TextBoxStyle.TextBoxEmpty(txtEmail, EmailPhrase);
            TextBoxStyle.TextBoxEmpty(txtStaffId, StaffIdPhrase);
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, UsernamePhrase);
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtPassword, PasswordPhrase);
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtEmail, EmailPhrase);
        }

        private void txtStaffId_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtStaffId, StaffIdPhrase);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtUsername, UsernamePhrase, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtPassword, PasswordPhrase, e);
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtEmail, EmailPhrase, e);
        }

        private void txtStaffId_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtStaffId, StaffIdPhrase, e);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
