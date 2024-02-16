using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal abstract class Character
    {
        //properties (do these need getters and setters?)
        public string name { get; set; }
        public int maxHealth { get; set; }
        public int health { get; set; }
        public int level { get; set; }
        public int attack { get; set; }
        public double crit { get; set; }
        public int resource { get; set; }
        public int speed { get; set; }
        public int block { get; set; }
        public int gold { get; set; }
        public bool isDead { get; set; }

        //constructor
        public Character(string _name, int _maxHealth, int _health, int _level, int _attack, double _crit, int _resource, int _speed, int _block, int _gold, bool _isDead)
        {
            name = _name;
            maxHealth = _maxHealth;
            health = _health;
            level = _level;
            attack = _attack;
            crit = _crit;
            resource = _resource;
            speed = _speed;
            block = _block;
            gold = _gold;
            isDead = _isDead;
        }

        //Methods
        

    }


}
