using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Items
{

    public class Item
    {
        public string name;
        public int power;
        public int defence;
        public int speed;
        public int cost;

        public Item()
        {

        }
        public Item(string _name, int _power, int _defence, int _speed, int _cost)
        {
            name = _name;
            power = _power;
            defence = _defence;
            speed = _speed;
            cost = _cost;
        }
    }
}
