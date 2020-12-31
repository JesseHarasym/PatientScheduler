namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.HelperComponents
{
    partial class AddNewBreak
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
            this.lblBreaks = new System.Windows.Forms.Label();
            this.radioSpecificDate = new System.Windows.Forms.RadioButton();
            this.radioWeeklyBreak = new System.Windows.Forms.RadioButton();
            this.pnlAddBreak = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblBreaks
            // 
            this.lblBreaks.AutoSize = true;
            this.lblBreaks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreaks.Location = new System.Drawing.Point(43, 14);
            this.lblBreaks.Name = "lblBreaks";
            this.lblBreaks.Size = new System.Drawing.Size(177, 19);
            this.lblBreaks.TabIndex = 42;
            this.lblBreaks.Text = "Schedule Break Times";
            // 
            // radioSpecificDate
            // 
            this.radioSpecificDate.AutoSize = true;
            this.radioSpecificDate.Location = new System.Drawing.Point(36, 104);
            this.radioSpecificDate.Name = "radioSpecificDate";
            this.radioSpecificDate.Size = new System.Drawing.Size(174, 25);
            this.radioSpecificDate.TabIndex = 40;
            this.radioSpecificDate.TabStop = true;
            this.radioSpecificDate.Text = "Specify Break Date";
            this.radioSpecificDate.UseVisualStyleBackColor = true;
            this.radioSpecificDate.CheckedChanged += new System.EventHandler(this.radioSpecificDate_CheckedChanged);
            // 
            // radioWeeklyBreak
            // 
            this.radioWeeklyBreak.AutoSize = true;
            this.radioWeeklyBreak.Location = new System.Drawing.Point(36, 60);
            this.radioWeeklyBreak.Name = "radioWeeklyBreak";
            this.radioWeeklyBreak.Size = new System.Drawing.Size(193, 25);
            this.radioWeeklyBreak.TabIndex = 41;
            this.radioWeeklyBreak.TabStop = true;
            this.radioWeeklyBreak.Text = "Regular Weekly Break";
            this.radioWeeklyBreak.UseVisualStyleBackColor = true;
            this.radioWeeklyBreak.CheckedChanged += new System.EventHandler(this.radioWeeklyBreak_CheckedChanged);
            // 
            // pnlAddBreak
            // 
            this.pnlAddBreak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddBreak.Location = new System.Drawing.Point(0, 154);
            this.pnlAddBreak.Name = "pnlAddBreak";
            this.pnlAddBreak.Size = new System.Drawing.Size(261, 264);
            this.pnlAddBreak.TabIndex = 43;
            // 
            // AddNewBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlAddBreak);
            this.Controls.Add(this.lblBreaks);
            this.Controls.Add(this.radioSpecificDate);
            this.Controls.Add(this.radioWeeklyBreak);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddNewBreak";
            this.Size = new System.Drawing.Size(261, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreaks;
        private System.Windows.Forms.RadioButton radioSpecificDate;
        private System.Windows.Forms.RadioButton radioWeeklyBreak;
        private System.Windows.Forms.Panel pnlAddBreak;
    }
}
