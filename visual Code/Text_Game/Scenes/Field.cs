using Text_Game.Monsters;

namespace Text_Game.Scenes
{
    public class Field : Scene
    {

        Dragon dragon = new();
        public override void Render()
        {
            Game.PrintInfo();
            Console.WriteLine("몬스터가 있습니다!! 누구인지 자세히 보이지 않는데 공격 하시겠습니까?");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 공격한다");
            Console.WriteLine("2. 공격하지 않는다.");
            Console.WriteLine("3. 도망간다.");
        }

        public override void Result()
        {
            Console.Clear();
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine($"{dragon.name}을 공격 하였습니다");
                    Game.Player.Attack(dragon);
                    Console.WriteLine($"{Game.Player.Power}만큼 데미지를 입혔습니다");
                    Console.WriteLine($"{dragon.name}이 {dragon.power}만큼 공격하였습니다");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("자세히보니 {0}이였습니다!", dragon.name);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마을로 돌아갑니다");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌려주세요...");
            Console.ReadKey();
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.TakeDamage(dragon.power);
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Town");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다");
                    break;
            }
        }
    }

}


