using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientScheduler.Main.View.Custom
{
    public partial class Dropdown : ComboBox
    {
        public Dropdown()
        {
            InitializeComponent();
            ComboSetup();
        }

        public void ComboSetup()
        {
            //basic combo box styling
            customComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customComboBox.Region = new Region(new Rectangle(3, 3, customComboBox.Width - 3, customComboBox.Height - 6));
        }

        private void customComboBox_Click(object sender, EventArgs e)
        {
            customComboBox.DroppedDown = true;
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            customComboBox.DroppedDown = true;
        }
    }
}
