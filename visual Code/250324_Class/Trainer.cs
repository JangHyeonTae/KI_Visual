using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _250324_Class
{
    public class Trainer
    {
        public string name;
        public Monster[] bag = new Monster[6];
        public int bagNum = 0;

        public void Add(Monster monster)
        {
            if (bagNum < 6)
            {
                bag[bagNum] = monster;
                bagNum++;
                Console.WriteLine("{0}를 잡았습니다!", monster.name);

            }
            else
            {
                Console.WriteLine("빈 자리가 없습니다");
                return;
            }


        }

        public void Remove()
        {
            if (bag == null)
            {
                return;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (bag[i] == bag[j])
                    {
                        Console.WriteLine("중복발생.");
                    }
                }
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(" , {0}", bag[i].name);
            }
        }
    }
}
