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
                if (_health > MaxHealth)
                {
                    return MaxHealth;
                }
                if (_health < 0)
                {
                    return 0;
                }

                return _health;
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

        public Hero()
        {

        }
    }
}