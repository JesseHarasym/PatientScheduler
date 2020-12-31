namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule
{
    partial class ViewAddedHoliday
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
            this.pnlHolidayViewChoice = new System.Windows.Forms.Panel();
            this.lblAddedHolidays = new System.Windows.Forms.Label();
            this.radioDaysTakenOff = new System.Windows.Forms.RadioButton();
            this.radioModifiedTimes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pnlHolidayViewChoice
            // 
            this.pnlHolidayViewChoice.Location = new System.Drawing.Point(-2, 92);
            this.pnlHolidayViewChoice.Name = "pnlHolidayViewChoice";
            this.pnlHolidayViewChoice.Size = new System.Drawing.Size(693, 323);
            this.pnlHolidayViewChoice.TabIndex = 53;
            // 
            // lblAddedHolidays
            // 
            this.lblAddedHolidays.AutoSize = true;
            this.lblAddedHolidays.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedHolidays.Location = new System.Drawing.Point(202, 11);
            this.lblAddedHolidays.Name = "lblAddedHolidays";
            this.lblAddedHolidays.Size = new System.Drawing.Size(262, 19);
            this.lblAddedHolidays.TabIndex = 52;
            this.lblAddedHolidays.Text = "View Added Holiday Scheduling";
            // 
            // radioDaysTakenOff
            // 
            this.radioDaysTakenOff.AutoSize = true;
            this.radioDaysTakenOff.Location = new System.Drawing.Point(374, 55);
            this.radioDaysTakenOff.Name = "radioDaysTakenOff";
            this.radioDaysTakenOff.Size = new System.Drawing.Size(186, 25);
            this.radioDaysTakenOff.TabIndex = 50;
            this.radioDaysTakenOff.TabStop = true;
            this.radioDaysTakenOff.Text = "View Days Taken Off";
            this.radioDaysTakenOff.UseVisualStyleBackColor = true;
            this.radioDaysTakenOff.CheckedChanged += new System.EventHandler(this.radioDaysTakenOff_CheckedChanged);
            // 
            // radioModifiedTimes
            // 
            this.radioModifiedTimes.AutoSize = true;
            this.radioModifiedTimes.Location = new System.Drawing.Point(101, 55);
            this.radioModifiedTimes.Name = "radioModifiedTimes";
            this.radioModifiedTimes.Size = new System.Drawing.Size(184, 25);
            this.radioModifiedTimes.TabIndex = 51;
            this.radioModifiedTimes.TabStop = true;
            this.radioModifiedTimes.Text = "View Modified Times";
            this.radioModifiedTimes.UseVisualStyleBackColor = true;
            this.radioModifiedTimes.CheckedChanged += new System.EventHandler(this.radioModifiedTimes_CheckedChanged);
            // 
            // ViewAddedHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlHolidayViewChoice);
            this.Controls.Add(this.lblAddedHolidays);
            this.Controls.Add(this.radioDaysTakenOff);
            this.Controls.Add(this.radioModifiedTimes);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewAddedHoliday";
            this.Size = new System.Drawing.Size(691, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHolidayViewChoice;
        private System.Windows.Forms.Label lblAddedHolidays;
        private System.Windows.Forms.RadioButton radioDaysTakenOff;
        private System.Windows.Forms.RadioButton radioModifiedTimes;
    }
}
