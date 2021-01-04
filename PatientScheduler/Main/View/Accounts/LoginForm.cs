using PatientScheduler.Classes.Accounts;
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
            TempStaffSetupFastLogin();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Icon = Resources.StartupIcon;
            SetupTextBoxes();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var ad = new AccountsData();
            var sd = new StaffData();
            var message = new UserMessage();

            bool allInputsValid = ValidateInputs(username, password);   //check all users inputs are valid
            var accountInfo = ad.GetAccountPassword(username, password);    //get account password from database
            bool passwordMatch = accountInfo.Item1; //return if passwords matched between input and hashed stored password
            Int32.TryParse(accountInfo.Item2, out var staffId);     //get the staffs id that's trying to log in

            if (allInputsValid && passwordMatch)
            {
                //if everything's valid, get all that staffs information, store in a data structure 
                var staff = sd.GetStaffInformation(staffId, username, password);
                //reset login data and hide login component
                SetupTextBoxes();
                Hide();
                //bring the logged in menu up, user is now logged in 
                var menuInterface = new MenuInterface(staff, this);
                menuInterface.ShowDialog();
            }
            else if (allInputsValid)
            {
                message.Show("Your password does not match the password we have stored for your account.");
            }
        }

        //function that checks all controller validation methods and returns results for user message errors
        public bool ValidateInputs(string username, string password)
        {
            var ad = new AccountsData();
            var av = new AccountValidation();
            var message = new UserMessage();
            var passwordValidation = av.ValidatePassword(password, password);

            bool uniqueUsername = ad.CheckForExistingUsername(username);
            bool validUsername = av.ValidateUsername(username);
            bool validPassword = passwordValidation.Item2;

            //username was invalid
            if (!validUsername)
            {
                message.Show("This is not a valid username, please ensure its at least 3 characters and only letters and numbers");
                return false;
            }
            //username already exists
            if (uniqueUsername)
            {
                message.Show("This username does not exist, please ensure you're typing it in correctly.");
                return false;
            }
            //the password input was not valid
            if (!validPassword)
            {
                message.Show("This is not a valid password, please ensure it is at least 6 characters long.");
                return false;
            }

            return true;
        }

        //paint border around our borderless component
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        //setup all text boxes to our custom look where the input requirements shows up on empty text boxes
        public void SetupTextBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
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

        //if register link is clicked, reset any information input my user and show the registration form
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

        //temp function for fast login when testing components during development
        public void TempStaffSetupFastLogin()
        {
            try
            {
                var staff = new StaffAccounts("Jesse", "Harasym", "admin", "admin123", "admin@med.ca", "Administrator",
                    1,
                    10);
                var cs = new MenuInterface(staff, this);
                cs.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong with fast login " + ex);
            }

        }
    }
}
