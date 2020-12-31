namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule
{
    partial class ViewAllModifiedTimes
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("January 12, 2021 - 11:00 am - 2:30 pm");
            this.label1 = new System.Windows.Forms.Label();
            this.listHolidaysScheduled = new System.Windows.Forms.ListView();
            this.btnEditHoliday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Modified Times";
            // 
            // listHolidaysScheduled
            // 
            this.listHolidaysScheduled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listHolidaysScheduled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHolidaysScheduled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listHolidaysScheduled.HideSelection = false;
            this.listHolidaysScheduled.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listHolidaysScheduled.Location = new System.Drawing.Point(26, 49);
            this.listHolidaysScheduled.Name = "listHolidaysScheduled";
            this.listHolidaysScheduled.Size = new System.Drawing.Size(639, 187);
            this.listHolidaysScheduled.TabIndex = 48;
            this.listHolidaysScheduled.UseCompatibleStateImageBehavior = false;
            this.listHolidaysScheduled.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnEditHoliday
            // 
            this.btnEditHoliday.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditHoliday.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHoliday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHoliday.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditHoliday.Location = new System.Drawing.Point(250, 258);
            this.btnEditHoliday.Name = "btnEditHoliday";
            this.btnEditHoliday.Size = new System.Drawing.Size(194, 29);
            this.btnEditHoliday.TabIndex = 49;
            this.btnEditHoliday.Text = "Cancel Modified Time";
            this.btnEditHoliday.UseVisualStyleBackColor = false;
            // 
            // ViewAllModifiedTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHolidaysScheduled);
            this.Controls.Add(this.btnEditHoliday);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewAllModifiedTimes";
            this.Size = new System.Drawing.Size(693, 323);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listHolidaysScheduled;
        private System.Windows.Forms.Button btnEditHoliday;
    }
}
