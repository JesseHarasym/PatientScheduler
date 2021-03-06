﻿using PatientScheduler.Classes.Accounts;
using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Styling;
using PatientScheduler.Classes.Validation;
using PatientScheduler.Components.Custom;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Components
{
    public partial class RegistrationForm : Form
    {
        public readonly LoginForm Login;
        public RegistrationForm(LoginForm login)
        {
            InitializeComponent();
            Login = login;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            SetupTextBoxes();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;
            Int32.TryParse(txtStaffId.Text, out var staffId);

            //validate all the registration inputs
            bool allInputsValid = ValidateInputs(username, password, password2, staffId);

            if (allInputsValid)
            {
                //if all inputs are validated, send the registration data to the database and add our new account
                var ad = new AccountsData();
                var account = new AccountBase(username, password, staffId);
                ad.AddAccount(account);

                Dispose();
                Login.Show();

                //user message to let them know their registration was successful
                var message = new UserMessage();
                message.Show("Your account has been successfully created!");
            }
        }

        public bool ValidateInputs(string username, string password, string password2, int staffId)
        {
            var ad = new AccountsData();
            var sd = new StaffData();
            var av = new AccountValidation();
            var message = new UserMessage();
            var passwordValidation = av.ValidatePassword(password, password2);

            //username validation class methods
            bool uniqueUsername = ad.CheckForExistingUsername(username);
            bool validUsername = av.ValidateUsername(username);
            //password validation class methods
            bool passwordsEqual = passwordValidation.Item1;
            bool validPassword = passwordValidation.Item2;
            //staff id validation class methods
            bool validStaffId = sd.CheckForValidStaffId(staffId);
            bool staffIdHasAccount = sd.CheckIfStaffIdHasAccount(staffId);

            //messages to show user if any of the validations fail
            //username validation messages
            if (!validUsername)
            {
                message.Show("This is not a valid username, please ensure its at least 3 characters and only letters and numbers");
                return false;
            }
            if (!uniqueUsername)
            {
                message.Show("This username already exists, please choose a different one.");
                return false;
            }
            //password validation messages
            if (!passwordsEqual)
            {
                message.Show("Your passwords do not match, please ensure you enter the same password both times.");
                return false;
            }
            if (!validPassword)
            {
                message.Show("This is not a valid password, please ensure it is at least 6 characters long.");
                return false;
            }
            //staff id validation messages
            if (!validStaffId)
            {
                message.Show("This staff Id is not valid, please ensure it was entered correctly.");
                return false;
            }
            //staff id already has an account
            if (!staffIdHasAccount)
            {
                message.Show("This staff Id already has an account associated with it, please talk to an administrator.");
                return false;
            }

            return true;
        }

        //dispose of the registration page and show login page if login link is clicked
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            Login.Show();
        }

        //border drawn for our borderless form
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        //everything below here is the set up for our custom text boxes
        public void SetupTextBoxes()
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
    }
}
