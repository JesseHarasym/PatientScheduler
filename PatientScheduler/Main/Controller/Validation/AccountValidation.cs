﻿using PatientScheduler.Classes.Styling;
using System;
using System.Text.RegularExpressions;

namespace PatientScheduler.Classes.Validation
{
    public class AccountValidation
    {
        //ensure username is only a number or alphabetic letter, with at least 3 characters
        public bool ValidateUsername(string username)
        {
            bool valid = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9]*$");

            string phrase = TextBoxStyle.CheckWhichTextBox("username");

            if (reg.IsMatch(username) && username != phrase && username.Length >= 3)
            {
                valid = true;
            }

            return valid;
        }

        //ensure passwords match, and the password length is at least 6 characters
        public Tuple<bool, bool> ValidatePassword(string password, string password2)
        {
            bool validMatch = false;
            bool validLength = false;

            if (password.Equals(password2))
            {
                validMatch = true;
            }
            if (password.Length >= 6)
            {
                validLength = true;
            }

            return Tuple.Create(validMatch, validLength);
        }
    }
}
