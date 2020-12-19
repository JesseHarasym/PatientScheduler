using PatientScheduler.Classes.Styling;
using PatientScheduler.Components;
using System;
using System.Windows.Forms;

namespace PatientScheduler
{
    public partial class LoginForm : Form
    {
        public string UsernamePhrase = "Enter your username..";
        public string PasswordPhrase = "Enter your password..";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, UsernamePhrase);
            TextBoxStyle.TextBoxEmpty(txtPassword, PasswordPhrase);
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, UsernamePhrase);
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtPassword, PasswordPhrase);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtUsername, UsernamePhrase, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtPassword, PasswordPhrase, e);
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CenterToScreen();
            txtUsername.Clear();
            txtPassword.Clear();
            TextBoxStyle.TextBoxEmpty(txtUsername, UsernamePhrase);
            TextBoxStyle.TextBoxEmpty(txtPassword, PasswordPhrase);

            var registrationForm = new RegistrationForm(this);
            registrationForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
