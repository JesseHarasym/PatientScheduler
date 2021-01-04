namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    partial class AddModifiedTimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
            this.btnAddModified = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Modified Times";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtStartTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(53, 26);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(113, 27);
            this.txtStartTime.TabIndex = 45;
            this.txtStartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartTime_KeyDown);
            this.txtStartTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartTime_KeyUp);
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(165, 24);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(15, 21);
            this.lblSeperator.TabIndex = 47;
            this.lblSeperator.Text = "-";
            // 
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtEndTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(179, 26);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(118, 27);
            this.txtEndTime.TabIndex = 46;
            this.txtEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndTime_KeyDown);
            this.txtEndTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEndTime_KeyUp);
            // 
            // btnAddModified
            // 
            this.btnAddModified.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddModified.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModified.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModified.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddModified.Location = new System.Drawing.Point(87, 95);
            this.btnAddModified.Name = "btnAddModified";
            this.btnAddModified.Size = new System.Drawing.Size(181, 29);
            this.btnAddModified.TabIndex = 51;
            this.btnAddModified.Text = "Add Modified Times";
            this.btnAddModified.UseVisualStyleBackColor = false;
            // 
            // AddModifiedTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnAddModified);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.txtEndTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddModifiedTimes";
            this.Size = new System.Drawing.Size(339, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.MaskedTextBox txtEndTime;
        private System.Windows.Forms.Button btnAddModified;
    }
}
