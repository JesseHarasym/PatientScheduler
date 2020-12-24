namespace PatientScheduler.Components.Main
{
    partial class CentralScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralScreen));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlPatients = new System.Windows.Forms.Panel();
            this.btnPatients = new System.Windows.Forms.Button();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.titleBar = new PatientScheduler.Components.TitleBar();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlWelcome.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlPatients.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(191, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(922, 682);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.pnlWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.lblPosition);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 105);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(191, 209);
            this.pnlWelcome.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(189, 117);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(0, 83);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(189, 124);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 621);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(191, 61);
            this.pnlSettings.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(191, 61);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReports.Controls.Add(this.btnReports);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReports.Location = new System.Drawing.Point(0, 560);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(191, 61);
            this.pnlReports.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(0, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(191, 61);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlPatients
            // 
            this.pnlPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatients.Controls.Add(this.btnPatients);
            this.pnlPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatients.Location = new System.Drawing.Point(0, 438);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(191, 61);
            this.pnlPatients.TabIndex = 5;
            // 
            // btnPatients
            // 
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatients.Location = new System.Drawing.Point(0, 2);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(191, 61);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchedule.Controls.Add(this.btnSchedule);
            this.pnlSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSchedule.Location = new System.Drawing.Point(0, 377);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(191, 61);
            this.pnlSchedule.TabIndex = 4;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSchedule.Location = new System.Drawing.Point(0, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(191, 61);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 314);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(191, 63);
            this.pnlHome.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(191, 61);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlChoice
            // 
            this.pnlChoice.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlChoice.Location = new System.Drawing.Point(180, 343);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(10, 62);
            this.pnlChoice.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnlLeft.Controls.Add(this.pnlSettings);
            this.pnlLeft.Controls.Add(this.pnlReports);
            this.pnlLeft.Controls.Add(this.pnlStaff);
            this.pnlLeft.Controls.Add(this.pnlPatients);
            this.pnlLeft.Controls.Add(this.pnlSchedule);
            this.pnlLeft.Controls.Add(this.pnlHome);
            this.pnlLeft.Controls.Add(this.pnlWelcome);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 28);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(191, 682);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlStaff
            // 
            this.pnlStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaff.Controls.Add(this.btnStaff);
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStaff.Location = new System.Drawing.Point(0, 499);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(191, 61);
            this.pnlStaff.TabIndex = 6;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(191, 61);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(191, 105);
            this.pnlLogo.TabIndex = 7;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(192, 105);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // titleBar
            // 
            this.titleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1113, 28);
            this.titleBar.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogo.Location = new System.Drawing.Point(56, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(129, 70);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Patient Scheduler";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CentralScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1113, 710);
            this.Controls.Add(this.pnlChoice);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CentralScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CentralScreen";
            this.Load += new System.EventHandler(this.CentralScreen_Load);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlPatients.ResumeLayout(false);
            this.pnlSchedule.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlStaff.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TitleBar titleBar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlPatients;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}