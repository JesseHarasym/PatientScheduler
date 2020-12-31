namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.Helpers.HelperViews.HolidaySchedule
{
    partial class ViewAllDaysTakenOff
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("March 12, 2021 to March 17, 2021 (5 days off)");
            this.listDaysTakenOff = new System.Windows.Forms.ListView();
            this.btnRemoveHoliday = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDaysTakenOff
            // 
            this.listDaysTakenOff.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listDaysTakenOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listDaysTakenOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDaysTakenOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listDaysTakenOff.HideSelection = false;
            this.listDaysTakenOff.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listDaysTakenOff.Location = new System.Drawing.Point(29, 50);
            this.listDaysTakenOff.Name = "listDaysTakenOff";
            this.listDaysTakenOff.Size = new System.Drawing.Size(638, 191);
            this.listDaysTakenOff.TabIndex = 49;
            this.listDaysTakenOff.UseCompatibleStateImageBehavior = false;
            this.listDaysTakenOff.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnRemoveHoliday
            // 
            this.btnRemoveHoliday.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveHoliday.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemoveHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHoliday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHoliday.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveHoliday.Location = new System.Drawing.Point(246, 258);
            this.btnRemoveHoliday.Name = "btnRemoveHoliday";
            this.btnRemoveHoliday.Size = new System.Drawing.Size(194, 29);
            this.btnRemoveHoliday.TabIndex = 48;
            this.btnRemoveHoliday.Text = "Cancel Days Off";
            this.btnRemoveHoliday.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Days Taken Off";
            // 
            // ViewAllDaysTakenOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.listDaysTakenOff);
            this.Controls.Add(this.btnRemoveHoliday);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewAllDaysTakenOff";
            this.Size = new System.Drawing.Size(693, 323);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listDaysTakenOff;
        private System.Windows.Forms.Button btnRemoveHoliday;
        private System.Windows.Forms.Label label2;
    }
}
