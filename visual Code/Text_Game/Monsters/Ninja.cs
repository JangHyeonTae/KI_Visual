using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Monsters
{
    public class Ninja : Monster
    {
        public Ninja() //: base("닌자",15,6,30)
        {
            name = "닌자";
            monsterHp = 15;
            power = 6;
            cost = 30;
        }


    }
}
