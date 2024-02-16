using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal class Attacks
    {
        public string name { get; set; }
        public int damageMod { get; set; }
        public double critMod { get; set; }
        public int resourceUse { get; set; }

        public Attacks(string _name, int _damageMod, double _critMod, int _resourceUse)
        {
            name = _name;
            damageMod = _damageMod;
            critMod = _critMod;
            resourceUse = _resourceUse;
        }

        public void Attack(Character attacker, Character defender)
        {
            Random critEvent = new Random();

            int damageDealt = attacker.attack * damageMod;
            double critChance = attacker.crit + critMod;

            Console.WriteLine($"{attacker.name} used {name} on {defender.name}");

            if (critChance >= critEvent.NextDouble())
            {
                damageDealt *= 2;
            }

            defender.health -= damageDealt;
            attacker.resource -= resourceUse;


            Console.WriteLine($"{defender.name} took {damageDealt} damage!");

            if (defender.health <= 0)
            {
                Console.WriteLine($"{defender.name} has DIED!");
                defender.isDead = true;
            }
            else
            {
                Console.WriteLine($"{defender.name} has {defender.health} health left!");
            }
        }
    }
}
