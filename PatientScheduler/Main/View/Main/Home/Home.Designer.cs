namespace PatientScheduler.Components.Main
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Doctor Forseth has 12 scheduled appointments with patients today");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Doctor Smith has 4 scheduled appointments with patients today");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Doctor Smith has a modified schedule today and is working from 11:00 am to 2:30 p" +
                "m",
            ""}, -1);
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlCancelAppt = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlEditAppt = new System.Windows.Forms.Panel();
            this.btnHelpNavigating = new System.Windows.Forms.Button();
            this.pnlChangeDoctor = new System.Windows.Forms.Panel();
            this.btnCustomizeNotif = new System.Windows.Forms.Button();
            this.pnlLookupAppt = new System.Windows.Forms.Panel();
            this.btnDismissedNotif = new System.Windows.Forms.Button();
            this.pnlNotificationTop = new System.Windows.Forms.Panel();
            this.btnThisWeek = new System.Windows.Forms.Button();
            this.NotificationInfo = new System.Windows.Forms.Panel();
            this.lblNotificationInfo = new System.Windows.Forms.Label();
            this.lblNotificationCenter = new System.Windows.Forms.Label();
            this.pnlNotificationBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBreakTimes = new System.Windows.Forms.ListView();
            this.pnlHome.SuspendLayout();
            this.pnlCancelAppt.SuspendLayout();
            this.pnlEditAppt.SuspendLayout();
            this.pnlChangeDoctor.SuspendLayout();
            this.pnlLookupAppt.SuspendLayout();
            this.pnlNotificationTop.SuspendLayout();
            this.NotificationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHome.Controls.Add(this.pnlCancelAppt);
            this.pnlHome.Controls.Add(this.pnlEditAppt);
            this.pnlHome.Controls.Add(this.pnlChangeDoctor);
            this.pnlHome.Controls.Add(this.pnlLookupAppt);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHome.Location = new System.Drawing.Point(0, 618);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(922, 64);
            this.pnlHome.TabIndex = 6;
            // 
            // pnlCancelAppt
            // 
            this.pnlCancelAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancelAppt.Controls.Add(this.btnLogout);
            this.pnlCancelAppt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCancelAppt.Location = new System.Drawing.Point(693, 0);
            this.pnlCancelAppt.Name = "pnlCancelAppt";
            this.pnlCancelAppt.Size = new System.Drawing.Size(228, 62);
            this.pnlCancelAppt.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(227, 60);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlEditAppt
            // 
            this.pnlEditAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditAppt.Controls.Add(this.btnHelpNavigating);
            this.pnlEditAppt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEditAppt.Location = new System.Drawing.Point(462, 0);
            this.pnlEditAppt.Name = "pnlEditAppt";
            this.pnlEditAppt.Size = new System.Drawing.Size(231, 62);
            this.pnlEditAppt.TabIndex = 7;
            // 
            // btnHelpNavigating
            // 
            this.btnHelpNavigating.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHelpNavigating.FlatAppearance.BorderSize = 0;
            this.btnHelpNavigating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpNavigating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpNavigating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelpNavigating.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpNavigating.Image")));
            this.btnHelpNavigating.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelpNavigating.Location = new System.Drawing.Point(0, 0);
            this.btnHelpNavigating.Name = "btnHelpNavigating";
            this.btnHelpNavigating.Size = new System.Drawing.Size(231, 60);
            this.btnHelpNavigating.TabIndex = 0;
            this.btnHelpNavigating.Text = "Help Navigating";
            this.btnHelpNavigating.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelpNavigating.UseVisualStyleBackColor = true;
            // 
            // pnlChangeDoctor
            // 
            this.pnlChangeDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangeDoctor.Controls.Add(this.btnCustomizeNotif);
            this.pnlChangeDoctor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChangeDoctor.Location = new System.Drawing.Point(231, 0);
            this.pnlChangeDoctor.Name = "pnlChangeDoctor";
            this.pnlChangeDoctor.Size = new System.Drawing.Size(231, 62);
            this.pnlChangeDoctor.TabIndex = 8;
            // 
            // btnCustomizeNotif
            // 
            this.btnCustomizeNotif.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustomizeNotif.FlatAppearance.BorderSize = 0;
            this.btnCustomizeNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeNotif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeNotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCustomizeNotif.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomizeNotif.Image")));
            this.btnCustomizeNotif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomizeNotif.Location = new System.Drawing.Point(0, 0);
            this.btnCustomizeNotif.Name = "btnCustomizeNotif";
            this.btnCustomizeNotif.Size = new System.Drawing.Size(230, 60);
            this.btnCustomizeNotif.TabIndex = 0;
            this.btnCustomizeNotif.Text = "Customize Notifications";
            this.btnCustomizeNotif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomizeNotif.UseVisualStyleBackColor = true;
            // 
            // pnlLookupAppt
            // 
            this.pnlLookupAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLookupAppt.Controls.Add(this.btnDismissedNotif);
            this.pnlLookupAppt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLookupAppt.Location = new System.Drawing.Point(0, 0);
            this.pnlLookupAppt.Name = "pnlLookupAppt";
            this.pnlLookupAppt.Size = new System.Drawing.Size(231, 62);
            this.pnlLookupAppt.TabIndex = 8;
            // 
            // btnDismissedNotif
            // 
            this.btnDismissedNotif.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDismissedNotif.FlatAppearance.BorderSize = 0;
            this.btnDismissedNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDismissedNotif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismissedNotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDismissedNotif.Image = ((System.Drawing.Image)(resources.GetObject("btnDismissedNotif.Image")));
            this.btnDismissedNotif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDismissedNotif.Location = new System.Drawing.Point(0, 0);
            this.btnDismissedNotif.Name = "btnDismissedNotif";
            this.btnDismissedNotif.Size = new System.Drawing.Size(230, 60);
            this.btnDismissedNotif.TabIndex = 0;
            this.btnDismissedNotif.Text = "Dismissed Notifications";
            this.btnDismissedNotif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDismissedNotif.UseVisualStyleBackColor = true;
            // 
            // pnlNotificationTop
            // 
            this.pnlNotificationTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlNotificationTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificationTop.Controls.Add(this.listBreakTimes);
            this.pnlNotificationTop.Controls.Add(this.NotificationInfo);
            this.pnlNotificationTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotificationTop.Location = new System.Drawing.Point(0, 0);
            this.pnlNotificationTop.Name = "pnlNotificationTop";
            this.pnlNotificationTop.Size = new System.Drawing.Size(922, 437);
            this.pnlNotificationTop.TabIndex = 7;
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThisWeek.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisWeek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisWeek.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnThisWeek.Location = new System.Drawing.Point(806, 20);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(111, 29);
            this.btnThisWeek.TabIndex = 4;
            this.btnThisWeek.Text = "Dismiss";
            this.btnThisWeek.UseVisualStyleBackColor = false;
            // 
            // NotificationInfo
            // 
            this.NotificationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.NotificationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationInfo.Controls.Add(this.button1);
            this.NotificationInfo.Controls.Add(this.lblNotificationInfo);
            this.NotificationInfo.Controls.Add(this.btnThisWeek);
            this.NotificationInfo.Controls.Add(this.lblNotificationCenter);
            this.NotificationInfo.Location = new System.Drawing.Point(-13, -9);
            this.NotificationInfo.Name = "NotificationInfo";
            this.NotificationInfo.Size = new System.Drawing.Size(943, 110);
            this.NotificationInfo.TabIndex = 0;
            // 
            // lblNotificationInfo
            // 
            this.lblNotificationInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotificationInfo.Location = new System.Drawing.Point(146, 49);
            this.lblNotificationInfo.Name = "lblNotificationInfo";
            this.lblNotificationInfo.Size = new System.Drawing.Size(630, 38);
            this.lblNotificationInfo.TabIndex = 1;
            this.lblNotificationInfo.Text = "You currently have 12 new notifications as of December 31, 2020";
            this.lblNotificationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotificationCenter
            // 
            this.lblNotificationCenter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationCenter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotificationCenter.Location = new System.Drawing.Point(150, 25);
            this.lblNotificationCenter.Name = "lblNotificationCenter";
            this.lblNotificationCenter.Size = new System.Drawing.Size(626, 28);
            this.lblNotificationCenter.TabIndex = 0;
            this.lblNotificationCenter.Text = "Notification Center";
            this.lblNotificationCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNotificationBottom
            // 
            this.pnlNotificationBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.pnlNotificationBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificationBottom.Location = new System.Drawing.Point(0, 437);
            this.pnlNotificationBottom.Name = "pnlNotificationBottom";
            this.pnlNotificationBottom.Size = new System.Drawing.Size(922, 183);
            this.pnlNotificationBottom.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(806, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "See More";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBreakTimes
            // 
            this.listBreakTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.listBreakTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBreakTimes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBreakTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBreakTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listBreakTimes.HideSelection = false;
            this.listBreakTimes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listBreakTimes.Location = new System.Drawing.Point(126, 121);
            this.listBreakTimes.Name = "listBreakTimes";
            this.listBreakTimes.Size = new System.Drawing.Size(676, 291);
            this.listBreakTimes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listBreakTimes.TabIndex = 1;
            this.listBreakTimes.UseCompatibleStateImageBehavior = false;
            this.listBreakTimes.View = System.Windows.Forms.View.List;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlNotificationBottom);
            this.Controls.Add(this.pnlNotificationTop);
            this.Controls.Add(this.pnlHome);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(922, 682);
            this.pnlHome.ResumeLayout(false);
            this.pnlCancelAppt.ResumeLayout(false);
            this.pnlEditAppt.ResumeLayout(false);
            this.pnlChangeDoctor.ResumeLayout(false);
            this.pnlLookupAppt.ResumeLayout(false);
            this.pnlNotificationTop.ResumeLayout(false);
            this.NotificationInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlChangeDoctor;
        private System.Windows.Forms.Button btnCustomizeNotif;
        private System.Windows.Forms.Panel pnlLookupAppt;
        private System.Windows.Forms.Button btnDismissedNotif;
        private System.Windows.Forms.Panel pnlCancelAppt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlEditAppt;
        private System.Windows.Forms.Button btnHelpNavigating;
        private System.Windows.Forms.Panel pnlNotificationTop;
        private System.Windows.Forms.Panel pnlNotificationBottom;
        private System.Windows.Forms.Panel NotificationInfo;
        private System.Windows.Forms.Label lblNotificationInfo;
        private System.Windows.Forms.Label lblNotificationCenter;
        private System.Windows.Forms.Button btnThisWeek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listBreakTimes;
    }
}
