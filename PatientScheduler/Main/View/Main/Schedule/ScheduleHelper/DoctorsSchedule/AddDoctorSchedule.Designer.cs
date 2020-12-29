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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlBottomMenu = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDocToChange = new System.Windows.Forms.Label();
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.btnComboDoctor = new System.Windows.Forms.Button();
            this.boxDoctorChoice = new System.Windows.Forms.ComboBox();
            this.radioWeeklySchedule = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pnlDocAndType = new System.Windows.Forms.Panel();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.pnlSeeBreaks = new System.Windows.Forms.Panel();
            this.titleBar1 = new PatientScheduler.Components.TitleBar();
            this.pnlBottomMenu.SuspendLayout();
            this.pnlCombo.SuspendLayout();
            this.pnlDocAndType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(359, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(629, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlBottomMenu
            // 
            this.pnlBottomMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottomMenu.Controls.Add(this.btnCancel);
            this.pnlBottomMenu.Controls.Add(this.btnSave);
            this.pnlBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomMenu.Location = new System.Drawing.Point(0, 484);
            this.pnlBottomMenu.Name = "pnlBottomMenu";
            this.pnlBottomMenu.Size = new System.Drawing.Size(1145, 74);
            this.pnlBottomMenu.TabIndex = 6;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(277, 18);
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
            this.lblDocToChange.Location = new System.Drawing.Point(127, 72);
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
            this.pnlCombo.Location = new System.Drawing.Point(279, 69);
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
            this.radioWeeklySchedule.Location = new System.Drawing.Point(535, 70);
            this.radioWeeklySchedule.Name = "radioWeeklySchedule";
            this.radioWeeklySchedule.Size = new System.Drawing.Size(222, 25);
            this.radioWeeklySchedule.TabIndex = 18;
            this.radioWeeklySchedule.TabStop = true;
            this.radioWeeklySchedule.Text = "Regular Weekly Schedule";
            this.radioWeeklySchedule.UseVisualStyleBackColor = true;
            this.radioWeeklySchedule.CheckedChanged += new System.EventHandler(this.radioWeeklySchedule_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(799, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(174, 25);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Special Scheduling";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pnlDocAndType
            // 
            this.pnlDocAndType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocAndType.Controls.Add(this.lblChange);
            this.pnlDocAndType.Controls.Add(this.radioButton2);
            this.pnlDocAndType.Controls.Add(this.pnlCombo);
            this.pnlDocAndType.Controls.Add(this.radioWeeklySchedule);
            this.pnlDocAndType.Controls.Add(this.lblDocToChange);
            this.pnlDocAndType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocAndType.Location = new System.Drawing.Point(0, 28);
            this.pnlDocAndType.Name = "pnlDocAndType";
            this.pnlDocAndType.Size = new System.Drawing.Size(1145, 129);
            this.pnlDocAndType.TabIndex = 19;
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Location = new System.Drawing.Point(0, 156);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(813, 330);
            this.pnlSchedule.TabIndex = 21;
            // 
            // pnlSeeBreaks
            // 
            this.pnlSeeBreaks.Location = new System.Drawing.Point(811, 156);
            this.pnlSeeBreaks.Name = "pnlSeeBreaks";
            this.pnlSeeBreaks.Size = new System.Drawing.Size(334, 330);
            this.pnlSeeBreaks.TabIndex = 22;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.titleBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1145, 28);
            this.titleBar1.TabIndex = 17;
            // 
            // DoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1145, 558);
            this.Controls.Add(this.pnlSeeBreaks);
            this.Controls.Add(this.pnlSchedule);
            this.Controls.Add(this.pnlDocAndType);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.pnlBottomMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorSchedule";
            this.Load += new System.EventHandler(this.DoctorSchedule_Load);
            this.pnlBottomMenu.ResumeLayout(false);
            this.pnlCombo.ResumeLayout(false);
            this.pnlDocAndType.ResumeLayout(false);
            this.pnlDocAndType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlBottomMenu;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblDocToChange;
        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.Button btnComboDoctor;
        private System.Windows.Forms.ComboBox boxDoctorChoice;
        private Components.TitleBar titleBar1;
        private System.Windows.Forms.RadioButton radioWeeklySchedule;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel pnlDocAndType;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Panel pnlSeeBreaks;
    }
}