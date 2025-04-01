using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Items
{
    public class Bead : Item
    {
        
        Random rand = new Random();
        public Bead()
        {
            name = "구슬";
            power = rand.Next(0,5) - rand.Next(0,5);
            defence = rand.Next(0, 5) - rand.Next(0, 5);
            speed = rand.Next(0, 5) - rand.Next(0, 5);
            cost = 50;
        }
    }
}
