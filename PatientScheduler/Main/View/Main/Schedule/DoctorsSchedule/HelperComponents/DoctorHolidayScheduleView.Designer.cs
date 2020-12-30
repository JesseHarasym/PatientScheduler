namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    partial class DoctorHolidayScheduleView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("January 12, 2021 - 11:00 am - 2:30 pm");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("March 12, 2021 to March 17, 2021 (5 days off)");
            this.pnlAddHoliday = new System.Windows.Forms.Panel();
            this.pnlHolidaySchedule = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioTakeDayOff = new System.Windows.Forms.RadioButton();
            this.lblMonday = new System.Windows.Forms.Label();
            this.radioModifiedTime = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMondayStart = new System.Windows.Forms.MaskedTextBox();
            this.txtMondayEnd = new System.Windows.Forms.MaskedTextBox();
            this.pnlHolidayView = new System.Windows.Forms.Panel();
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.lblAddedHolidays = new System.Windows.Forms.Label();
            this.listHolidaysScheduled = new System.Windows.Forms.ListView();
            this.btnRemoveHoliday = new System.Windows.Forms.Button();
            this.btnEditHoliday = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddHoliday.SuspendLayout();
            this.pnlHolidaySchedule.SuspendLayout();
            this.pnlHolidayView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddHoliday
            // 
            this.pnlAddHoliday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddHoliday.Controls.Add(this.pnlChoice);
            this.pnlAddHoliday.Controls.Add(this.pnlHolidaySchedule);
            this.pnlAddHoliday.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddHoliday.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHoliday.Name = "pnlAddHoliday";
            this.pnlAddHoliday.Size = new System.Drawing.Size(386, 330);
            this.pnlAddHoliday.TabIndex = 45;
            // 
            // pnlHolidaySchedule
            // 
            this.pnlHolidaySchedule.Controls.Add(this.maskedTextBox1);
            this.pnlHolidaySchedule.Controls.Add(this.radioTakeDayOff);
            this.pnlHolidaySchedule.Controls.Add(this.lblMonday);
            this.pnlHolidaySchedule.Controls.Add(this.radioModifiedTime);
            this.pnlHolidaySchedule.Controls.Add(this.label7);
            this.pnlHolidaySchedule.Controls.Add(this.txtMondayStart);
            this.pnlHolidaySchedule.Controls.Add(this.txtMondayEnd);
            this.pnlHolidaySchedule.Location = new System.Drawing.Point(2, -1);
            this.pnlHolidaySchedule.Name = "pnlHolidaySchedule";
            this.pnlHolidaySchedule.Size = new System.Drawing.Size(293, 216);
            this.pnlHolidaySchedule.TabIndex = 46;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 85);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(77, 27);
            this.maskedTextBox1.TabIndex = 39;
            // 
            // radioTakeDayOff
            // 
            this.radioTakeDayOff.AutoSize = true;
            this.radioTakeDayOff.Location = new System.Drawing.Point(79, 163);
            this.radioTakeDayOff.Name = "radioTakeDayOff";
            this.radioTakeDayOff.Size = new System.Drawing.Size(128, 25);
            this.radioTakeDayOff.TabIndex = 44;
            this.radioTakeDayOff.TabStop = true;
            this.radioTakeDayOff.Text = "Take Day Off";
            this.radioTakeDayOff.UseVisualStyleBackColor = true;
            this.radioTakeDayOff.CheckedChanged += new System.EventHandler(this.radioTakeDayOff_CheckedChanged);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(78, 58);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(127, 21);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Choose a date";
            // 
            // radioModifiedTime
            // 
            this.radioModifiedTime.AutoSize = true;
            this.radioModifiedTime.Location = new System.Drawing.Point(77, 132);
            this.radioModifiedTime.Name = "radioModifiedTime";
            this.radioModifiedTime.Size = new System.Drawing.Size(136, 25);
            this.radioModifiedTime.TabIndex = 45;
            this.radioModifiedTime.TabStop = true;
            this.radioModifiedTime.Text = "Modified Time";
            this.radioModifiedTime.UseVisualStyleBackColor = true;
            this.radioModifiedTime.CheckedChanged += new System.EventHandler(this.radioModifiedTime_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Add Doctors Holiday Schedule";
            // 
            // txtMondayStart
            // 
            this.txtMondayStart.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMondayStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMondayStart.Location = new System.Drawing.Point(99, 85);
            this.txtMondayStart.Name = "txtMondayStart";
            this.txtMondayStart.Size = new System.Drawing.Size(80, 27);
            this.txtMondayStart.TabIndex = 8;
            // 
            // txtMondayEnd
            // 
            this.txtMondayEnd.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMondayEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMondayEnd.Location = new System.Drawing.Point(185, 85);
            this.txtMondayEnd.Name = "txtMondayEnd";
            this.txtMondayEnd.Size = new System.Drawing.Size(77, 27);
            this.txtMondayEnd.TabIndex = 9;
            // 
            // pnlHolidayView
            // 
            this.pnlHolidayView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHolidayView.Controls.Add(this.label2);
            this.pnlHolidayView.Controls.Add(this.label1);
            this.pnlHolidayView.Controls.Add(this.listView1);
            this.pnlHolidayView.Controls.Add(this.btnRemoveHoliday);
            this.pnlHolidayView.Controls.Add(this.btnEditHoliday);
            this.pnlHolidayView.Controls.Add(this.listHolidaysScheduled);
            this.pnlHolidayView.Controls.Add(this.lblAddedHolidays);
            this.pnlHolidayView.Location = new System.Drawing.Point(294, 0);
            this.pnlHolidayView.Name = "pnlHolidayView";
            this.pnlHolidayView.Size = new System.Drawing.Size(733, 330);
            this.pnlHolidayView.TabIndex = 46;
            // 
            // pnlChoice
            // 
            this.pnlChoice.Location = new System.Drawing.Point(-1, 214);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(296, 112);
            this.pnlChoice.TabIndex = 46;
            // 
            // lblAddedHolidays
            // 
            this.lblAddedHolidays.AutoSize = true;
            this.lblAddedHolidays.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedHolidays.Location = new System.Drawing.Point(223, 12);
            this.lblAddedHolidays.Name = "lblAddedHolidays";
            this.lblAddedHolidays.Size = new System.Drawing.Size(302, 19);
            this.lblAddedHolidays.TabIndex = 39;
            this.lblAddedHolidays.Text = "View All Currently Scheduled Holidays";
            // 
            // listHolidaysScheduled
            // 
            this.listHolidaysScheduled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listHolidaysScheduled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHolidaysScheduled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listHolidaysScheduled.HideSelection = false;
            this.listHolidaysScheduled.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10});
            this.listHolidaysScheduled.Location = new System.Drawing.Point(13, 87);
            this.listHolidaysScheduled.Name = "listHolidaysScheduled";
            this.listHolidaysScheduled.Size = new System.Drawing.Size(319, 168);
            this.listHolidaysScheduled.TabIndex = 40;
            this.listHolidaysScheduled.UseCompatibleStateImageBehavior = false;
            this.listHolidaysScheduled.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnRemoveHoliday
            // 
            this.btnRemoveHoliday.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveHoliday.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemoveHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHoliday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHoliday.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveHoliday.Location = new System.Drawing.Point(419, 261);
            this.btnRemoveHoliday.Name = "btnRemoveHoliday";
            this.btnRemoveHoliday.Size = new System.Drawing.Size(147, 29);
            this.btnRemoveHoliday.TabIndex = 41;
            this.btnRemoveHoliday.Text = "Remove Holiday";
            this.btnRemoveHoliday.UseVisualStyleBackColor = false;
            // 
            // btnEditHoliday
            // 
            this.btnEditHoliday.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditHoliday.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHoliday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHoliday.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditHoliday.Location = new System.Drawing.Point(149, 261);
            this.btnEditHoliday.Name = "btnEditHoliday";
            this.btnEditHoliday.Size = new System.Drawing.Size(147, 29);
            this.btnEditHoliday.TabIndex = 42;
            this.btnEditHoliday.Text = "Modify Holiday";
            this.btnEditHoliday.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(338, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 168);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Modified Times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Days Taken Off";
            // 
            // DoctorHolidayScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlHolidayView);
            this.Controls.Add(this.pnlAddHoliday);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorHolidayScheduleView";
            this.Size = new System.Drawing.Size(1030, 330);
            this.pnlAddHoliday.ResumeLayout(false);
            this.pnlHolidaySchedule.ResumeLayout(false);
            this.pnlHolidaySchedule.PerformLayout();
            this.pnlHolidayView.ResumeLayout(false);
            this.pnlHolidayView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddHoliday;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtMondayEnd;
        private System.Windows.Forms.MaskedTextBox txtMondayStart;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.RadioButton radioTakeDayOff;
        private System.Windows.Forms.RadioButton radioModifiedTime;
        private System.Windows.Forms.Panel pnlHolidaySchedule;
        private System.Windows.Forms.Panel pnlHolidayView;
        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Label lblAddedHolidays;
        private System.Windows.Forms.ListView listHolidaysScheduled;
        private System.Windows.Forms.Button btnEditHoliday;
        private System.Windows.Forms.Button btnRemoveHoliday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}
