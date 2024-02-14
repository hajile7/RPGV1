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
        public int health { get; set; }
        public int level { get; set; }
        public int attack { get; set; }
        public int stamina { get; set; }

        public int speed { get; set; }
        public int block { get; set; }

        //constructor
        public Character(string _name, int _health, int _level, int _attack, int _stamina, int _speed, int _block)
        {
            name = _name;
            health = _health;
            level = _level;
            attack = _attack;
            stamina = _stamina;
            speed = _speed;
            block = _block;
        }

        //Methods
        

    }


}
