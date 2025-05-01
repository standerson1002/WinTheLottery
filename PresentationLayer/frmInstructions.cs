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
    public partial class frmInstructions : Form
    {
        public int PayoutMultiplier
        {
            get { return payoutMultiplier; }
            set { payoutMultiplier = value; }
        }
        private int payoutMultiplier;


        public frmInstructions()
        {
            InitializeComponent();
        }

        private void frmInstructions_Load(object sender, EventArgs e)
        {
            lblScoring.Text = "No Matches: $0\nOne Match: " + ((int)Rewards.One_Match * payoutMultiplier).ToString("c") +
                               "\nTwo Matches: " + ((int)Rewards.Two_Match * payoutMultiplier).ToString("c") +
                               "\nThree Matches: " + ((int)Rewards.Three_Match * payoutMultiplier).ToString("c") +
                               "\nFour Matches: " + ((int)Rewards.Four_Match * payoutMultiplier).ToString("c") +
                               "\nFive Matches: " + ((int)Rewards.Five_Match * payoutMultiplier).ToString("c");
        }
    }
}
