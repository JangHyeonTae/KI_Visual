using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Scenes
{
    public class TitleScene : Scene
    {
        
        public override void Render()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("*         Legend RPG           *");
            Console.WriteLine("********************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료");
        }

        public override void Wait(){ }
        public override void Next()
        {
            //ToDo : 다음 씬으로 전환 구현
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
    
}
