using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Styling;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components
{
    public partial class RegistrationForm : Form
    {
        private LoginForm Login;
        public RegistrationForm(LoginForm login)
        {
            InitializeComponent();
            Login = login;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, "username");
            TextBoxStyle.TextBoxEmpty(txtPassword, "password");
            TextBoxStyle.TextBoxEmpty(txtPassword2, "password2");
            TextBoxStyle.TextBoxEmpty(txtStaffId, "staffId");
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtUsername, "username");
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtPassword, "password");
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtPassword2, "password2");
        }

        private void txtStaffId_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxEmpty(txtStaffId, "staffId");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtUsername, "username", e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtPassword, "password", e);
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtPassword2, "password2", e);
        }

        private void txtStaffId_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxStyle.TextBoxNotEmpty(txtStaffId, "staffId", e);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            Login.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var ad = new AccountsData();

        }
    }
}
