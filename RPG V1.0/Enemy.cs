using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal abstract class Enemy : Character
    {
        public Enemy(string _name, int _health, int _level, int _attack, int _stamina, int _speed, int _block)
           : base(_name, _health, _level, _attack, _stamina, _speed, _block) { }

        //properties
        public int exp { get;  set; }
        public int gold { get;  set; }

    }
    internal class Fiend : Enemy
    {
        //defualt values
        private const string defaultFiendName = "Fiend";
        private const int defaultFiendHealth = 40;
        private const int defaultFiendLevel = 1;
        private const int defaultFiendAttack = 6;
        private const int defaultFiendStamina = 5;
        private const int defaultFiendSpeed = 5;
        private const int defaultFiendBlock = 10;

        public Fiend() 
            : base(defaultFiendName, defaultFiendHealth, defaultFiendLevel, defaultFiendAttack, 
                  defaultFiendStamina, defaultFiendSpeed, defaultFiendBlock)
        {
            exp = 10;
            gold = 10;
        }

        //Methods

    }

}

//private const int rogueDefaultHealth = 50;
//private const int rogueDefaultLevel = 1;
//private const int rogueDefaultAttack = 12;
//private const int rogueDefaultStamina = 4;
//private const int rogueDefaultSpeed = 6;
//private const int rogueDefaultBlock = 10;