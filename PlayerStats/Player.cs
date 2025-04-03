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
            get => WinRate;

            set
            {
                value = wonGames/playedGames;

            }

        }

    }
}