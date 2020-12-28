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
            this.lblWeekToChange = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComboWeek = new System.Windows.Forms.Button();
            this.boxWeekChoice = new System.Windows.Forms.ComboBox();
            this.titleBar1 = new PatientScheduler.Components.TitleBar();
            this.pnlBottomMenu.SuspendLayout();
            this.pnlCombo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(205, 3);
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
            this.btnCancel.Location = new System.Drawing.Point(475, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlBottomMenu
            // 
            this.pnlBottomMenu.Controls.Add(this.btnCancel);
            this.pnlBottomMenu.Controls.Add(this.btnSave);
            this.pnlBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomMenu.Location = new System.Drawing.Point(0, 484);
            this.pnlBottomMenu.Name = "pnlBottomMenu";
            this.pnlBottomMenu.Size = new System.Drawing.Size(764, 63);
            this.pnlBottomMenu.TabIndex = 6;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(133, 57);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(489, 21);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "You can choose which doctors schedule you\'d like to change:";
            // 
            // lblDocToChange
            // 
            this.lblDocToChange.AutoSize = true;
            this.lblDocToChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocToChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDocToChange.Location = new System.Drawing.Point(196, 114);
            this.lblDocToChange.Name = "lblDocToChange";
            this.lblDocToChange.Size = new System.Drawing.Size(146, 21);
            this.lblDocToChange.TabIndex = 13;
            this.lblDocToChange.Text = "Choose a Doctor:";
            // 
            // pnlCombo
            // 
            this.pnlCombo.BackColor = System.Drawing.Color.DimGray;
            this.pnlCombo.Controls.Add(this.btnComboDoctor);
            this.pnlCombo.Controls.Add(this.boxDoctorChoice);
            this.pnlCombo.Location = new System.Drawing.Point(347, 111);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Size = new System.Drawing.Size(194, 27);
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
            this.btnComboDoctor.Location = new System.Drawing.Point(175, 0);
            this.btnComboDoctor.Name = "btnComboDoctor";
            this.btnComboDoctor.Size = new System.Drawing.Size(19, 27);
            this.btnComboDoctor.TabIndex = 11;
            this.btnComboDoctor.UseVisualStyleBackColor = false;
            this.btnComboDoctor.Click += new System.EventHandler(this.btnComboDoctor_Click);
            // 
            // boxDoctorChoice
            // 
            this.boxDoctorChoice.BackColor = System.Drawing.Color.LightSlateGray;
            this.boxDoctorChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDoctorChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDoctorChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxDoctorChoice.FormattingEnabled = true;
            this.boxDoctorChoice.Location = new System.Drawing.Point(0, 0);
            this.boxDoctorChoice.Name = "boxDoctorChoice";
            this.boxDoctorChoice.Size = new System.Drawing.Size(193, 27);
            this.boxDoctorChoice.TabIndex = 10;
            // 
            // lblWeekToChange
            // 
            this.lblWeekToChange.AutoSize = true;
            this.lblWeekToChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekToChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWeekToChange.Location = new System.Drawing.Point(202, 162);
            this.lblWeekToChange.Name = "lblWeekToChange";
            this.lblWeekToChange.Size = new System.Drawing.Size(135, 21);
            this.lblWeekToChange.TabIndex = 15;
            this.lblWeekToChange.Text = "Choose a Week:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnComboWeek);
            this.panel1.Controls.Add(this.boxWeekChoice);
            this.panel1.Location = new System.Drawing.Point(347, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 27);
            this.panel1.TabIndex = 16;
            // 
            // btnComboWeek
            // 
            this.btnComboWeek.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComboWeek.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnComboWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboWeek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComboWeek.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnComboWeek.Image = ((System.Drawing.Image)(resources.GetObject("btnComboWeek.Image")));
            this.btnComboWeek.Location = new System.Drawing.Point(175, 0);
            this.btnComboWeek.Name = "btnComboWeek";
            this.btnComboWeek.Size = new System.Drawing.Size(19, 27);
            this.btnComboWeek.TabIndex = 11;
            this.btnComboWeek.UseVisualStyleBackColor = false;
            this.btnComboWeek.Click += new System.EventHandler(this.btnComboWeek_Click);
            // 
            // boxWeekChoice
            // 
            this.boxWeekChoice.BackColor = System.Drawing.Color.LightSlateGray;
            this.boxWeekChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxWeekChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWeekChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxWeekChoice.FormattingEnabled = true;
            this.boxWeekChoice.Location = new System.Drawing.Point(0, 0);
            this.boxWeekChoice.Name = "boxWeekChoice";
            this.boxWeekChoice.Size = new System.Drawing.Size(193, 27);
            this.boxWeekChoice.TabIndex = 10;
            // 
            // titleBar1
            // 
            this.titleBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(5);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(764, 28);
            this.titleBar1.TabIndex = 17;
            // 
            // DoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(764, 547);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.lblWeekToChange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDocToChange);
            this.Controls.Add(this.pnlCombo);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.pnlBottomMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorSchedule";
            this.pnlBottomMenu.ResumeLayout(false);
            this.pnlCombo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblWeekToChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComboWeek;
        private System.Windows.Forms.ComboBox boxWeekChoice;
        private Components.TitleBar titleBar1;
    }
}