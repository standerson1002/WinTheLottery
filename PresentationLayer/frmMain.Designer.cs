namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblDay = new Label();
            btnStartNextDay = new Button();
            lblWinningNum5 = new Label();
            lblWinningNum4 = new Label();
            lblWinningNum3 = new Label();
            lblWinningNum2 = new Label();
            lblWinningNum1 = new Label();
            lblOldBalance = new Label();
            lblOldBalanceValue = new Label();
            lblMoneySpent = new Label();
            lblMoneyMade = new Label();
            lblNewBalance = new Label();
            lblMoneySpentValue = new Label();
            lblMoneyMadeValue = new Label();
            lblNewBalanceValue = new Label();
            lblMoneyMadeCaption = new Label();
            lblNewBalanceCaption = new Label();
            lblMoneySpentCaption = new Label();
            tableLayoutPanelYours = new TableLayoutPanel();
            lblTicketNum5 = new Label();
            lblTicketNum4 = new Label();
            lblTicketNum3 = new Label();
            lblTicketNum2 = new Label();
            lblTicketNum1 = new Label();
            numBuyTickets = new NumericUpDown();
            lblBuyTickets = new Label();
            gboxWinningNumbers = new GroupBox();
            tableLayoutPanelWinning = new TableLayoutPanel();
            gboxYourTicket = new GroupBox();
            btnBack = new Button();
            btnNext = new Button();
            lblAchievementBreakEvenDay = new Label();
            lblAchievementCashFlowDesc = new Label();
            lblAchievementCashFlowTitle = new Label();
            lblAchievementBreakEvenTitle = new Label();
            lblAchievementWinBigTitle = new Label();
            lblAchievementBreakEvenDesc = new Label();
            lblAchievementWinBigDesc = new Label();
            lblAchievementWinBigDay = new Label();
            lblAchievementCashFlowDay = new Label();
            lblAchievements = new Label();
            btnSave = new Button();
            btnSettings = new Button();
            btnHelp = new Button();
            tableLayoutPanelYours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBuyTickets).BeginInit();
            gboxWinningNumbers.SuspendLayout();
            tableLayoutPanelWinning.SuspendLayout();
            gboxYourTicket.SuspendLayout();
            SuspendLayout();
            // 
            // lblDay
            // 
            resources.ApplyResources(lblDay, "lblDay");
            lblDay.BackColor = Color.Black;
            lblDay.ForeColor = Color.White;
            lblDay.Name = "lblDay";
            // 
            // btnStartNextDay
            // 
            resources.ApplyResources(btnStartNextDay, "btnStartNextDay");
            btnStartNextDay.BackColor = Color.Black;
            btnStartNextDay.ForeColor = Color.White;
            btnStartNextDay.Name = "btnStartNextDay";
            btnStartNextDay.UseVisualStyleBackColor = false;
            btnStartNextDay.Click += btnStartDay_Click;
            // 
            // lblWinningNum5
            // 
            resources.ApplyResources(lblWinningNum5, "lblWinningNum5");
            lblWinningNum5.BackColor = Color.Black;
            lblWinningNum5.ForeColor = Color.White;
            lblWinningNum5.Name = "lblWinningNum5";
            // 
            // lblWinningNum4
            // 
            resources.ApplyResources(lblWinningNum4, "lblWinningNum4");
            lblWinningNum4.BackColor = Color.Black;
            lblWinningNum4.ForeColor = Color.White;
            lblWinningNum4.Name = "lblWinningNum4";
            // 
            // lblWinningNum3
            // 
            resources.ApplyResources(lblWinningNum3, "lblWinningNum3");
            lblWinningNum3.BackColor = Color.Black;
            lblWinningNum3.ForeColor = Color.White;
            lblWinningNum3.Name = "lblWinningNum3";
            // 
            // lblWinningNum2
            // 
            resources.ApplyResources(lblWinningNum2, "lblWinningNum2");
            lblWinningNum2.BackColor = Color.Black;
            lblWinningNum2.ForeColor = Color.White;
            lblWinningNum2.Name = "lblWinningNum2";
            // 
            // lblWinningNum1
            // 
            resources.ApplyResources(lblWinningNum1, "lblWinningNum1");
            lblWinningNum1.BackColor = Color.Black;
            lblWinningNum1.ForeColor = Color.White;
            lblWinningNum1.Name = "lblWinningNum1";
            // 
            // lblOldBalance
            // 
            lblOldBalance.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(lblOldBalance, "lblOldBalance");
            lblOldBalance.ForeColor = Color.White;
            lblOldBalance.Name = "lblOldBalance";
            // 
            // lblOldBalanceValue
            // 
            lblOldBalanceValue.BackColor = Color.Black;
            resources.ApplyResources(lblOldBalanceValue, "lblOldBalanceValue");
            lblOldBalanceValue.ForeColor = Color.White;
            lblOldBalanceValue.Name = "lblOldBalanceValue";
            // 
            // lblMoneySpent
            // 
            lblMoneySpent.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(lblMoneySpent, "lblMoneySpent");
            lblMoneySpent.ForeColor = Color.White;
            lblMoneySpent.Name = "lblMoneySpent";
            lblMoneySpent.MouseLeave += lblMoneySpent_MouseLeave;
            lblMoneySpent.MouseHover += lblMoneySpent_MouseHover;
            // 
            // lblMoneyMade
            // 
            lblMoneyMade.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(lblMoneyMade, "lblMoneyMade");
            lblMoneyMade.ForeColor = Color.White;
            lblMoneyMade.Name = "lblMoneyMade";
            lblMoneyMade.MouseLeave += lblMoneyMade_MouseLeave;
            lblMoneyMade.MouseHover += lblMoneyMade_MouseHover;
            // 
            // lblNewBalance
            // 
            lblNewBalance.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(lblNewBalance, "lblNewBalance");
            lblNewBalance.ForeColor = Color.White;
            lblNewBalance.Name = "lblNewBalance";
            lblNewBalance.MouseLeave += lblNewBalance_MouseLeave;
            lblNewBalance.MouseHover += lblNewBalance_MouseHover;
            // 
            // lblMoneySpentValue
            // 
            lblMoneySpentValue.BackColor = Color.Black;
            resources.ApplyResources(lblMoneySpentValue, "lblMoneySpentValue");
            lblMoneySpentValue.ForeColor = Color.Red;
            lblMoneySpentValue.Name = "lblMoneySpentValue";
            // 
            // lblMoneyMadeValue
            // 
            lblMoneyMadeValue.BackColor = Color.Black;
            resources.ApplyResources(lblMoneyMadeValue, "lblMoneyMadeValue");
            lblMoneyMadeValue.ForeColor = Color.Lime;
            lblMoneyMadeValue.Name = "lblMoneyMadeValue";
            // 
            // lblNewBalanceValue
            // 
            lblNewBalanceValue.BackColor = Color.Black;
            resources.ApplyResources(lblNewBalanceValue, "lblNewBalanceValue");
            lblNewBalanceValue.ForeColor = Color.White;
            lblNewBalanceValue.Name = "lblNewBalanceValue";
            // 
            // lblMoneyMadeCaption
            // 
            lblMoneyMadeCaption.ForeColor = Color.White;
            resources.ApplyResources(lblMoneyMadeCaption, "lblMoneyMadeCaption");
            lblMoneyMadeCaption.Name = "lblMoneyMadeCaption";
            // 
            // lblNewBalanceCaption
            // 
            lblNewBalanceCaption.ForeColor = Color.White;
            resources.ApplyResources(lblNewBalanceCaption, "lblNewBalanceCaption");
            lblNewBalanceCaption.Name = "lblNewBalanceCaption";
            // 
            // lblMoneySpentCaption
            // 
            lblMoneySpentCaption.ForeColor = Color.White;
            resources.ApplyResources(lblMoneySpentCaption, "lblMoneySpentCaption");
            lblMoneySpentCaption.Name = "lblMoneySpentCaption";
            // 
            // tableLayoutPanelYours
            // 
            resources.ApplyResources(tableLayoutPanelYours, "tableLayoutPanelYours");
            tableLayoutPanelYours.BackColor = Color.Black;
            tableLayoutPanelYours.Controls.Add(lblTicketNum5, 4, 0);
            tableLayoutPanelYours.Controls.Add(lblTicketNum4, 3, 0);
            tableLayoutPanelYours.Controls.Add(lblTicketNum3, 2, 0);
            tableLayoutPanelYours.Controls.Add(lblTicketNum2, 1, 0);
            tableLayoutPanelYours.Controls.Add(lblTicketNum1, 0, 0);
            tableLayoutPanelYours.Name = "tableLayoutPanelYours";
            // 
            // lblTicketNum5
            // 
            resources.ApplyResources(lblTicketNum5, "lblTicketNum5");
            lblTicketNum5.BackColor = Color.Black;
            lblTicketNum5.ForeColor = Color.White;
            lblTicketNum5.Name = "lblTicketNum5";
            // 
            // lblTicketNum4
            // 
            resources.ApplyResources(lblTicketNum4, "lblTicketNum4");
            lblTicketNum4.BackColor = Color.Black;
            lblTicketNum4.ForeColor = Color.White;
            lblTicketNum4.Name = "lblTicketNum4";
            // 
            // lblTicketNum3
            // 
            resources.ApplyResources(lblTicketNum3, "lblTicketNum3");
            lblTicketNum3.BackColor = Color.Black;
            lblTicketNum3.ForeColor = Color.White;
            lblTicketNum3.Name = "lblTicketNum3";
            // 
            // lblTicketNum2
            // 
            resources.ApplyResources(lblTicketNum2, "lblTicketNum2");
            lblTicketNum2.BackColor = Color.Black;
            lblTicketNum2.ForeColor = Color.White;
            lblTicketNum2.Name = "lblTicketNum2";
            // 
            // lblTicketNum1
            // 
            resources.ApplyResources(lblTicketNum1, "lblTicketNum1");
            lblTicketNum1.BackColor = Color.Black;
            lblTicketNum1.ForeColor = Color.White;
            lblTicketNum1.Name = "lblTicketNum1";
            // 
            // numBuyTickets
            // 
            resources.ApplyResources(numBuyTickets, "numBuyTickets");
            numBuyTickets.BackColor = Color.Black;
            numBuyTickets.ForeColor = Color.White;
            numBuyTickets.Name = "numBuyTickets";
            // 
            // lblBuyTickets
            // 
            resources.ApplyResources(lblBuyTickets, "lblBuyTickets");
            lblBuyTickets.BackColor = Color.Black;
            lblBuyTickets.ForeColor = Color.White;
            lblBuyTickets.Name = "lblBuyTickets";
            // 
            // gboxWinningNumbers
            // 
            resources.ApplyResources(gboxWinningNumbers, "gboxWinningNumbers");
            gboxWinningNumbers.BackColor = Color.DeepSkyBlue;
            gboxWinningNumbers.Controls.Add(tableLayoutPanelWinning);
            gboxWinningNumbers.Name = "gboxWinningNumbers";
            gboxWinningNumbers.TabStop = false;
            // 
            // tableLayoutPanelWinning
            // 
            resources.ApplyResources(tableLayoutPanelWinning, "tableLayoutPanelWinning");
            tableLayoutPanelWinning.BackColor = Color.Black;
            tableLayoutPanelWinning.Controls.Add(lblWinningNum5, 4, 0);
            tableLayoutPanelWinning.Controls.Add(lblWinningNum4, 3, 0);
            tableLayoutPanelWinning.Controls.Add(lblWinningNum3, 2, 0);
            tableLayoutPanelWinning.Controls.Add(lblWinningNum2, 1, 0);
            tableLayoutPanelWinning.Controls.Add(lblWinningNum1, 0, 0);
            tableLayoutPanelWinning.Name = "tableLayoutPanelWinning";
            // 
            // gboxYourTicket
            // 
            resources.ApplyResources(gboxYourTicket, "gboxYourTicket");
            gboxYourTicket.BackColor = Color.DeepSkyBlue;
            gboxYourTicket.Controls.Add(tableLayoutPanelYours);
            gboxYourTicket.Controls.Add(btnBack);
            gboxYourTicket.Controls.Add(btnNext);
            gboxYourTicket.Name = "gboxYourTicket";
            gboxYourTicket.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.ForeColor = Color.White;
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnPreviousTicket_Click;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.BackColor = Color.Black;
            btnNext.ForeColor = Color.White;
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNextTicket_Click;
            // 
            // lblAchievementBreakEvenDay
            // 
            resources.ApplyResources(lblAchievementBreakEvenDay, "lblAchievementBreakEvenDay");
            lblAchievementBreakEvenDay.BackColor = Color.LightGray;
            lblAchievementBreakEvenDay.ForeColor = SystemColors.ControlText;
            lblAchievementBreakEvenDay.Name = "lblAchievementBreakEvenDay";
            // 
            // lblAchievementCashFlowDesc
            // 
            resources.ApplyResources(lblAchievementCashFlowDesc, "lblAchievementCashFlowDesc");
            lblAchievementCashFlowDesc.BackColor = Color.LightGray;
            lblAchievementCashFlowDesc.ForeColor = SystemColors.ControlText;
            lblAchievementCashFlowDesc.Name = "lblAchievementCashFlowDesc";
            // 
            // lblAchievementCashFlowTitle
            // 
            lblAchievementCashFlowTitle.BackColor = Color.LightGray;
            resources.ApplyResources(lblAchievementCashFlowTitle, "lblAchievementCashFlowTitle");
            lblAchievementCashFlowTitle.ForeColor = SystemColors.ControlText;
            lblAchievementCashFlowTitle.Name = "lblAchievementCashFlowTitle";
            // 
            // lblAchievementBreakEvenTitle
            // 
            resources.ApplyResources(lblAchievementBreakEvenTitle, "lblAchievementBreakEvenTitle");
            lblAchievementBreakEvenTitle.BackColor = Color.LightGray;
            lblAchievementBreakEvenTitle.ForeColor = SystemColors.ControlText;
            lblAchievementBreakEvenTitle.Name = "lblAchievementBreakEvenTitle";
            // 
            // lblAchievementWinBigTitle
            // 
            resources.ApplyResources(lblAchievementWinBigTitle, "lblAchievementWinBigTitle");
            lblAchievementWinBigTitle.BackColor = Color.LightGray;
            lblAchievementWinBigTitle.ForeColor = SystemColors.ControlText;
            lblAchievementWinBigTitle.Name = "lblAchievementWinBigTitle";
            // 
            // lblAchievementBreakEvenDesc
            // 
            resources.ApplyResources(lblAchievementBreakEvenDesc, "lblAchievementBreakEvenDesc");
            lblAchievementBreakEvenDesc.BackColor = Color.LightGray;
            lblAchievementBreakEvenDesc.ForeColor = SystemColors.ControlText;
            lblAchievementBreakEvenDesc.Name = "lblAchievementBreakEvenDesc";
            // 
            // lblAchievementWinBigDesc
            // 
            resources.ApplyResources(lblAchievementWinBigDesc, "lblAchievementWinBigDesc");
            lblAchievementWinBigDesc.BackColor = Color.LightGray;
            lblAchievementWinBigDesc.ForeColor = SystemColors.ControlText;
            lblAchievementWinBigDesc.Name = "lblAchievementWinBigDesc";
            // 
            // lblAchievementWinBigDay
            // 
            resources.ApplyResources(lblAchievementWinBigDay, "lblAchievementWinBigDay");
            lblAchievementWinBigDay.BackColor = Color.LightGray;
            lblAchievementWinBigDay.ForeColor = SystemColors.ControlText;
            lblAchievementWinBigDay.Name = "lblAchievementWinBigDay";
            // 
            // lblAchievementCashFlowDay
            // 
            resources.ApplyResources(lblAchievementCashFlowDay, "lblAchievementCashFlowDay");
            lblAchievementCashFlowDay.BackColor = Color.LightGray;
            lblAchievementCashFlowDay.ForeColor = SystemColors.ControlText;
            lblAchievementCashFlowDay.Name = "lblAchievementCashFlowDay";
            // 
            // lblAchievements
            // 
            resources.ApplyResources(lblAchievements, "lblAchievements");
            lblAchievements.BackColor = Color.Black;
            lblAchievements.ForeColor = Color.White;
            lblAchievements.Name = "lblAchievements";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.ForeColor = Color.White;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Black;
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.ForeColor = Color.White;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.Black;
            resources.ApplyResources(btnHelp, "btnHelp");
            btnHelp.ForeColor = Color.White;
            btnHelp.Name = "btnHelp";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(btnHelp);
            Controls.Add(btnSettings);
            Controls.Add(btnSave);
            Controls.Add(lblAchievementWinBigTitle);
            Controls.Add(lblAchievementBreakEvenTitle);
            Controls.Add(lblAchievementWinBigDesc);
            Controls.Add(lblAchievementBreakEvenDay);
            Controls.Add(lblNewBalanceCaption);
            Controls.Add(lblAchievementBreakEvenDesc);
            Controls.Add(lblAchievementCashFlowDesc);
            Controls.Add(lblDay);
            Controls.Add(lblAchievementWinBigDay);
            Controls.Add(lblAchievementCashFlowTitle);
            Controls.Add(lblNewBalanceValue);
            Controls.Add(lblMoneyMadeValue);
            Controls.Add(lblAchievementCashFlowDay);
            Controls.Add(lblNewBalance);
            Controls.Add(lblMoneyMadeCaption);
            Controls.Add(lblAchievements);
            Controls.Add(lblMoneySpentValue);
            Controls.Add(lblMoneyMade);
            Controls.Add(lblMoneySpentCaption);
            Controls.Add(lblMoneySpent);
            Controls.Add(gboxWinningNumbers);
            Controls.Add(lblOldBalanceValue);
            Controls.Add(lblBuyTickets);
            Controls.Add(numBuyTickets);
            Controls.Add(lblOldBalance);
            Controls.Add(btnStartNextDay);
            Controls.Add(gboxYourTicket);
            Name = "frmMain";
            tableLayoutPanelYours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numBuyTickets).EndInit();
            gboxWinningNumbers.ResumeLayout(false);
            tableLayoutPanelWinning.ResumeLayout(false);
            gboxYourTicket.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDay;
        private Button btnStartNextDay;
        private Label lblOldBalance;
        private Label lblOldBalanceValue;
        private Label lblWinningNum5;
        private Label lblWinningNum4;
        private Label lblWinningNum3;
        private Label lblWinningNum2;
        private Label lblWinningNum1;
        private Label lblMoneySpent;
        private Label lblMoneyMade;
        private Label lblNewBalance;
        private Label lblMoneySpentValue;
        private Label lblMoneyMadeValue;
        private Label lblNewBalanceValue;
        private TableLayoutPanel tableLayoutPanelYours;
        private Label lblTicketNum5;
        private Label lblTicketNum4;
        private Label lblTicketNum3;
        private Label lblTicketNum2;
        private Label lblTicketNum1;
        private Label lblMoneySpentCaption;
        private NumericUpDown numBuyTickets;
        private Label lblBuyTickets;
        private GroupBox gboxWinningNumbers;
        private GroupBox gboxYourTicket;
        private Button btnBack;
        private Button btnNext;
        private Label lblNewBalanceCaption;
        private Label lblMoneyMadeCaption;
        private Label lblAchievementCashFlowDesc;
        private Label lblAchievements;
        private Label lblAchievementCashFlowTitle;
        private Label lblAchievementCashFlowDay;
        private Label lblAchievementBreakEvenDay;
        private Label lblAchievementBreakEvenTitle;
        private Label lblAchievementWinBigTitle;
        private Label lblAchievementBreakEvenDesc;
        private Label lblAchievementWinBigDesc;
        private Label lblAchievementWinBigDay;
        private TableLayoutPanel tableLayoutPanelWinning;
        private Button btnSave;
        private Button btnSettings;
        private Button btnHelp;
    }
}
