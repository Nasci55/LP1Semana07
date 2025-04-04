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
                return _health;
            }
            set
            {
                if (_health > MaxHealth)
                {
                    _health = MaxHealth;
                }
                if (_health < 0)
                {
                    _health = 0;
                }
                _health = value;

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
            _health = Health - damage;

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