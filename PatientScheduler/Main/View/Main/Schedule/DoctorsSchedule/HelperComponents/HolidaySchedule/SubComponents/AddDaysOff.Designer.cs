namespace PatientScheduler.Main.View.Main.Schedule.ScheduleHelper.DoctorsSchedule
{
    partial class AddDaysOff
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
            this.lblDaysOff = new System.Windows.Forms.Label();
            this.txtDaysOff = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDaysOff
            // 
            this.lblDaysOff.AutoSize = true;
            this.lblDaysOff.Location = new System.Drawing.Point(63, 0);
            this.lblDaysOff.Name = "lblDaysOff";
            this.lblDaysOff.Size = new System.Drawing.Size(195, 21);
            this.lblDaysOff.TabIndex = 48;
            this.lblDaysOff.Text = "Choose how many days";
            // 
            // txtDaysOff
            // 
            this.txtDaysOff.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtDaysOff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysOff.Location = new System.Drawing.Point(70, 26);
            this.txtDaysOff.Name = "txtDaysOff";
            this.txtDaysOff.Size = new System.Drawing.Size(183, 27);
            this.txtDaysOff.TabIndex = 49;
            this.txtDaysOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDaysOff_KeyDown);
            this.txtDaysOff.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDaysOff_KeyUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(101, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 50;
            this.button1.Text = "Add Days Off";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddDaysOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDaysOff);
            this.Controls.Add(this.lblDaysOff);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddDaysOff";
            this.Size = new System.Drawing.Size(339, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysOff;
        private System.Windows.Forms.MaskedTextBox txtDaysOff;
        private System.Windows.Forms.Button button1;
    }
}
