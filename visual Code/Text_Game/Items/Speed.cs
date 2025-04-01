using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Items
{
    public class Speed : Item
    {
        public Speed() :base("신발",0,2,4,30)
        {
            name = "신발";
            power = 0;
            defence = 2;
            speed = 4;
            cost = 30;
        }
    }
}
