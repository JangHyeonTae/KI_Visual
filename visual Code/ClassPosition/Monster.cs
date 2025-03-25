using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPosition
{
    internal class Monster
    {
        public int hp = 100;

        public void TakeHit(int damage)
        {
            hp -=damage;
        }
    }
}
