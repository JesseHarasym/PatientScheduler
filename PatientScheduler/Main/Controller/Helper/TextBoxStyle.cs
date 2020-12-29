using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Styling
{
    static class TextBoxStyle
    {

        public static void TextBoxEmpty(MaskedTextBox textbox, string type)
        {
            if (textbox.Text == String.Empty)
            {
                textbox.BorderStyle = BorderStyle.None;
                textbox.BackColor = Color.SlateGray;
                textbox.ForeColor = Color.WhiteSmoke;
                textbox.TextAlign = HorizontalAlignment.Center;
                textbox.Text = CheckWhichTextBox(type);
                textbox.PasswordChar = '\0';
            }
        }

        public static void TextBoxNotEmpty(MaskedTextBox textbox, string type, KeyEventArgs e)
        {
            string phrase = CheckWhichTextBox(type);
            if (textbox.Text == phrase)
            {
                textbox.Text = String.Empty;
                textbox.ForeColor = Color.WhiteSmoke;

                if (type == "password" || type == "password2")
                {
                    textbox.PasswordChar = '*';
                }
            }
        }

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
                case "startMonday":
                    phrase = "start time monday..";
                    break;
                case "endMonday":
                    phrase = "end time monday..";
                    break;
                case "startTuesday":
                    phrase = "start time tuesday..";
                    break;
                case "endTuesday":
                    phrase = "end time tuesday..";
                    break;
                case "startWednesday":
                    phrase = "start time wednesday..";
                    break;
                case "endWednesday":
                    phrase = "end time wednesday..";
                    break;
                case "startThursday":
                    phrase = "start time thursday..";
                    break;
                case "endThursday":
                    phrase = "end time thursday..";
                    break;
                case "startFriday":
                    phrase = "start time friday..";
                    break;
                case "endFriday":
                    phrase = "end time friday..";
                    break;
                case "startSaturday":
                    phrase = "start time saturday..";
                    break;
                case "endSaturday":
                    phrase = "end time saturday..";
                    break;
                case "startSunday":
                    phrase = "start time sunday..";
                    break;
                case "endSunday":
                    phrase = "end time sunday..";
                    break;
                case "startBreak":
                    phrase = "start of break time..";
                    break;
                case "endBreak":
                    phrase = "end of break time..";
                    break;
            }

            return phrase;
        }
    }
}
