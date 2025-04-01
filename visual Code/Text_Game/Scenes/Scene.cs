using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game.Scenes
{
    public abstract class Scene
    {
        protected ConsoleKey input;
        
        public abstract void Render();
        public abstract void Choice();
        public abstract void Result();
        public abstract void Wait();
        public abstract void Next();

        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
    }
}
