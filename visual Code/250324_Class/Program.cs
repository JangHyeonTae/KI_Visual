using System.Collections.Concurrent;

namespace _250324_Class
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            Monster monster = new Monster();
            Console.Write("이름을 입력하세요 : ");
            trainer.name = Console.ReadLine();
            Console.Clear();

            Monster slime = new Monster("slime", 3);
            Monster dragon = new Monster("dragon", 10);
            Monster monkey = new Monster("monkey", 4);
            Monster oak = new Monster("oak", 5);
            Monster bird = new Monster("bird", 7);
            Monster bug = new Monster("bug", 9);
            Monster bear = new Monster("bear", 12);

            monster.Print(slime);
            monster.Print(dragon);
            monster.Print(monkey);
            monster.Print(oak);
            monster.Print(bird);
            monster.Print(bug);
            monster.Print(bear);

            
            //while (trainer.bagNum <6)
            //{
            //    Console.Write("몬스터의 정보를 입력하시오 : ");
            //    string monsterStr = Console.ReadLine();
            //    string monsterLevel = Console.ReadLine();
            //    int monsterNum;
            //    int.TryParse(monsterStr, out monsterNum);
            //
            //    monster = new Monster(monsterStr, monsterNum);
            //    trainer.Add(monster);
            //    trainer.Remove();
            //}

            trainer.Add(slime);
            trainer.Add(dragon);
            trainer.Add(monkey);
            trainer.Add(monkey);
            trainer.Add(oak);
            trainer.Add(bird);
            trainer.Add(bug);
            trainer.Add(bear);

            Console.Write("내 포켓몬은");
            trainer.PrintAll();
            Console.WriteLine("입니다!");
        }
    }
}
