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
                _xp += value;
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
                return _health;
            }
            set
            {
                if (value > 0 && value < MaxHealth)
                {
                    _health = value;
                }
                else if (value <= 0)
                {
                    _health = 0;
                }
                else if (value >= MaxHealth)
                {
                    _health = MaxHealth;

                }
            }
        }

        public float MaxHealth
        {
            get
            {
                return 100 + (Level - 1) * 20;
            }
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;

            XP = (int)damage / 20;

        }

        public Hero(string name)
        {
            Name = name;
            _xp = 0;
            Health = MaxHealth;
        }
    }
}