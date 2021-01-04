namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    partial class ViewAllAddedBreaks
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Monday: 10:00 am to 4:30 pm");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tuesday: 10:00 am to 4:30 pm");
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBreakView = new System.Windows.Forms.Label();
            this.pnlBreakList = new System.Windows.Forms.Panel();
            this.listBreakTimes = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBreakView);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(334, 59);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBreakView
            // 
            this.lblBreakView.AutoSize = true;
            this.lblBreakView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakView.Location = new System.Drawing.Point(47, 12);
            this.lblBreakView.Name = "lblBreakView";
            this.lblBreakView.Size = new System.Drawing.Size(239, 19);
            this.lblBreakView.TabIndex = 0;
            this.lblBreakView.Text = "See Doctors Scheduled Breaks";
            // 
            // pnlBreakList
            // 
            this.pnlBreakList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBreakList.Location = new System.Drawing.Point(0, 59);
            this.pnlBreakList.Name = "pnlBreakList";
            this.pnlBreakList.Size = new System.Drawing.Size(334, 0);
            this.pnlBreakList.TabIndex = 1;
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
            listViewItem1,
            listViewItem2});
            this.listBreakTimes.Location = new System.Drawing.Point(50, 77);
            this.listBreakTimes.Name = "listBreakTimes";
            this.listBreakTimes.Size = new System.Drawing.Size(271, 249);
            this.listBreakTimes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listBreakTimes.TabIndex = 0;
            this.listBreakTimes.UseCompatibleStateImageBehavior = false;
            this.listBreakTimes.View = System.Windows.Forms.View.List;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Location = new System.Drawing.Point(101, 350);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 29);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Break";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // ViewAllAddedBreaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBreakTimes);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pnlBreakList);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewAllAddedBreaks";
            this.Size = new System.Drawing.Size(334, 421);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBreakView;
        private System.Windows.Forms.Panel pnlBreakList;
        private System.Windows.Forms.ListView listBreakTimes;
        private System.Windows.Forms.Button btnRemove;
    }
}
