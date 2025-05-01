using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameObjects;

namespace PresentationLayer
{
    public partial class frmSaveScreen : Form
    {
        private bool newGame;
        public bool NewGame
        {
            get { return newGame; }
            set { newGame = value; }
        }
        private int day;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private Achievements achievements;
        public Achievements Achievements
        {
            get { return achievements; }
            set { achievements = value; }
        }

        private int save;
        public int Save
        {
            get { return save; }
            set { save = value; }
        }


        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        private int multiplier;
        public int Multiplier
        {
            get { return multiplier; }
            set { multiplier = value; }
        }


        private string colors;
        public string Colors
        {
            get { return colors; }
            set { colors = value; }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }




        DataManager dataManager = new DataManager();
        public frmSaveScreen()
        {
            InitializeComponent();
        }

        private void frmSaveScreen_Load(object sender, EventArgs e)
        {
            btnSaveSlot1Load.Enabled = true;
            btnSaveSlot2Load.Enabled = true;
            btnSaveSlot3Load.Enabled = true;

            btnSaveSlot1Load.Visible = true;
            btnSaveSlot2Load.Visible = true;
            btnSaveSlot3Load.Visible = true;

            lblSaveSlot1Desc.Text = getSaveSlotDesc(1);
            lblSaveSlot2Desc.Text = getSaveSlotDesc(2);
            lblSaveSlot3Desc.Text = getSaveSlotDesc(3);
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to start a new game?" +
               "\nThis will delete your unsaved progress!", "New Game?", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                newGame = true;
                this.Close();
            }
        }

        private string getSaveSlotDesc(int saveSlot)
        {
            string value = "Empty";
            try
            {
                string dayType = dataManager.GetNumber(saveSlot);
                string dayText = "";
                if (dayType == "Numbers")
                {
                    dayText = (Numbers)(dataManager.GetDay(saveSlot)) + "";
                }
                if (dayType == "Numeric")
                {
                    dayText = (dataManager.GetDay(saveSlot)) + "";
                }
                if (dayType == "RomanNumerals")
                {
                    dayText = (RomanNumerals)(dataManager.GetDay(saveSlot)) + "";
                }
                if (dayType == "Binary")
                {
                    dayText = (Binary)(dataManager.GetDay(saveSlot)) + "";
                }

                value = dataManager.GetBalance(saveSlot).ToString("c") + "\nDay " + dayText;
                value = value.Replace('_', ' ');
            }
            catch (Exception ex)
            {
                value = "Empty";
                if(saveSlot == 1)
                {
                    btnSaveSlot1Load.Enabled = false;
                    btnSaveSlot1Load.Visible = false;
                }
                if(saveSlot == 2)
                {
                    btnSaveSlot2Load.Enabled = false;
                    btnSaveSlot2Load.Visible = false;
                }
                if(saveSlot == 3)
                {
                    btnSaveSlot3Load.Enabled = false;
                    btnSaveSlot3Load.Visible = false;
                }
            }
            return value;
        }

        private void saveGame(int saveSlot)
        {
            DialogResult answer = MessageBox.Show("Overwrite Data?" +
              "\nThis will delete your previous save data!", "Save Game", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    bool result = dataManager.SaveGame(day, balance, saveSlot);
                    bool settings = dataManager.SaveSettings(price, multiplier, colors, number, saveSlot);
                    achievements.SaveAchievementData(saveSlot);
                    if (result && settings) { MessageBox.Show("Game Saved!", "Saved Successfully"); }
                    else { MessageBox.Show("Save Failed", "Save Failed"); }
                }
                catch (Exception ex) { MessageBox.Show("Cannot Save Game\n\n" + ex, "Cannot Save Game", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnSaveSlot1Save_Click(object sender, EventArgs e)
        {
            saveGame(1);
            lblSaveSlot1Desc.Text = getSaveSlotDesc(1);
        }

        private void btnSaveSlot2Save_Click(object sender, EventArgs e)
        {
            saveGame(2);
            lblSaveSlot2Desc.Text = getSaveSlotDesc(2);
        }

        private void btnSaveSlot3Save_Click(object sender, EventArgs e)
        {
            saveGame(3);
            lblSaveSlot3Desc.Text = getSaveSlotDesc(3);
        }

        private void btnSaveSlot1Load_Click(object sender, EventArgs e)
        {
            save = 1;
            this.Close();
        }

        private void btnSaveSlot2Load_Click(object sender, EventArgs e)
        {
            save = 2;
            this.Close();
        }

        private void btnSaveSlot3Load_Click(object sender, EventArgs e)
        {
            save = 3;
            this.Close();
        }
    }
}
