namespace PatientScheduler.Main.View.ScheduleHelper
{
    partial class DoctorSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSchedule));
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDocToChange = new System.Windows.Forms.Label();
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.btnComboDoctor = new System.Windows.Forms.Button();
            this.boxDoctorChoice = new System.Windows.Forms.ComboBox();
            this.radioWeeklySchedule = new System.Windows.Forms.RadioButton();
            this.radioHolidaySchedule = new System.Windows.Forms.RadioButton();
            this.pnlDocAndType = new System.Windows.Forms.Panel();
            this.pnlWeeklyOfficeSchedule = new System.Windows.Forms.Panel();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblOfficeSchedule = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.titleBar1 = new PatientScheduler.Components.TitleBar();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCombo.SuspendLayout();
            this.pnlDocAndType.SuspendLayout();
            this.pnlWeeklyOfficeSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(80, 30);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(520, 19);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "You can choose which doctors schedule you would like to change";
            // 
            // lblDocToChange
            // 
            this.lblDocToChange.AutoSize = true;
            this.lblDocToChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocToChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDocToChange.Location = new System.Drawing.Point(169, 101);
            this.lblDocToChange.Name = "lblDocToChange";
            this.lblDocToChange.Size = new System.Drawing.Size(146, 21);
            this.lblDocToChange.TabIndex = 13;
            this.lblDocToChange.Text = "Choose a Doctor:";
            // 
            // pnlCombo
            // 
            this.pnlCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlCombo.Controls.Add(this.btnComboDoctor);
            this.pnlCombo.Controls.Add(this.boxDoctorChoice);
            this.pnlCombo.Location = new System.Drawing.Point(321, 98);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Size = new System.Drawing.Size(204, 27);
            this.pnlCombo.TabIndex = 14;
            // 
            // btnComboDoctor
            // 
            this.btnComboDoctor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComboDoctor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnComboDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComboDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnComboDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnComboDoctor.Image")));
            this.btnComboDoctor.Location = new System.Drawing.Point(185, 2);
            this.btnComboDoctor.Name = "btnComboDoctor";
            this.btnComboDoctor.Size = new System.Drawing.Size(19, 24);
            this.btnComboDoctor.TabIndex = 11;
            this.btnComboDoctor.UseVisualStyleBackColor = false;
            this.btnComboDoctor.Click += new System.EventHandler(this.btnComboDoctor_Click);
            // 
            // boxDoctorChoice
            // 
            this.boxDoctorChoice.BackColor = System.Drawing.Color.LightSlateGray;
            this.boxDoctorChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDoctorChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDoctorChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxDoctorChoice.FormattingEnabled = true;
            this.boxDoctorChoice.Location = new System.Drawing.Point(0, 0);
            this.boxDoctorChoice.Name = "boxDoctorChoice";
            this.boxDoctorChoice.Size = new System.Drawing.Size(204, 29);
            this.boxDoctorChoice.TabIndex = 10;
            // 
            // radioWeeklySchedule
            // 
            this.radioWeeklySchedule.AutoSize = true;
            this.radioWeeklySchedule.Location = new System.Drawing.Point(134, 166);
            this.radioWeeklySchedule.Name = "radioWeeklySchedule";
            this.radioWeeklySchedule.Size = new System.Drawing.Size(222, 25);
            this.radioWeeklySchedule.TabIndex = 18;
            this.radioWeeklySchedule.TabStop = true;
            this.radioWeeklySchedule.Text = "Regular Weekly Schedule";
            this.radioWeeklySchedule.UseVisualStyleBackColor = true;
            this.radioWeeklySchedule.CheckedChanged += new System.EventHandler(this.radioWeeklySchedule_CheckedChanged);
            // 
            // radioHolidaySchedule
            // 
            this.radioHolidaySchedule.AutoSize = true;
            this.radioHolidaySchedule.Location = new System.Drawing.Point(397, 166);
            this.radioHolidaySchedule.Name = "radioHolidaySchedule";
            this.radioHolidaySchedule.Size = new System.Drawing.Size(175, 25);
            this.radioHolidaySchedule.TabIndex = 18;
            this.radioHolidaySchedule.TabStop = true;
            this.radioHolidaySchedule.Text = "Holiday Scheduling";
            this.radioHolidaySchedule.UseVisualStyleBackColor = true;
            this.radioHolidaySchedule.CheckedChanged += new System.EventHandler(this.radioSpecialSchedule_CheckedChanged);
            // 
            // pnlDocAndType
            // 
            this.pnlDocAndType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.pnlDocAndType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocAndType.Controls.Add(this.lblChange);
            this.pnlDocAndType.Controls.Add(this.radioHolidaySchedule);
            this.pnlDocAndType.Controls.Add(this.pnlCombo);
            this.pnlDocAndType.Controls.Add(this.radioWeeklySchedule);
            this.pnlDocAndType.Controls.Add(this.lblDocToChange);
            this.pnlDocAndType.Location = new System.Drawing.Point(0, 27);
            this.pnlDocAndType.Name = "pnlDocAndType";
            this.pnlDocAndType.Size = new System.Drawing.Size(696, 257);
            this.pnlDocAndType.TabIndex = 19;
            // 
            // pnlWeeklyOfficeSchedule
            // 
            this.pnlWeeklyOfficeSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnlWeeklyOfficeSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblSunday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblSaturday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblFriday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblThursday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblWednesday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblTuesday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblMonday);
            this.pnlWeeklyOfficeSchedule.Controls.Add(this.lblOfficeSchedule);
            this.pnlWeeklyOfficeSchedule.Location = new System.Drawing.Point(696, 27);
            this.pnlWeeklyOfficeSchedule.Name = "pnlWeeklyOfficeSchedule";
            this.pnlWeeklyOfficeSchedule.Size = new System.Drawing.Size(334, 257);
            this.pnlWeeklyOfficeSchedule.TabIndex = 19;
            // 
            // lblSunday
            // 
            this.lblSunday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(20, 213);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(290, 21);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "Sunday: Closed";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaturday
            // 
            this.lblSaturday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(20, 188);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(290, 21);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday: Closed";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(20, 164);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(290, 21);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday: Closed";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(20, 139);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(290, 21);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday: Closed";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(20, 113);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(290, 21);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday: Closed";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(20, 88);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(290, 21);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday: Closed";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(20, 63);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(290, 21);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday: Closed";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOfficeSchedule
            // 
            this.lblOfficeSchedule.AutoSize = true;
            this.lblOfficeSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeSchedule.Location = new System.Drawing.Point(76, 27);
            this.lblOfficeSchedule.Name = "lblOfficeSchedule";
            this.lblOfficeSchedule.Size = new System.Drawing.Size(191, 19);
            this.lblOfficeSchedule.TabIndex = 0;
            this.lblOfficeSchedule.Text = "Weekly Office Schedule";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(965, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 28);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // titleBar1
            // 
            this.titleBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(5);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1030, 28);
            this.titleBar1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 283);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1030, 418);
            this.pnlBottom.TabIndex = 25;
            // 
            // DoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1030, 702);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.pnlWeeklyOfficeSchedule);
            this.Controls.Add(this.pnlDocAndType);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorSchedule";
            this.Load += new System.EventHandler(this.DoctorSchedule_Load);
            this.pnlCombo.ResumeLayout(false);
            this.pnlDocAndType.ResumeLayout(false);
            this.pnlDocAndType.PerformLayout();
            this.pnlWeeklyOfficeSchedule.ResumeLayout(false);
            this.pnlWeeklyOfficeSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblDocToChange;
        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.Button btnComboDoctor;
        private System.Windows.Forms.ComboBox boxDoctorChoice;
        private System.Windows.Forms.RadioButton radioWeeklySchedule;
        private System.Windows.Forms.RadioButton radioHolidaySchedule;
        private System.Windows.Forms.Panel pnlDocAndType;
        private System.Windows.Forms.Panel pnlWeeklyOfficeSchedule;
        private System.Windows.Forms.Label lblOfficeSchedule;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblSunday;
        private Components.TitleBar titleBar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBottom;
    }
}