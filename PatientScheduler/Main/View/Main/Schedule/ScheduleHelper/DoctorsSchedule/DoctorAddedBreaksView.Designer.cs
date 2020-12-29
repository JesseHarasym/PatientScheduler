namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    partial class DoctorAddedBreaksView
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Monday: 10am - 11am");
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBreakList = new System.Windows.Forms.Panel();
            this.lblBreakView = new System.Windows.Forms.Label();
            this.listBreakTimes = new System.Windows.Forms.ListView();
            this.pnlHeader.SuspendLayout();
            this.pnlBreakList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBreakView);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(334, 46);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBreakList
            // 
            this.pnlBreakList.Controls.Add(this.listBreakTimes);
            this.pnlBreakList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBreakList.Location = new System.Drawing.Point(0, 46);
            this.pnlBreakList.Name = "pnlBreakList";
            this.pnlBreakList.Size = new System.Drawing.Size(334, 285);
            this.pnlBreakList.TabIndex = 1;
            // 
            // lblBreakView
            // 
            this.lblBreakView.AutoSize = true;
            this.lblBreakView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakView.Location = new System.Drawing.Point(17, 22);
            this.lblBreakView.Name = "lblBreakView";
            this.lblBreakView.Size = new System.Drawing.Size(305, 19);
            this.lblBreakView.TabIndex = 0;
            this.lblBreakView.Text = "See all breaks added to your schedule";
            // 
            // listBreakTimes
            // 
            this.listBreakTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listBreakTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBreakTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBreakTimes.GridLines = true;
            this.listBreakTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listBreakTimes.HideSelection = false;
            this.listBreakTimes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listBreakTimes.Location = new System.Drawing.Point(64, 19);
            this.listBreakTimes.Name = "listBreakTimes";
            this.listBreakTimes.Size = new System.Drawing.Size(258, 248);
            this.listBreakTimes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listBreakTimes.TabIndex = 0;
            this.listBreakTimes.UseCompatibleStateImageBehavior = false;
            this.listBreakTimes.View = System.Windows.Forms.View.List;
            // 
            // DoctorAddedBreaksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlBreakList);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorAddedBreaksView";
            this.Size = new System.Drawing.Size(334, 330);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBreakList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBreakView;
        private System.Windows.Forms.Panel pnlBreakList;
        private System.Windows.Forms.ListView listBreakTimes;
    }
}
