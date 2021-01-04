namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents
{
    partial class AddWeeklyBreaks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWeeklyBreaks));
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.btnComboDoctor = new System.Windows.Forms.Button();
            this.boxDayChoice = new System.Windows.Forms.ComboBox();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.txtBreakStart = new System.Windows.Forms.MaskedTextBox();
            this.txtBreakEnd = new System.Windows.Forms.MaskedTextBox();
            this.btnAddBreak = new System.Windows.Forms.Button();
            this.lblBreakDay = new System.Windows.Forms.Label();
            this.pnlCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCombo
            // 
            this.pnlCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlCombo.Controls.Add(this.btnComboDoctor);
            this.pnlCombo.Controls.Add(this.boxDayChoice);
            this.pnlCombo.Location = new System.Drawing.Point(33, 25);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Size = new System.Drawing.Size(184, 27);
            this.pnlCombo.TabIndex = 44;
            // 
            // btnComboDoctor
            // 
            this.btnComboDoctor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComboDoctor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnComboDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComboDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnComboDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnComboDoctor.Image")));
            this.btnComboDoctor.Location = new System.Drawing.Point(165, 2);
            this.btnComboDoctor.Name = "btnComboDoctor";
            this.btnComboDoctor.Size = new System.Drawing.Size(19, 24);
            this.btnComboDoctor.TabIndex = 11;
            this.btnComboDoctor.UseVisualStyleBackColor = false;
            this.btnComboDoctor.Click += new System.EventHandler(this.btnComboDoctor_Click);
            // 
            // boxDayChoice
            // 
            this.boxDayChoice.BackColor = System.Drawing.Color.LightSlateGray;
            this.boxDayChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDayChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDayChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxDayChoice.FormattingEnabled = true;
            this.boxDayChoice.Items.AddRange(new object[] {
            "Everyday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.boxDayChoice.Location = new System.Drawing.Point(0, 0);
            this.boxDayChoice.Name = "boxDayChoice";
            this.boxDayChoice.Size = new System.Drawing.Size(184, 29);
            this.boxDayChoice.TabIndex = 10;
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.AutoSize = true;
            this.lblBreakTime.Location = new System.Drawing.Point(45, 75);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(163, 21);
            this.lblBreakTime.TabIndex = 43;
            this.lblBreakTime.Text = "Choose break times";
            // 
            // txtBreakStart
            // 
            this.txtBreakStart.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtBreakStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakStart.Location = new System.Drawing.Point(33, 100);
            this.txtBreakStart.Name = "txtBreakStart";
            this.txtBreakStart.Size = new System.Drawing.Size(184, 27);
            this.txtBreakStart.TabIndex = 42;
            this.txtBreakStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBreakStart_KeyDown);
            this.txtBreakStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBreakStart_KeyUp);
            // 
            // txtBreakEnd
            // 
            this.txtBreakEnd.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtBreakEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakEnd.Location = new System.Drawing.Point(33, 133);
            this.txtBreakEnd.Name = "txtBreakEnd";
            this.txtBreakEnd.Size = new System.Drawing.Size(184, 27);
            this.txtBreakEnd.TabIndex = 41;
            this.txtBreakEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBreakEnd_KeyDown);
            this.txtBreakEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBreakEnd_KeyUp);
            // 
            // btnAddBreak
            // 
            this.btnAddBreak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddBreak.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBreak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBreak.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBreak.Location = new System.Drawing.Point(47, 199);
            this.btnAddBreak.Name = "btnAddBreak";
            this.btnAddBreak.Size = new System.Drawing.Size(161, 29);
            this.btnAddBreak.TabIndex = 40;
            this.btnAddBreak.Text = "Add Weekly Break";
            this.btnAddBreak.UseVisualStyleBackColor = false;
            // 
            // lblBreakDay
            // 
            this.lblBreakDay.AutoSize = true;
            this.lblBreakDay.Location = new System.Drawing.Point(67, 0);
            this.lblBreakDay.Name = "lblBreakDay";
            this.lblBreakDay.Size = new System.Drawing.Size(118, 21);
            this.lblBreakDay.TabIndex = 39;
            this.lblBreakDay.Text = "Choose a day";
            // 
            // AddWeeklyBreaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlCombo);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.txtBreakStart);
            this.Controls.Add(this.txtBreakEnd);
            this.Controls.Add(this.btnAddBreak);
            this.Controls.Add(this.lblBreakDay);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddWeeklyBreaks";
            this.Size = new System.Drawing.Size(261, 264);
            this.pnlCombo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.Button btnComboDoctor;
        private System.Windows.Forms.ComboBox boxDayChoice;
        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.MaskedTextBox txtBreakStart;
        private System.Windows.Forms.MaskedTextBox txtBreakEnd;
        private System.Windows.Forms.Button btnAddBreak;
        private System.Windows.Forms.Label lblBreakDay;
    }
}
