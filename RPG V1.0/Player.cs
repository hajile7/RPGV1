using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal abstract class Player : Character
    {
        public Player(string _name, int _health, int _level, int _attack, int _stamina, int _speed, int _block)
            : base(_name, _health, _level, _attack, _stamina, _speed, _block) { }
 

        //Methods
        //Battle Victory
        public void Victory(Enemy enemy)
        {
            Console.WriteLine($"Congratulations! You defeated the {enemy}. EXP +{enemy.exp}." +
                $" Gold +{enemy.gold}.\nYou now have (PLACEHOLDER FOR EXPERIENCE)");
        }

    }


    internal class Rogue : Player
    {
        //Class specific properties
        public int cunning {  get; private set; } //private set, as we will just be assigning default to cunning to get player started

        //Default properties
        private const int rogueDefaultHealth = 50;
        private const int rogueDefaultLevel= 1;
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
        //level up
        //attack
        public void DefaultAttack(Rogue user, Enemy enemy)
        {
            int defaultDamage = 5;
            Console.WriteLine($"{user.name} attacked the {enemy.name} for {defaultDamage} damage!");
            enemy.health -= defaultDamage;
            Console.WriteLine($"The {enemy.name} now has {enemy.health} health remaining.");
        }

        //List stats
        public virtual void ListStats(Rogue user)
        {
            Console.WriteLine($"{user.name}, you are level {user.level}. Health: {user.health} " +
                $"Attack: {user.attack} Speed: {user.speed} Block: {user.block} Stamina: {user.stamina} " +
                $"Cunning: {user.cunning}");
        }
    }

}
