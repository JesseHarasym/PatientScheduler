using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Styling
{
    //this class is used to  make custom text boxes which show the label text inside the box until a user has made an input
    //similar to typical user input boxes in web development
    static class TextBoxStyle
    {
        //style text boxes when nothing has been entered as input yet, or has been deleted by user
        public static void TextBoxEmpty(MaskedTextBox textbox, string type)
        {
            if (textbox.Text == String.Empty)
            {
                //basic styling
                textbox.BorderStyle = BorderStyle.None;
                textbox.BackColor = Color.SlateGray;
                textbox.ForeColor = Color.WhiteSmoke;
                textbox.TextAlign = HorizontalAlignment.Center;
                //check which text should be displayed on input box
                textbox.Text = CheckWhichTextBox(type);
                //for passwords to show up correctly
                textbox.PasswordChar = '\0';
            }
        }

        //style text boxes when something has been entered by the user
        public static void TextBoxNotEmpty(MaskedTextBox textbox, string type, KeyEventArgs e)
        {
            string phrase = CheckWhichTextBox(type);
            //if the text boxes content is the displayed input box text, then handle accordingly
            if (textbox.Text == phrase)
            {
                //make the string empty so users can actually enter text
                textbox.Text = String.Empty;
                textbox.ForeColor = Color.WhiteSmoke;

                //ensure password characters still show up as expected
                if (type == "password" || type == "password2")
                {
                    textbox.PasswordChar = '*';
                }
            }
        }

        //function to determine which phrase should be used for the inputs text depending on the type passed to the function
        public static string CheckWhichTextBox(string type)
        {
            string phrase = "";

            switch (type)
            {
                case "username":
                    phrase = "enter your username..";
                    break;
                case "password":
                    phrase = "enter your password..";
                    break;
                case "password2":
                    phrase = "re-enter your password..";
                    break;
                case "staffId":
                    phrase = "enter your staff Id..";
                    break;
                case "month":
                    phrase = "month..";
                    break;
                case "day":
                    phrase = "day..";
                    break;
                case "year":
                    phrase = "year..";
                    break;
                case "startTime":
                    phrase = "start time..";
                    break;
                case "endTime":
                    phrase = "end time..";
                    break;
                case "startBreak":
                    phrase = "start break time..";
                    break;
                case "endBreak":
                    phrase = "end break time..";
                    break;
                case "daysOff":
                    phrase = "number of days off..";
                    break;
            }

            return phrase;
        }
    }
}
