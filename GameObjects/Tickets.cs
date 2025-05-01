using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Tickets
    {
        Random rnd = new Random();
        Rewards reward = new Rewards();
        int[] _winningNumbers = new int[5];

        private bool _winBig;
        public bool WinBig
        {
            get { return _winBig; }
            set { _winBig = value; }
        }

        public int[,] GetTickets(int ticketsBought)
        {
            int[,] _ticketNumbers = new int[ticketsBought,5];
            for (int i = 0; i < ticketsBought; i++)
            {
                _ticketNumbers[i,0] = rnd.Next(1, 10);
                _ticketNumbers[i,1] = rnd.Next(_ticketNumbers[i,0] + 1, 20);
                _ticketNumbers[i,2] = rnd.Next(_ticketNumbers[i,1] + 1, 30);
                _ticketNumbers[i,3] = rnd.Next(_ticketNumbers[i,2] + 1, 40);
                _ticketNumbers[i,4] = rnd.Next(_ticketNumbers[i,3] + 1, 50);
            }
            return _ticketNumbers;
        }

        public int[] GetWinningTickets()
        {
            _winningNumbers[0] = rnd.Next(1, 10);
            _winningNumbers[1] = rnd.Next(_winningNumbers[0] + 1, 20);
            _winningNumbers[2] = rnd.Next(_winningNumbers[1] + 1, 30);
            _winningNumbers[3] = rnd.Next(_winningNumbers[2] + 1, 40);
            _winningNumbers[4] = rnd.Next(_winningNumbers[3] + 1, 50);
            return _winningNumbers;
        }

        public int ScoreTickets(int[,] ticketNum, int ticketsBought)
        {
            int score = 0;
            int reward = 0;
            for (int i = 0; i < ticketsBought; i++)
            {
                score = 0;
                if (_winningNumbers[0] == ticketNum[i, 0])
                {
                    score += 1;
                }
                if (_winningNumbers[1] == ticketNum[i, 1])
                {
                    score += 1;
                }
                if (_winningNumbers[2] == ticketNum[i, 2])
                {
                    score += 1;
                }
                if (_winningNumbers[3] == ticketNum[i, 3])
                {
                    score += 1;
                }
                if (_winningNumbers[4] == ticketNum[i, 4])
                {
                    score += 1;
                }

                if (score == 0)
                {
                    reward += (int)Rewards.Nothing;
                }
                if (score == 1)
                {
                    reward += (int)Rewards.One_Match;
                }
                if (score == 2)
                {
                    reward += (int)Rewards.Two_Match;
                }
                if (score == 3)
                {
                    reward += (int)Rewards.Three_Match;
                }
                if (score == 4)
                {
                    reward += (int)Rewards.Four_Match;
                }
                if (score == 5)
                {
                    reward += (int)Rewards.Five_Match;

                    // unlock achievements
                    _winBig = true;
                }
            }
            return reward;
        } // end of ScoreTickets()


    }
}
