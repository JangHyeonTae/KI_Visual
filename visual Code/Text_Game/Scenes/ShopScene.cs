using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Game.Items;

namespace Text_Game.Scenes
{
    public class ShopScene : Scene
    {
        
        Item item = new();
        Speed speed = new Speed(); 
        Bead bead = new Bead();
        Defence defence = new();
        Power power = new();

        public override void Render()
        {
            Game.PrintInfo();
            Console.WriteLine("\"어서오세요\"");
            Console.WriteLine("어떤 물건을 구매하시겠습니까?");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 누가봐도 수상한 저주받은 것 같은 구슬을 산다.");
            Console.WriteLine("2. 상인에게 신발을 구매한다.");
            Console.WriteLine("3. 상인에게 검을 구매한다.");
            Console.WriteLine("4. 상인에게 갑옷을 구매한다.");
            Console.WriteLine("5. 상인을 위협하고 돈을 갈취 시도한다");
            Console.WriteLine("6. 마을로 돌아갑니다.");
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
                    Console.WriteLine("구슬을 사서 애매하게 능력치가 변경됐다.");
                    PlayerPower(bead);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("신발을 구매해서 민첩성이 올랐습니다");
                    PlayerPower(speed);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("검을 구매해서 힘이 올랐습니다");
                    PlayerPower(speed);
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("갑옷을 구매해서 방아력이 올랐습니다");
                    PlayerPower(speed);
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("당신은 상인을 위협하고 돈 달라고 소리쳤습니다");
                    Console.WriteLine("당신은 상인이 때린 주먹에 뻗었습니다");
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("마을로 돌아갑니다.");
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
                case ConsoleKey.D5:
                    Game.Player.TakeDamage(30);
                    break;
                case ConsoleKey.D6:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
