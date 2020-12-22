namespace PatientScheduler.Components.Custom
{
    partial class UserMessage
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
            this.btnDimiss = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDimiss
            // 
            this.btnDimiss.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDimiss.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDimiss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDimiss.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDimiss.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDimiss.Location = new System.Drawing.Point(150, 79);
            this.btnDimiss.Name = "btnDimiss";
            this.btnDimiss.Size = new System.Drawing.Size(93, 32);
            this.btnDimiss.TabIndex = 0;
            this.btnDimiss.Text = "Dismiss";
            this.btnDimiss.UseVisualStyleBackColor = false;
            this.btnDimiss.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(380, 57);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(404, 128);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDimiss);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMessage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDimiss;
        private System.Windows.Forms.Label lblMessage;
    }
}