using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal class Rogue : Player
    {
        //Class specific properties
        public int cunning { get; private set; } //private set, as we will just be assigning default to cunning to get player started

        //Default properties
        private const int rogueDefaultHealth = 50;
        private const int rogueDefaultLevel = 1;
        private const int rogueDefaultAttack = 12;
        private const int rogueDefaultStamina = 4;
        private const int rogueDefaultSpeed = 6;
        private const int rogueDefaultBlock = 10;

        public Rogue(string name)
            : base(name, rogueDefaultHealth, rogueDefaultLevel, rogueDefaultAttack,
              rogueDefaultStamina, rogueDefaultSpeed, rogueDefaultBlock)
        {
            cunning = 1;
        }

        //methods

        //List stats
        public virtual void ListStats(Rogue user)
        {
            Console.WriteLine($"{user.name}, you are level {user.level}. Health: {user.health} " +
                $"Attack: {user.attack} Speed: {user.speed} Block: {user.block} Stamina: {user.stamina} " +
                $"Cunning: {user.cunning}");
        }
    }
    
}
