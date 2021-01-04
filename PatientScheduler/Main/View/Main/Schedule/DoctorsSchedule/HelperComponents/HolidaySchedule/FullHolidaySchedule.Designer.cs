namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule
{
    partial class FullHolidaySchedule
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
            this.addHolidaySchedule1 = new PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.AddHolidaySchedule();
            this.viewAddedHoliday1 = new PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule.ViewAddedHoliday();
            this.SuspendLayout();
            // 
            // addHolidaySchedule1
            // 
            this.addHolidaySchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.addHolidaySchedule1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addHolidaySchedule1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHolidaySchedule1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addHolidaySchedule1.Location = new System.Drawing.Point(0, 0);
            this.addHolidaySchedule1.Margin = new System.Windows.Forms.Padding(5);
            this.addHolidaySchedule1.Name = "addHolidaySchedule1";
            this.addHolidaySchedule1.Size = new System.Drawing.Size(342, 418);
            this.addHolidaySchedule1.TabIndex = 0;
            // 
            // viewAddedHoliday1
            // 
            this.viewAddedHoliday1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.viewAddedHoliday1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAddedHoliday1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAddedHoliday1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAddedHoliday1.Location = new System.Drawing.Point(339, 0);
            this.viewAddedHoliday1.Margin = new System.Windows.Forms.Padding(5);
            this.viewAddedHoliday1.Name = "viewAddedHoliday1";
            this.viewAddedHoliday1.Size = new System.Drawing.Size(691, 418);
            this.viewAddedHoliday1.TabIndex = 1;
            // 
            // FullHolidaySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.viewAddedHoliday1);
            this.Controls.Add(this.addHolidaySchedule1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FullHolidaySchedule";
            this.Size = new System.Drawing.Size(1030, 418);
            this.ResumeLayout(false);

        }

        #endregion

        private ScheduleHelper.AddHolidaySchedule addHolidaySchedule1;
        private ViewAddedHoliday viewAddedHoliday1;
    }
}
