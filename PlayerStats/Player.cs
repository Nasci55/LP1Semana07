using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames, wonGames;
        public string Name { get; }


        public float HighScore
        {
            get => highScore;
            set
            {
                if (value < highScore)
                {
                    highScore = value;
                }
            }
        }

        public float WinRate
        {
            get
            {
                float winRate;
                if (playedGames > 0)
                {
                    winRate = (float)wonGames / playedGames;
                }
                else
                {
                    winRate = 0;
                }

                return winRate;
            }

        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
            {
                wonGames++;
            }
        }

        public Player(string name)
        {

        }


    }
}