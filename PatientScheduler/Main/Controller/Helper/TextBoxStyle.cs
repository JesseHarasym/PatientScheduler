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
                case "startTime":
                    phrase = "start time..";
                    break;
                case "endTime":
                    phrase = "end time..";
                    break;

            }

            return phrase;
        }
    }
}
