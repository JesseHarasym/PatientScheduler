namespace PatientScheduler.Main.View.Custom
{
    partial class Dropdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dropdown));
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.btnCombo = new System.Windows.Forms.Button();
            this.customComboBox = new System.Windows.Forms.ComboBox();
            this.pnlCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCombo
            // 
            this.pnlCombo.BackColor = System.Drawing.Color.DimGray;
            this.pnlCombo.Controls.Add(this.btnCombo);
            this.pnlCombo.Controls.Add(this.customComboBox);
            this.pnlCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCombo.Location = new System.Drawing.Point(0, 0);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Size = new System.Drawing.Size(194, 27);
            this.pnlCombo.TabIndex = 13;
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCombo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCombo.Image")));
            this.btnCombo.Location = new System.Drawing.Point(175, 0);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(19, 27);
            this.btnCombo.TabIndex = 11;
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // customComboBox
            // 
            this.customComboBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.customComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customComboBox.FormattingEnabled = true;
            this.customComboBox.Location = new System.Drawing.Point(0, 0);
            this.customComboBox.Name = "customComboBox";
            this.customComboBox.Size = new System.Drawing.Size(194, 27);
            this.customComboBox.TabIndex = 10;
            this.customComboBox.Click += new System.EventHandler(this.customComboBox_Click);
            // 
            // Dropdown
            // 
            this.Controls.Add(this.pnlCombo);
            this.Name = "Dropdown";
            this.Size = new System.Drawing.Size(194, 27);
            this.pnlCombo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.ComboBox customComboBox;
    }
}
