using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Classes.Styling
{
    static class TextBoxStyle
    {
        public static void TextBoxEmpty(MaskedTextBox textbox, string phrase)
        {
            if (textbox.Text == String.Empty)
            {
                textbox.Text = phrase;
                textbox.ForeColor = Color.Gray;
            }

        }

        public static void TextBoxNotEmpty(MaskedTextBox textbox, string phrase, KeyEventArgs e)
        {
            if (textbox.Text == phrase && e.KeyValue != (char)Keys.Back)
            {
                textbox.Text = String.Empty;
                textbox.ForeColor = Color.Black;
            }
        }
    }
}
