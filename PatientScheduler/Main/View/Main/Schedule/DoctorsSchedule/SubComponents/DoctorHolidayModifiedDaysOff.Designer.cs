namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    partial class DoctorHolidayModifiedDaysOff
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
            this.lblDaysOff = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDaysOff
            // 
            this.lblDaysOff.AutoSize = true;
            this.lblDaysOff.Location = new System.Drawing.Point(15, 12);
            this.lblDaysOff.Name = "lblDaysOff";
            this.lblDaysOff.Size = new System.Drawing.Size(264, 21);
            this.lblDaysOff.TabIndex = 48;
            this.lblDaysOff.Text = "Number of Consecutive Days Off";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.maskedTextBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(89, 39);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(118, 27);
            this.maskedTextBox2.TabIndex = 49;
            // 
            // DoctorHolidayModifiedDaysOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lblDaysOff);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorHolidayModifiedDaysOff";
            this.Size = new System.Drawing.Size(296, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}
