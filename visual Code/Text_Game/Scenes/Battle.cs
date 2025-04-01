using Text_Game.Items;

namespace Text_Game.Scenes
{
    public class Battle : Scene
    {

        public override void Render()
        {
            Game.PrintInfo();
            Console.WriteLine("이상한 남자를 공격 하시겠습니까??");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 공격한다");
            Console.WriteLine("2. 공격하지 않는다.");
            Console.WriteLine("3. 도망간다.");
        }

        public void PlayerPower(Item item)
        {
            Game.Player.Speed += item.speed;
            Game.Player.Power += item.power;
            Game.Player.Defence += item.defence;
            Game.Player.Point -= item.cost;
            Game.inventory.AddItem(item);
        }


        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:

                    Console.WriteLine("이상한 남자를 공격 하여 이상한 남자가 죽었습니다");
                    if (TownScene.count <= 0)
                    {
                        Game.Player.Point += 40;
                        Console.WriteLine("Point를 주웠습니다");

                        TownScene.count++;
                    }
                    else
                    {
                        Next();
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("이상한 남자가 한번 더 공격 합니다.");
                    Game.Player.TakeDamage(20);
                    TownScene.count++;
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
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    Game.Player.TakeDamage(20);
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

