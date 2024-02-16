using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V1._0
{
    internal abstract class Player : Character
    {
        public List<Item> items;
        public Player(string _name, int _maxHealth, int _health, int _level, int _attack, int _crit, int _resource, int _speed, int _block, int _gold, bool _isDead List<Item> _items)
            : base(_name, _maxHealth, _health, _level, _attack, _crit, _resource, _speed, _block, _gold, _isDead) 
        {
            items = _items;
        }
 
        //Methods

    }

}
