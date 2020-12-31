namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper
{
    partial class AddHolidaySchedule
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
            this.pnlAddHoliday = new System.Windows.Forms.Panel();
            this.pnlHolidayAddChoice = new System.Windows.Forms.Panel();
            this.pnlHolidaySchedule = new System.Windows.Forms.Panel();
            this.txtMonth = new System.Windows.Forms.MaskedTextBox();
            this.radioTakeDayOff = new System.Windows.Forms.RadioButton();
            this.lblMonday = new System.Windows.Forms.Label();
            this.radioModifiedTime = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.MaskedTextBox();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.pnlAddHoliday.SuspendLayout();
            this.pnlHolidaySchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddHoliday
            // 
            this.pnlAddHoliday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddHoliday.Controls.Add(this.pnlHolidayAddChoice);
            this.pnlAddHoliday.Controls.Add(this.pnlHolidaySchedule);
            this.pnlAddHoliday.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddHoliday.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHoliday.Name = "pnlAddHoliday";
            this.pnlAddHoliday.Size = new System.Drawing.Size(339, 418);
            this.pnlAddHoliday.TabIndex = 45;
            // 
            // pnlHolidayAddChoice
            // 
            this.pnlHolidayAddChoice.Location = new System.Drawing.Point(-1, 258);
            this.pnlHolidayAddChoice.Name = "pnlHolidayAddChoice";
            this.pnlHolidayAddChoice.Size = new System.Drawing.Size(339, 159);
            this.pnlHolidayAddChoice.TabIndex = 46;
            // 
            // pnlHolidaySchedule
            // 
            this.pnlHolidaySchedule.Controls.Add(this.txtMonth);
            this.pnlHolidaySchedule.Controls.Add(this.radioTakeDayOff);
            this.pnlHolidaySchedule.Controls.Add(this.lblMonday);
            this.pnlHolidaySchedule.Controls.Add(this.radioModifiedTime);
            this.pnlHolidaySchedule.Controls.Add(this.label7);
            this.pnlHolidaySchedule.Controls.Add(this.txtDay);
            this.pnlHolidaySchedule.Controls.Add(this.txtYear);
            this.pnlHolidaySchedule.Location = new System.Drawing.Point(2, -1);
            this.pnlHolidaySchedule.Name = "pnlHolidaySchedule";
            this.pnlHolidaySchedule.Size = new System.Drawing.Size(336, 260);
            this.pnlHolidaySchedule.TabIndex = 46;
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(44, 95);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(77, 27);
            this.txtMonth.TabIndex = 39;
            this.txtMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyDown);
            this.txtMonth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyUp);
            // 
            // radioTakeDayOff
            // 
            this.radioTakeDayOff.AutoSize = true;
            this.radioTakeDayOff.Location = new System.Drawing.Point(98, 205);
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
            this.lblMonday.Location = new System.Drawing.Point(106, 68);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(127, 21);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Choose a date";
            // 
            // radioModifiedTime
            // 
            this.radioModifiedTime.AutoSize = true;
            this.radioModifiedTime.Location = new System.Drawing.Point(98, 162);
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
            this.label7.Location = new System.Drawing.Point(50, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Add Doctors Holiday Schedule";
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(127, 95);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(80, 27);
            this.txtDay.TabIndex = 8;
            this.txtDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDay_KeyDown);
            this.txtDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDay_KeyUp);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(213, 95);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 27);
            this.txtYear.TabIndex = 9;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            this.txtYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyUp);
            // 
            // AddHolidaySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlAddHoliday);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddHolidaySchedule";
            this.Size = new System.Drawing.Size(342, 418);
            this.pnlAddHoliday.ResumeLayout(false);
            this.pnlHolidaySchedule.ResumeLayout(false);
            this.pnlHolidaySchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddHoliday;
        private System.Windows.Forms.MaskedTextBox txtMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.MaskedTextBox txtDay;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.RadioButton radioTakeDayOff;
        private System.Windows.Forms.RadioButton radioModifiedTime;
        private System.Windows.Forms.Panel pnlHolidaySchedule;
        private System.Windows.Forms.Panel pnlHolidayAddChoice;
    }
}
