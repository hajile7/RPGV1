using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal class Enemy : Character
    {
        //Properties
        public int gold { get; set; }

        //Constructor
        public Enemy(string _name, int _maxHealth, int _health, int _level, int _attack, double _crit, int _stamina, int _speed, int _block, int _gold)
           : base(_name, _maxHealth, _health, _level, _attack, _crit, _stamina, _speed, _block) 
        {
            gold = _gold;
        }

        //Methods





        //Static Methods


        //Static Method to create new Enemy Object
        public static Enemy createEnemy(int level)
        {
            //Base Stat Values for enemies
            int baseHealth = 10;
            int baseDamage = 2;
            double baseCrit = 0;
            int baseStamina = 10;
            int baseSpeed = 3;
            int baseBlock = 0;
            int baseDrop = 5;


            //Arithmetic to create scaling values as the levels increase

            //Scaling Health formula
            int health = (int)Math.Round((baseHealth + (-Math.Pow(((level - 100) / 5.34522483824848), 2) + 350)));

            //Scaling damage formula
            int damage = (int)Math.Round((baseDamage + (-Math.Pow(((level - 100) / 14.14213562373095), 2) + 50)));

            //TBD
            int stamina = baseStamina;

            int speed = baseSpeed;

            int block = baseBlock;

            //Scaling crit formula
            //Capped crits at 35%
            double crit = baseCrit + (level * 1.5 / 100);
            if (crit > 0.35)
            {
                crit = 0.35;
            }


            //Basic Scaling for gold drops
            int dropAmm = baseDrop + (level * 2);


            //Create our enemy object
            Enemy enemy = new Enemy(createEnemyName(level), health, health, level, damage, crit, stamina, speed, block, dropAmm);


            //return our enemy object
            return enemy;
        }




        //Static Method used to create enemy names
        public static string createEnemyName(int level)
        {
            //Create new random object for randomly choosing names
            Random ran = new Random();

            //Create a couple arrays of names for each tier of enemy difficulty
            string[] enemyT1 = { "Goblin", "Giant Rat", "Bee Hive", "Giant Centipede", "Boa Constrictor", "Street Urchin", "Rabid Dog" };
            string[] enemyT2 = { "Bandit", "Gnarled Bear", "Aged Mage", "Ruffian", "Giant Alligator", "Thirsty Vampire Spider", "Porgon" };
            string[] enemyT3 = { "Strange Penguin", "Queen Bee", "Troll", "Great Knight", "Terrestrial Whale" };

            //Possibly redundant, saved for later use
            //string[] bosses = { "Gilded Knight", "Lone Mercenary", "Frenzied Beast", "Roland the First" };


            //initialize enemy name string, possibly undeeded
            string enemyName = "";

            //Conditionals to only select certain enemies for certain difficulty levels
            if (level < 10)
            {
                //Basic logic used in every conditional, choose index at a random number from 0 - length of the array
                enemyName = enemyT1[ran.Next(enemyT1.Length)];

                //return that name back
                return enemyName;
            }
            else if (level < 30)
            {
                //Random call used throughout the rest of these conditionals
                //Chooses if enemy is fewer stronger enemies or more weaker enemies
                if (ran.Next(0, 2) == 0)
                {
                    enemyName = "Three " + enemyT1[ran.Next(enemyT1.Length)] + "s";
                    return enemyName;
                }
                else
                {
                    enemyName = enemyT2[ran.Next(enemyT2.Length)];
                    return enemyName;
                }
            }
            else if (level < 60)
            {
                int enemyTier = ran.Next(0, 3);
                if (enemyTier == 0)
                {
                    enemyName = "Five " + enemyT1[ran.Next(enemyT1.Length)] + "s";
                    return enemyName;
                }
                else if ((enemyTier == 1))
                {
                    enemyName = "Two " + enemyT2[ran.Next(enemyT2.Length)] + "s";
                    return enemyName;
                }
                else
                {
                    enemyName = enemyT3[ran.Next(enemyT3.Length)];
                    return enemyName;
                }
            }
            else
            {
                int enemyTier = ran.Next(0, 3);
                if (enemyTier == 0)
                {
                    enemyName = "Seven " + enemyT1[ran.Next(enemyT1.Length)] + "s";
                    return enemyName;
                }
                else if ((enemyTier == 1))
                {
                    enemyName = "Four " + enemyT2[ran.Next(enemyT2.Length)] + "s";
                    return enemyName;
                }
                else
                {
                    enemyName = enemyT3[ran.Next(enemyT3.Length)] + " and Two " + enemyT2[ran.Next(enemyT2.Length)] + "s";
                    return enemyName;
                }
            }
        }

    }
}