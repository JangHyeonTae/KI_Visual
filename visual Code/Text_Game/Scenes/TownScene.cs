using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Scenes
{
    public class TownScene : Scene
    {
        public static int count = 0;
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("사람들이 북적거리는 마을이다...", ConsoleColor.White,100);
            Util.Print("여러 상인들이 물건을 팔고있다", ConsoleColor.White, 100);
            if (count <= 0)
            {
                Util.Print("멀리서 수상해 보이는 남성이 눈치를 보고있다.", ConsoleColor.Red, 100);
            }
            
        }

        public override void Choice()
        {
            Console.WriteLine("1. 상인에게 간다.");
            Console.WriteLine("2. 일단 파밍이지, 필드로 나간다.");
            if (count <= 0)
            {
                Console.WriteLine("3. 멀리서 수상한 남성을 주시한다.");
            }
        }
        

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("상인에게 접급합니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("필드로 나갑니다 ");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 수상한 남성을 주시하고 있었습니다.");
                    Console.WriteLine("수상한 남성이 당신의 눈빛을 눈치챘습니다");
                    if (Game.Player.Speed >= 15)
                    {
                        Console.WriteLine("당신은 단검을 재빠르게 피했습니다");
                        Console.WriteLine("수상한 남자를 추격합니다");
                    }
                    else if (Game.Player.HP > 0)
                    {
                        Console.WriteLine("단검을 맞았지만 살았습니다");
                    }
                    else
                    {
                        Console.WriteLine("당신은 단검을 피하지 못했습니다");
                        Console.WriteLine("살해당했습니다");
                    }
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
            //ToDo : 다음 씬으로 전환 구현

            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Field");
                    break;
                case ConsoleKey.D3:
                    if (count <= 0)
                    {
                        if (Game.Player.Speed >= 15 || Game.Player.HP >= 0)
                        {
                            Game.ChangeScene("Battle");
                        }
                        else
                        {
                            Game.Player.TakeDamage(20);
                        }
                    }
                    break;

            }
        }
    }
}
