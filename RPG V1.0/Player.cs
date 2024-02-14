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

    }

}
