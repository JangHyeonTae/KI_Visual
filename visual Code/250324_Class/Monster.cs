using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250324_Class
{
    public class Monster
    {
        public string name;
        public int level;

        public Monster() { }

        public Monster(string _name, int _level)
        {
            name = _name;
            level = _level;
        }

        public void Print(Monster monster)
        {

            Console.WriteLine("몬스터 이름은 {0}이고 레벨은 {1}입니다!", monster.name, monster.level);
        }
    }
}
