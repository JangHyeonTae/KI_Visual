using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Game.Items;
using Text_Game.Monsters;

namespace Text_Game
{
    public class Player
    {

        public event Action OnDied;

        private int hp = 20;
        public int HP { get { return hp; } set { hp = value; } }

        private int power;
        public int Power { get { return power; } set { power = value; } }

        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }

        private int defence;
        public int Defence { get { return defence; } set { defence = value; } }

        private int point;
        public int Point { get { return point; } set { point = value; } }

        public int TakeDamage(int damage)
        {
            int elseDamage = 0;

            while (elseDamage <= 0)
            {
                if (defence > 0)
                {
                    elseDamage = defence - damage;
                    defence = 0;
                }
                else
                {
                    hp -= (damage + elseDamage);
                    Die();
                }
            }

            return hp;
        }

        public void Die()
        {
            if (hp <= 0)
            {
                Game.GameOver("다시 해보세용");
            }
        }

        public void Attack(Monster monster)
        {
            monster.TakeDamage(power);
        }
        
    }
}
