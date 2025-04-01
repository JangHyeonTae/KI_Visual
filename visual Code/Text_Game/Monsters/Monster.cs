using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Game.Items;

namespace Text_Game.Monsters
{
    public class Monster
    {
        public event Action OnMonsterDied;


        public string name;
        public int monsterHp;
        public int power;
        public int cost;

        public Monster()
        {

        }
        public Monster(string _name,int _hp, int _power, int _cose)
        {
            this.name = _name;
            this.monsterHp = _hp;
            this.power = _power;
            this.cost = _cose;
        }

        
        public void TakeDamage(int damage)
        {
            monsterHp -= damage;
            Console.WriteLine($"{name}한테 {Game.Player.Power}만큼 데미지를 줬습니다");
            if (monsterHp <= 0)
            {
                Console.WriteLine($"{name}몬스터가 죽었습니다 {cost}만큼 Point를 벌었습니다");
                Game.Player.Point += cost;
            }
        }

    }
}
