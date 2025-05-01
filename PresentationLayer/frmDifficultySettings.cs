using GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmSettings : Form
    {
        public int NewTicketPrice
        {
            get { return newTicketPrice; }
            set { newTicketPrice = value; }
        }
        private int newTicketPrice = 5;
        public int MaxTicketPrice
        {
            get { return maxTicketPrice; }
            set { maxTicketPrice = value; }
        }
        private int maxTicketPrice = 5;
        public string TicketColor
        {
            get { return ticketColor; }
            set { ticketColor = value; }
        }
        private string ticketColor;
        public int PayoutMultiplier
        {
            get { return payoutMultiplier; }
            set { payoutMultiplier = value; }
        }
        private int payoutMultiplier;
        public string DayType
        {
            get { return dayType; }
            set { dayType = value; }
        }
        private string dayType;


        public bool ResetAchievements
        {
            get { return resetAchievements; }
            set { resetAchievements = value; }
        }
        private bool resetAchievements = false;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmDifficultySettings_Load(object sender, EventArgs e)
        {
            // assign values
            comTicketColor.Text = ticketColor;
            comDayType.Text = dayType;
            numPayoutMultiplier.Value = payoutMultiplier;
            numChangePrice.Value = newTicketPrice;
            getMaxPrice();
            
        }


        private void getMaxPrice()
        {
            numChangePrice.Minimum = 0;
            numChangePrice.Maximum = maxTicketPrice;

            if (newTicketPrice < 0)
            {
                newTicketPrice = 0;
                numChangePrice.Value = newTicketPrice;
                numChangePrice.Maximum = 0;

            }

        }

        // Reset //
        private void btnResetAchievements_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to reset your achievements?\nThis means they will all be gone!", "Verify Reset", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                MessageBox.Show("Achievements Reset!", "Reset Verified", MessageBoxButtons.OK);
                resetAchievements = true;
            }
            else
            {
                resetAchievements = false;
            }
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ticketColor = "Blue";
            comTicketColor.Text = ticketColor;
            dayType = "Numbers";
            comDayType.Text = dayType;
            payoutMultiplier = 1;
            numPayoutMultiplier.Value = payoutMultiplier;
            // check if price is affordable
            if (newTicketPrice > maxTicketPrice)
            {
                MessageBox.Show("You can't afford this price!", "Invalid Ticket Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newTicketPrice = maxTicketPrice;
            }
            else
            {
                MessageBox.Show("Values Reset to Defualt.", "Values Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numChangePrice.Value = 5;
                newTicketPrice = 5;
                this.Close();
            }

        }

        // Apply //
        private void btnApply_Click(object sender, EventArgs e)
        {
            ticketColor = comTicketColor.Text;
            dayType = comDayType.Text;
            payoutMultiplier = (int)numPayoutMultiplier.Value;
            newTicketPrice = (int)numChangePrice.Value;
            getMaxPrice();
            MessageBox.Show("Values Updated.", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
