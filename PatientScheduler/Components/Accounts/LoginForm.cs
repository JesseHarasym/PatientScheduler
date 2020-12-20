using PatientScheduler.Classes.Styling;
using PatientScheduler.Components;
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

        }
    }
}
