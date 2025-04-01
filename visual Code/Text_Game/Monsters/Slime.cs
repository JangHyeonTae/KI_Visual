using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Monsters
{
    public class Slime : Monster
    {
        public Slime() //:base ("슬라임", 1, 1,10)
        {
            name = "슬라임";
            monsterHp = 1;
            power = 1;
            cost = 10;
        }
    }
}
