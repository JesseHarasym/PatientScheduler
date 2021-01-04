namespace PatientScheduler.Main.View.Main.Schedule.DoctorsSchedule.SubComponents
{
    partial class AddSpecificBreaks
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
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.btnAddBreak = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.MaskedTextBox();
            this.lblMonday = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.MaskedTextBox();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.txtBreakStart = new System.Windows.Forms.MaskedTextBox();
            this.txtBreakEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.AutoSize = true;
            this.lblBreakTime.Location = new System.Drawing.Point(52, 80);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(163, 21);
            this.lblBreakTime.TabIndex = 47;
            this.lblBreakTime.Text = "Choose break times";
            // 
            // btnAddBreak
            // 
            this.btnAddBreak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddBreak.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBreak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBreak.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBreak.Location = new System.Drawing.Point(44, 204);
            this.btnAddBreak.Name = "btnAddBreak";
            this.btnAddBreak.Size = new System.Drawing.Size(179, 29);
            this.btnAddBreak.TabIndex = 44;
            this.btnAddBreak.Text = "Add Specified Break";
            this.btnAddBreak.UseVisualStyleBackColor = false;
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(9, 28);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(77, 27);
            this.txtMonth.TabIndex = 51;
            this.txtMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyDown);
            this.txtMonth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyUp);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(74, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(127, 21);
            this.lblMonday.TabIndex = 48;
            this.lblMonday.Text = "Choose a date";
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(92, 28);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(80, 27);
            this.txtDay.TabIndex = 49;
            this.txtDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDay_KeyDown);
            this.txtDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDay_KeyUp);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(178, 28);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 27);
            this.txtYear.TabIndex = 50;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            this.txtYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyUp);
            // 
            // txtBreakStart
            // 
            this.txtBreakStart.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtBreakStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakStart.Location = new System.Drawing.Point(38, 102);
            this.txtBreakStart.Name = "txtBreakStart";
            this.txtBreakStart.Size = new System.Drawing.Size(184, 27);
            this.txtBreakStart.TabIndex = 53;
            this.txtBreakStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBreakStart_KeyDown);
            this.txtBreakStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBreakStart_KeyUp);
            // 
            // txtBreakEnd
            // 
            this.txtBreakEnd.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtBreakEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakEnd.Location = new System.Drawing.Point(38, 135);
            this.txtBreakEnd.Name = "txtBreakEnd";
            this.txtBreakEnd.Size = new System.Drawing.Size(184, 27);
            this.txtBreakEnd.TabIndex = 52;
            this.txtBreakEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBreakEnd_KeyDown);
            this.txtBreakEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBreakEnd_KeyUp);
            // 
            // AddSpecificBreaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.txtBreakStart);
            this.Controls.Add(this.txtBreakEnd);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.btnAddBreak);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddSpecificBreaks";
            this.Size = new System.Drawing.Size(261, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.Button btnAddBreak;
        private System.Windows.Forms.MaskedTextBox txtMonth;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.MaskedTextBox txtDay;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.MaskedTextBox txtBreakStart;
        private System.Windows.Forms.MaskedTextBox txtBreakEnd;
    }
}
