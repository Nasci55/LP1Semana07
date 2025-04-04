using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        public string Name { get; }

        public int XP
        {
            set
            {
                if (value > xp)
                {
                    xp = value;
                }
            }
        }
    }
}