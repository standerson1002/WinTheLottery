using GameObjects;
using LogicLayer;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private int day = 1;
        private string dayText;
        private string dayType;

        private int moneySpent = 0;
        private int moneyMade = 0;
        private int money = 100;
        private int newBalance;

        private string ticketColor = "Blue";
        private int ticketsBought = 0;
        private int ticketCount = 0;
        private int ticketPrice = 5;

        private int[] winningTickets;
        private int[,] ticketNum = { { 0, 0, 0, 0, 0 } };

        private bool cashFlow;
        private bool winBig;
        private bool breakEven;

        private int payoutMultiplier = 1;



        DataManager dataManager = new DataManager();
        Achievements achievements = new Achievements();
        Tickets ticketNumbers = new Tickets();


        public frmMain()
        {
            InitializeComponent();
            newGame();
        } // end of frmMain()

        private void newGame()
        {
            nextDayEnabled(true);
            hideAchievements("CashFlow");
            hideAchievements("BreakEven");
            hideAchievements("WinBig");

            cashFlow = false;
            winBig = false;
            breakEven = false;

            btnNext.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Visible = false;
            btnBack.Visible = false;

            lblMoneySpentCaption.Visible = false;
            lblMoneyMadeCaption.Visible = false;
            lblNewBalanceCaption.Visible = false;

            // Start with $100
            money = 100;
            newBalance = 100;
            day = 1;

            resetValues();
            updateMoneyLabels();
            clearTickets();
        } // end of newGame()

        private void gameOverCheck()
        {
            
            if (newBalance == 0 && ticketPrice != 0 || numBuyTickets.Maximum < 1 || ticketPrice > newBalance)
            {
                lblNewBalanceValue.ForeColor = Color.Red;
                nextDayEnabled(false);

                // check for new game
                DialogResult answer = MessageBox.Show("You cannot afford to buy more tickets!\nYou can change the ticket price in settings to keep playing.\nStart New Game?", "Game Over",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (answer == DialogResult.Yes)
                {
                    newGame();
                }
                
            }
            
        } // end of gameOverCheck()

        private void btnStartDay_Click(object sender, EventArgs e)
        {
            if ((int)numBuyTickets.Value == 0) // make sure tickets are bought
            {
                MessageBox.Show("You need to buy tickets!",
                    "Invalid Ticket Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numBuyTickets.Value = 1;
            }
            else
            {
                // update the day
                day += 1;
                updateDayLabels();

                // update tickets
                winningTickets = ticketNumbers.GetWinningTickets();
                lblWinningNum1.Text = winningTickets[0].ToString();
                lblWinningNum2.Text = winningTickets[1].ToString();
                lblWinningNum3.Text = winningTickets[2].ToString();
                lblWinningNum4.Text = winningTickets[3].ToString();
                lblWinningNum5.Text = winningTickets[4].ToString();

                ticketsBought = (int)numBuyTickets.Value;
                ticketNum = ticketNumbers.GetTickets(ticketsBought);
                moneyMade = ticketNumbers.ScoreTickets(ticketNum, ticketsBought) * payoutMultiplier;

                // check for Win Big
                winBig = ticketNumbers.WinBig;
                if (winBig == true)
                {
                    MessageBox.Show("You Won Big!");
                    nextDayEnabled(false);
                    showAchievements("WinBig", day);
                    achievements.EnableWinBig(day);
                }

                ticketCount = 0;
                displayTickets();

                // determine profits or losses
                moneySpent = ticketPrice * ticketsBought;
                money = newBalance;
                newBalance = money - moneySpent + moneyMade;
                if (moneyMade > moneySpent)
                {
                    // profits have Lime text
                    lblNewBalanceValue.ForeColor = Color.Lime;

                    // unlock achievement(s)
                    if (!cashFlow)
                    {
                        showAchievements("CashFlow", day);
                        achievements.EnableCashFlow(day);
                    }
                    if (!breakEven && newBalance > 100)
                    {
                        showAchievements("BreakEven", day);
                        achievements.EnableBreakEven(day);
                    }
                }
                else if (moneyMade < moneySpent)
                {
                    // losses have red text
                    lblNewBalanceValue.ForeColor = Color.Red;
                }
                else
                {
                    // no change has White text
                    lblNewBalanceValue.ForeColor = Color.White;
                }
                updateMoneyLabels();

                // check if being broke is okay
                if (ticketPrice > 0)
                {
                    numBuyTickets.Maximum = (int)(newBalance / ticketPrice);
                }
                
                else
                {
                    nextDayEnabled(true);
                    numBuyTickets.Maximum = 100;
                }

                // order tickets
                ticketCount = 0;
                gboxYourTicket.Text = "Ticket #" + (ticketCount + 1);

                if (ticketsBought > 1)
                {
                    btnNext.Enabled = true;
                    btnNext.Visible = true;
                    btnBack.Enabled = false;
                    btnBack.Visible = false;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnNext.Visible = false;
                    btnBack.Enabled = false;
                    btnBack.Visible = false;
                }

                gameOverCheck();

            }
        }


        // Mouse Hover //
        private void lblMoneySpent_MouseHover(object sender, EventArgs e)
        {
            lblMoneySpentCaption.Text = "Tickets Bought (" + ticketsBought +
                ") * Ticket Price (" + ticketPrice + ") = " + moneySpent;
            lblMoneySpentCaption.Visible = true;
        }
        private void lblMoneySpent_MouseLeave(object sender, EventArgs e)
        {
            lblMoneySpentCaption.Visible = false;
        }
        private void lblNewBalance_MouseHover(object sender, EventArgs e)
        {
            lblNewBalanceCaption.Text = "Net Change: " +
                (moneyMade - moneySpent).ToString("c").Replace('(', '-').Replace(')', ' ');
            lblNewBalanceCaption.Visible = true;
        }
        private void lblNewBalance_MouseLeave(object sender, EventArgs e)
        {
            lblNewBalanceCaption.Visible = false;
        }
        private void lblMoneyMade_MouseHover(object sender, EventArgs e)
        {
            lblMoneyMadeCaption.Visible = true;
        }
        private void lblMoneyMade_MouseLeave(object sender, EventArgs e)
        {
            lblMoneyMadeCaption.Visible = false;
        }


        // Game Save //
        private void loadSaveGame(int saveSlot)
        {
            try
            {
                achievements.RetrieveAchievementData(saveSlot);

                // Cash Flow //
                cashFlow = achievements.ReturnCashFlow();
                int dayCashFlow = achievements.ReturnCashFlowDay();
                if (cashFlow) { showAchievements("CashFlow", dayCashFlow); }
                else { hideAchievements("CashFlow"); }

                // Break Even //
                breakEven = achievements.ReturnBreakEven();
                int dayBreakEven = achievements.ReturnBreakEvenDay();
                if (breakEven) { showAchievements("BreakEven", dayBreakEven); }
                else { hideAchievements("BreakEven"); }

                // Win Big //
                winBig = achievements.ReturnWinBig();
                int dayWinBig = achievements.ReturnWinBigDay();
                if (winBig) { showAchievements("WinBig", dayWinBig); }
                else { hideAchievements("WinBig"); }

                // Current Data //
                day = dataManager.GetDay(saveSlot);
                newBalance = dataManager.GetBalance(saveSlot);
                money = newBalance;

                // Settings //
                ticketPrice = dataManager.GetPrice(saveSlot);
                payoutMultiplier = dataManager.GetMultiplier(saveSlot);
                ticketColor = dataManager.GetColor(saveSlot);
                getColor(ticketColor);
                dayType = dataManager.GetNumber(saveSlot);
                updateDayLabels();


                MessageBox.Show("Game Data Restored", "Save Restored");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not available\n\n" + ex, "Save Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnNext.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Visible = false;
            btnBack.Visible = false;

            moneyMade = 0;
            moneySpent = 0;

            clearTickets();
            updateMoneyLabels();
            gameOverCheck();
        }

        // Tickets //
        private void btnNextTicket_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnNext.Visible = false;
            btnBack.Enabled = true;
            btnBack.Visible = true;

            ticketCount++;
            displayTickets();
            gboxYourTicket.Text = "Ticket #" + (ticketCount + 1);

            if (ticketCount + 1 < ticketsBought)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
        }
        private void btnPreviousTicket_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnBack.Enabled = false;
            btnBack.Visible = false;

            ticketCount--;
            displayTickets();
            gboxYourTicket.Text = "Ticket #" + (ticketCount + 1);

            if (ticketCount >= 1)
            {
                btnBack.Enabled = true;
                btnBack.Visible = true;
            }
        }
        private void displayTickets()
        {
            try
            {
                lblTicketNum1.Text = ticketNum[ticketCount, 0].ToString();
                lblTicketNum2.Text = ticketNum[ticketCount, 1].ToString();
                lblTicketNum3.Text = ticketNum[ticketCount, 2].ToString();
                lblTicketNum4.Text = ticketNum[ticketCount, 3].ToString();
                lblTicketNum5.Text = ticketNum[ticketCount, 4].ToString();

                lblTicketNum1.ForeColor = Color.White;
                lblTicketNum2.ForeColor = Color.White;
                lblTicketNum3.ForeColor = Color.White;
                lblTicketNum4.ForeColor = Color.White;
                lblTicketNum5.ForeColor = Color.White;

                if (winningTickets[0] == ticketNum[ticketCount, 0])
                {
                    lblTicketNum1.ForeColor = Color.Lime;
                }
                if (winningTickets[1] == ticketNum[ticketCount, 1])
                {
                    lblTicketNum2.ForeColor = Color.Lime;
                }
                if (winningTickets[2] == ticketNum[ticketCount, 2])
                {
                    lblTicketNum3.ForeColor = Color.Lime;
                }
                if (winningTickets[3] == ticketNum[ticketCount, 3])
                {
                    lblTicketNum4.ForeColor = Color.Lime;
                }
                if (winningTickets[4] == ticketNum[ticketCount, 4])
                {
                    lblTicketNum5.ForeColor = Color.Lime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured\n", "Error Displaying Tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end of displayTickets()
        private void clearTickets()
        {
            lblTicketNum1.ForeColor = Color.Black;
            lblTicketNum2.ForeColor = Color.Black;
            lblTicketNum3.ForeColor = Color.Black;
            lblTicketNum4.ForeColor = Color.Black;
            lblTicketNum5.ForeColor = Color.Black;

            lblTicketNum1.Text = "";
            lblTicketNum2.Text = "";
            lblTicketNum3.Text = "";
            lblTicketNum4.Text = "";
            lblTicketNum5.Text = "";

            lblWinningNum1.Text = "";
            lblWinningNum2.Text = "";
            lblWinningNum3.Text = "";
            lblWinningNum4.Text = "";
            lblWinningNum5.Text = "";
        } // end of clearTickets()


        // Helpers Methods //
        private void hideAchievements(string achievementName)
        {
            if (achievementName == "CashFlow")
            {
                cashFlow = false;
                lblAchievementCashFlowTitle.Enabled = false;
                lblAchievementCashFlowDesc.Enabled = false;
                lblAchievementCashFlowDay.Enabled = false;
                lblAchievementCashFlowDay.Text = "Locked";
                lblAchievementCashFlowTitle.BackColor = Color.LightGray;
                lblAchievementCashFlowDesc.BackColor = Color.LightGray;
                lblAchievementCashFlowDay.BackColor = Color.LightGray;
            }
            if (achievementName == "BreakEven")
            {
                breakEven = false;
                lblAchievementBreakEvenTitle.Enabled = false;
                lblAchievementBreakEvenDesc.Enabled = false;
                lblAchievementBreakEvenDay.Enabled = false;
                lblAchievementBreakEvenDay.Text = "Locked";
                lblAchievementBreakEvenTitle.BackColor = Color.LightGray;
                lblAchievementBreakEvenDesc.BackColor = Color.LightGray;
                lblAchievementBreakEvenDay.BackColor = Color.LightGray;
            }
            if (achievementName == "WinBig")
            {
                winBig = false;
                lblAchievementWinBigDay.Text = "Locked";
                lblAchievementWinBigTitle.BackColor = Color.LightGray;
                lblAchievementWinBigDesc.BackColor = Color.LightGray;
                lblAchievementWinBigDay.BackColor = Color.LightGray;
            }
        } // end of hideeAchievements()
        private void showAchievements(string achievementName, int dayGot)
        {
            if (achievementName == "CashFlow")
            {
                dayText = "Day " + (Numbers)dayGot;
                cashFlow = true;
                lblAchievementCashFlowTitle.Enabled = true;
                lblAchievementCashFlowDesc.Enabled = true;
                lblAchievementCashFlowDay.Enabled = true;
                lblAchievementCashFlowDay.Text = "Achieved on " + dayText.Replace('_', ' ');
                lblAchievementCashFlowTitle.BackColor = Color.Lime;
                lblAchievementCashFlowDesc.BackColor = Color.Lime;
                lblAchievementCashFlowDay.BackColor = Color.Lime;
            }
            if (achievementName == "BreakEven")
            {
                dayText = "Day " + (Numbers)dayGot;
                breakEven = true;
                lblAchievementBreakEvenTitle.Enabled = true;
                lblAchievementBreakEvenDesc.Enabled = true;
                lblAchievementBreakEvenDay.Enabled = true;
                lblAchievementBreakEvenDay.Text = "Achieved on " + dayText.Replace('_', ' ');
                lblAchievementBreakEvenTitle.BackColor = Color.Yellow;
                lblAchievementBreakEvenDesc.BackColor = Color.Yellow;
                lblAchievementBreakEvenDay.BackColor = Color.Yellow;
            }
            if (achievementName == "WinBig")
            {
                dayText = "Day " + (Numbers)dayGot;
                winBig = true;
                lblAchievementWinBigTitle.Enabled = true;
                lblAchievementWinBigDesc.Enabled = true;
                lblAchievementWinBigDay.Enabled = true;
                lblAchievementWinBigDay.Text = "Achieved on " + dayText.Replace('_', ' ');
                lblAchievementWinBigTitle.BackColor = Color.Violet;
                lblAchievementWinBigDesc.BackColor = Color.Violet;
                lblAchievementWinBigDay.BackColor = Color.Violet;
            }
        } // end of showAchievements()

        private void getColor(string ticketColor)
        {
            if (ticketColor == "Red")
            {
                changeColor(Color.Red);
            }
            if (ticketColor == "Orange")
            {
                changeColor(Color.Orange);
            }
            if (ticketColor == "Yellow")
            {
                changeColor(Color.Gold);
            }
            if (ticketColor == "Green")
            {
                changeColor(Color.Lime);
            }
            if (ticketColor == "Blue")
            {
                changeColor(Color.DeepSkyBlue);
            }
            if (ticketColor == "Purple")
            {
                changeColor(Color.Violet);
            }
            if (ticketColor == "Pink")
            {
                changeColor(Color.Pink);
            }
        }
        private void changeColor(Color colorValue)
        {
            gboxWinningNumbers.BackColor = colorValue;
            gboxYourTicket.BackColor = colorValue;
            lblOldBalance.BackColor = colorValue;
            lblMoneySpent.BackColor = colorValue;
            lblMoneyMade.BackColor = colorValue;
            lblNewBalance.BackColor = colorValue;
        } // end of changeColor()

        private void resetValues()
        {
            dayType = "Numbers";
            updateDayLabels();

            lblNewBalanceValue.ForeColor = Color.White;
            ticketColor = "Blue";
            changeColor(Color.DeepSkyBlue);
            nextDayEnabled(true);

            ticketPrice = 5;
            ticketsBought = 0;
            ticketCount = 0;

            moneySpent = 0;
            moneyMade = 0;
            payoutMultiplier = 1;

            numBuyTickets.Maximum = (int)(newBalance / ticketPrice);
            numBuyTickets.Minimum = 1;
            numBuyTickets.Value = 1;

        } // end of resetValues()

        private void updateDayLabels()
        {
            switch(dayType)
            {
                case "Numbers":
                    dayText = "Day " + (Numbers)day;
                    break;
                case "RomanNumerals":
                    dayText = "Day " + (RomanNumerals)day;
                    break;
                case "Binary":
                    dayText = "Day " + (Binary)day;
                    break;
                default:
                    dayText = "Day " + day;
                    break;
            }
            lblDay.Text = dayText.Replace('_', ' ');
        } // end of updateDayLabels()
        private void updateMoneyLabels()
        {
            lblOldBalanceValue.Text = money.ToString("c");
            lblMoneySpentValue.Text = "-" + moneySpent.ToString("c");
            lblMoneyMadeValue.Text = "+" + moneyMade.ToString("c");
            lblNewBalanceValue.Text = newBalance.ToString("c");
            gboxYourTicket.Text = "Ticket #" + ticketCount;
            lblBuyTickets.Text = "Buy Tickets ($" + ticketPrice + " each)";
            if (newBalance < 0)
            {
                lblOldBalanceValue.Text = "-$" + Math.Abs(money) + ".00";
                lblNewBalanceValue.Text = "-$" + Math.Abs(newBalance) + ".00";
            }
        } // end of updateMoneyLabels()
        private void nextDayEnabled(bool value)
        {
            btnStartNextDay.Enabled = value;
            lblBuyTickets.Enabled = value;
            numBuyTickets.Enabled = value;
        } // end of nextDayEnabled()


        // Other Forms //
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmInstructions instructions = new frmInstructions();
            instructions.PayoutMultiplier = payoutMultiplier;
            instructions.ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings difficultySettings = new frmSettings();
            difficultySettings.NewTicketPrice = ticketPrice;
            difficultySettings.MaxTicketPrice = newBalance;
            difficultySettings.TicketColor = ticketColor;
            difficultySettings.PayoutMultiplier = payoutMultiplier;
            difficultySettings.DayType = dayType;

            difficultySettings.ShowDialog();

            // ticket price
            ticketPrice = difficultySettings.NewTicketPrice;

            lblBuyTickets.Text = "Buy Tickets ($" + ticketPrice + " each)";
            if(ticketPrice > 0)
            {
                numBuyTickets.Maximum = (int)(newBalance / ticketPrice);
            }
            if(ticketPrice == 0)
            {
                numBuyTickets.Maximum = 100;
                numBuyTickets.Value = 1;
            }

            if (numBuyTickets.Value > numBuyTickets.Maximum)
            {
                numBuyTickets.Value = numBuyTickets.Maximum;
            }
            if (ticketPrice <= newBalance)
            {
                btnStartNextDay.Enabled = true;
                lblBuyTickets.Enabled = true;
                numBuyTickets.Enabled = true;
            }
            

            // ticket color
            ticketColor = difficultySettings.TicketColor;
            getColor(ticketColor);
            
            // payout multiplier
            payoutMultiplier = difficultySettings.PayoutMultiplier;

            // day type
            dayType = difficultySettings.DayType;
            updateDayLabels();

            // reset achievements
            bool resetAchievements = difficultySettings.ResetAchievements;
            if (resetAchievements)
            {
                hideAchievements("CashFlow");
                hideAchievements("BreakEven");
                hideAchievements("WinBig");

            }

        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveScreen saveScreen = new frmSaveScreen();

            saveScreen.Day = day;
            saveScreen.Balance = newBalance;
            saveScreen.Achievements = achievements;

            saveScreen.Price = ticketPrice;
            saveScreen.Multiplier = payoutMultiplier;
            saveScreen.Colors = ticketColor;
            saveScreen.Number = dayType;

            saveScreen.ShowDialog();

            // check for new game
            if(saveScreen.NewGame == true)
            {
                newGame();
            }

            // check for load save
            if(saveScreen.Save == 1 || saveScreen.Save == 2 || saveScreen.Save == 3) 
            {
                loadSaveGame(saveScreen.Save);
            }
        }
    }
}
