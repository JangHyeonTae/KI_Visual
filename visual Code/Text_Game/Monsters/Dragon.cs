using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Text_Game.Monsters
{
    public class Dragon : Monster
    {
        public Dragon() //: base("드래곤", 100, 50, 10000)
        {
            name = "드래곤";
            monsterHp = 100;
            power = 50;
            cost = 10000;
        }


    }
}
