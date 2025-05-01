namespace PresentationLayer
{
    partial class frmInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructions));
            lblGoal = new Label();
            lblScoring = new Label();
            lblPayouts = new Label();
            pictureBox1 = new PictureBox();
            lblBuyingTicketsDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblGoal
            // 
            lblGoal.BackColor = Color.Black;
            lblGoal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoal.ForeColor = Color.White;
            lblGoal.Location = new Point(12, 12);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(449, 214);
            lblGoal.TabIndex = 0;
            lblGoal.Text = "How To Play:";
            lblGoal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoring
            // 
            lblScoring.BackColor = Color.Red;
            lblScoring.ForeColor = Color.White;
            lblScoring.Location = new Point(1326, 53);
            lblScoring.Name = "lblScoring";
            lblScoring.Size = new Size(240, 173);
            lblScoring.TabIndex = 2;
            lblScoring.Text = "Scoring";
            lblScoring.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPayouts
            // 
            lblPayouts.BackColor = Color.FromArgb(192, 0, 0);
            lblPayouts.Font = new Font("Segoe UI", 15F);
            lblPayouts.ForeColor = Color.White;
            lblPayouts.Location = new Point(1326, 12);
            lblPayouts.Name = "lblPayouts";
            lblPayouts.Size = new Size(240, 41);
            lblPayouts.TabIndex = 5;
            lblPayouts.Text = "Payouts:";
            lblPayouts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WinTheLottery;
            pictureBox1.Location = new Point(467, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblBuyingTicketsDesc
            // 
            lblBuyingTicketsDesc.Font = new Font("Segoe UI", 12F);
            lblBuyingTicketsDesc.ForeColor = Color.White;
            lblBuyingTicketsDesc.Location = new Point(12, 241);
            lblBuyingTicketsDesc.Name = "lblBuyingTicketsDesc";
            lblBuyingTicketsDesc.Size = new Size(1554, 531);
            lblBuyingTicketsDesc.TabIndex = 7;
            lblBuyingTicketsDesc.Text = resources.GetString("lblBuyingTicketsDesc.Text");
            // 
            // frmInstructions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1578, 844);
            Controls.Add(lblBuyingTicketsDesc);
            Controls.Add(pictureBox1);
            Controls.Add(lblGoal);
            Controls.Add(lblPayouts);
            Controls.Add(lblScoring);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(800, 500);
            Name = "frmInstructions";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Instructions";
            Load += frmInstructions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGoal;
        private Label lblScoring;
        private Label lblPayouts;
        private PictureBox pictureBox1;
        private Label lblBuyingTicketsDesc;
    }
}