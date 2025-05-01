namespace PresentationLayer
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            lblDifficultySettings = new Label();
            numChangePrice = new NumericUpDown();
            lblChangeTicketPrice = new Label();
            comTicketColor = new ComboBox();
            lblChangeTicketColor = new Label();
            btnApply = new Button();
            btnReset = new Button();
            btnResetAchievements = new Button();
            lblChangePayoutMultiplier = new Label();
            numPayoutMultiplier = new NumericUpDown();
            lblChangeDayType = new Label();
            comDayType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numChangePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPayoutMultiplier).BeginInit();
            SuspendLayout();
            // 
            // lblDifficultySettings
            // 
            lblDifficultySettings.BackColor = Color.Black;
            lblDifficultySettings.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficultySettings.ForeColor = Color.White;
            lblDifficultySettings.Location = new Point(12, 11);
            lblDifficultySettings.Name = "lblDifficultySettings";
            lblDifficultySettings.Size = new Size(704, 61);
            lblDifficultySettings.TabIndex = 0;
            lblDifficultySettings.Text = "Settings";
            lblDifficultySettings.TextAlign = ContentAlignment.TopCenter;
            // 
            // numChangePrice
            // 
            numChangePrice.BackColor = Color.Black;
            numChangePrice.Font = new Font("Segoe UI", 12F);
            numChangePrice.ForeColor = Color.White;
            numChangePrice.Location = new Point(16, 116);
            numChangePrice.Name = "numChangePrice";
            numChangePrice.Size = new Size(338, 39);
            numChangePrice.TabIndex = 1;
            // 
            // lblChangeTicketPrice
            // 
            lblChangeTicketPrice.Font = new Font("Segoe UI", 14F);
            lblChangeTicketPrice.ForeColor = Color.White;
            lblChangeTicketPrice.Location = new Point(16, 75);
            lblChangeTicketPrice.Name = "lblChangeTicketPrice";
            lblChangeTicketPrice.Size = new Size(338, 38);
            lblChangeTicketPrice.TabIndex = 2;
            lblChangeTicketPrice.Text = "Change Ticket Price:";
            lblChangeTicketPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comTicketColor
            // 
            comTicketColor.BackColor = Color.Black;
            comTicketColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comTicketColor.Font = new Font("Segoe UI", 12F);
            comTicketColor.ForeColor = Color.White;
            comTicketColor.FormattingEnabled = true;
            comTicketColor.Items.AddRange(new object[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink" });
            comTicketColor.Location = new Point(364, 116);
            comTicketColor.Name = "comTicketColor";
            comTicketColor.Size = new Size(352, 40);
            comTicketColor.TabIndex = 5;
            // 
            // lblChangeTicketColor
            // 
            lblChangeTicketColor.Font = new Font("Segoe UI", 14F);
            lblChangeTicketColor.ForeColor = Color.White;
            lblChangeTicketColor.Location = new Point(364, 75);
            lblChangeTicketColor.Name = "lblChangeTicketColor";
            lblChangeTicketColor.Size = new Size(352, 38);
            lblChangeTicketColor.TabIndex = 6;
            lblChangeTicketColor.Text = "Change Ticket Color:";
            lblChangeTicketColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Black;
            btnApply.Font = new Font("Segoe UI", 14F);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(364, 305);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(352, 59);
            btnApply.TabIndex = 7;
            btnApply.Text = "Apply Settings";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Black;
            btnReset.Font = new Font("Segoe UI", 14F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(12, 305);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(342, 59);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Settings";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnResetAchievements
            // 
            btnResetAchievements.BackColor = Color.Black;
            btnResetAchievements.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResetAchievements.ForeColor = Color.Red;
            btnResetAchievements.Location = new Point(12, 370);
            btnResetAchievements.Name = "btnResetAchievements";
            btnResetAchievements.Size = new Size(704, 62);
            btnResetAchievements.TabIndex = 9;
            btnResetAchievements.Text = "Reset Achievements";
            btnResetAchievements.UseVisualStyleBackColor = false;
            btnResetAchievements.Click += btnResetAchievements_Click;
            // 
            // lblChangePayoutMultiplier
            // 
            lblChangePayoutMultiplier.Font = new Font("Segoe UI", 14F);
            lblChangePayoutMultiplier.ForeColor = Color.White;
            lblChangePayoutMultiplier.Location = new Point(12, 174);
            lblChangePayoutMultiplier.Name = "lblChangePayoutMultiplier";
            lblChangePayoutMultiplier.Size = new Size(338, 38);
            lblChangePayoutMultiplier.TabIndex = 11;
            lblChangePayoutMultiplier.Text = "Change Payout Multiplier:";
            lblChangePayoutMultiplier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numPayoutMultiplier
            // 
            numPayoutMultiplier.BackColor = Color.Black;
            numPayoutMultiplier.Font = new Font("Segoe UI", 12F);
            numPayoutMultiplier.ForeColor = Color.White;
            numPayoutMultiplier.Location = new Point(12, 215);
            numPayoutMultiplier.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numPayoutMultiplier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPayoutMultiplier.Name = "numPayoutMultiplier";
            numPayoutMultiplier.Size = new Size(338, 39);
            numPayoutMultiplier.TabIndex = 10;
            numPayoutMultiplier.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblChangeDayType
            // 
            lblChangeDayType.Font = new Font("Segoe UI", 14F);
            lblChangeDayType.ForeColor = Color.White;
            lblChangeDayType.Location = new Point(364, 174);
            lblChangeDayType.Name = "lblChangeDayType";
            lblChangeDayType.Size = new Size(352, 38);
            lblChangeDayType.TabIndex = 13;
            lblChangeDayType.Text = "Change Day Type:";
            lblChangeDayType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comDayType
            // 
            comDayType.BackColor = Color.Black;
            comDayType.DropDownStyle = ComboBoxStyle.DropDownList;
            comDayType.Font = new Font("Segoe UI", 12F);
            comDayType.ForeColor = Color.White;
            comDayType.FormattingEnabled = true;
            comDayType.Items.AddRange(new object[] { "Numbers", "Numeric", "RomanNumerals", "Binary" });
            comDayType.Location = new Point(364, 215);
            comDayType.Name = "comDayType";
            comDayType.Size = new Size(352, 40);
            comDayType.TabIndex = 12;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(728, 444);
            Controls.Add(lblChangeDayType);
            Controls.Add(comDayType);
            Controls.Add(lblChangePayoutMultiplier);
            Controls.Add(numPayoutMultiplier);
            Controls.Add(btnResetAchievements);
            Controls.Add(btnReset);
            Controls.Add(btnApply);
            Controls.Add(lblChangeTicketColor);
            Controls.Add(comTicketColor);
            Controls.Add(lblChangeTicketPrice);
            Controls.Add(numChangePrice);
            Controls.Add(lblDifficultySettings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(750, 500);
            Name = "frmSettings";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            TopMost = true;
            Load += frmDifficultySettings_Load;
            ((System.ComponentModel.ISupportInitialize)numChangePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPayoutMultiplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDifficultySettings;
        private NumericUpDown numChangePrice;
        private Label lblChangeTicketPrice;
        private ComboBox comTicketColor;
        private Label lblChangeTicketColor;
        private Button btnApply;
        private Button btnReset;
        private Button btnResetAchievements;
        private Label lblChangePayoutMultiplier;
        private NumericUpDown numPayoutMultiplier;
        private Label lblChangeDayType;
        private ComboBox comDayType;
    }
}