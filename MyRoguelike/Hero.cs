using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace MyRoguelike
{
    public class Hero
    {
        private int _xp;
        private float _health;
        public string Name { get; }

        public int XP
        {
            get
            {
                return _xp;
            }

            set
            {
                if (value > _xp)
                {
                    _xp = value;
                }
            }
        }

        public int Level
        {
            get
            {
                return 1 + XP / 1000;
            }
        }

        public float Health
        {
            get
            {

            }
        }
    }
}