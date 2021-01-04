namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.WeeklySchedule
{
    partial class FullWeeklySchedule
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
            this.viewAllAddedBreaks = new PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule.ViewAllAddedBreaks();
            this.addNewBreak1 = new PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.HelperComponents.AddBreaksFull();
            this.addWeeklySchedule1 = new PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.AddWeeklySchedule();
            this.SuspendLayout();
            // 
            // viewAllAddedBreaks
            // 
            this.viewAllAddedBreaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.viewAllAddedBreaks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAllAddedBreaks.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewAllAddedBreaks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllAddedBreaks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAllAddedBreaks.Location = new System.Drawing.Point(697, 0);
            this.viewAllAddedBreaks.Margin = new System.Windows.Forms.Padding(5);
            this.viewAllAddedBreaks.Name = "viewAllAddedBreaks";
            this.viewAllAddedBreaks.Size = new System.Drawing.Size(333, 418);
            this.viewAllAddedBreaks.TabIndex = 0;
            // 
            // addNewBreak1
            // 
            this.addNewBreak1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.addNewBreak1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNewBreak1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addNewBreak1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBreak1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewBreak1.Location = new System.Drawing.Point(436, 0);
            this.addNewBreak1.Margin = new System.Windows.Forms.Padding(5);
            this.addNewBreak1.Name = "addNewBreak1";
            this.addNewBreak1.Size = new System.Drawing.Size(261, 418);
            this.addNewBreak1.TabIndex = 1;
            // 
            // addWeeklySchedule1
            // 
            this.addWeeklySchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.addWeeklySchedule1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addWeeklySchedule1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWeeklySchedule1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addWeeklySchedule1.Location = new System.Drawing.Point(0, 0);
            this.addWeeklySchedule1.Margin = new System.Windows.Forms.Padding(5);
            this.addWeeklySchedule1.Name = "addWeeklySchedule1";
            this.addWeeklySchedule1.Size = new System.Drawing.Size(436, 418);
            this.addWeeklySchedule1.TabIndex = 2;
            // 
            // FullWeeklySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.addNewBreak1);
            this.Controls.Add(this.addWeeklySchedule1);
            this.Controls.Add(this.viewAllAddedBreaks);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FullWeeklySchedule";
            this.Size = new System.Drawing.Size(1030, 418);
            this.ResumeLayout(false);

        }

        #endregion
        private ScheduleHelper.DoctorsSchedule.ViewAllAddedBreaks viewAllAddedBreaks;
        private HelperComponents.AddBreaksFull addNewBreak1;
        private ScheduleHelper.AddWeeklySchedule addWeeklySchedule1;
    }
}
