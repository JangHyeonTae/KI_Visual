using System.Xml;
using static _16._Game_interface.Program;

namespace _16._Game_interface
{
    internal class Program
    {
        //NPC와 대화하다
        //상자에서 아이템을 습득
        //문에서 이동

        //+ 상점 npc 상점열기

        public interface IInteracable
        {
            public void Interaction();
        }

        public interface IStoreble
        {
            public void OpenStore();
        }

        public class NPC : IInteracable//, IStoreble
        {
            public virtual void Interaction()
            {
                Console.WriteLine("NPC와 상호작용합니다");
            }
            //public void OpenStore()
            //{
            //    Console.WriteLine("상인과 상호작용하여 상점을 엽니다");
            //}

        }

        public class StoreNPC : NPC
        {
            public override void Interaction()
            {
                base.Interaction();
                Console.WriteLine("상점을 엽니다");
            }
        }

        public class Chest : IInteracable
        {
            public void Interaction()
            {
                Console.WriteLine("상자와 상호작용 합니다");
                box();
            }

            public void box()
            {
                Console.WriteLine("아이템을 획득합니다");
            }
        }

        public class Door : IInteracable
        {
            public void Interaction()
            {
                Console.WriteLine("문과 상호작용 합니다");
                Enter();
            }

            public void Enter()
            {
                Console.WriteLine("이동합니다");
            }
        }

       

        public class Player
        {
            public void Interaction(IInteracable interaction)
            {
                interaction.Interaction();
            }
            
            public void OpenStore(IStoreble store)
            {
                store.OpenStore();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. NPC  2. 상자  3. 문  4.상점NPC");
            Player player = new Player();

            NPC npc = new NPC();
            Chest chest = new Chest();
            Door door = new Door();
            StoreNPC storeNPC = new StoreNPC();

            string press = Console.ReadLine();
            int pressNum;
            int.TryParse(press, out pressNum);

            switch(pressNum)
            {
                case 1:
                    player.Interaction(npc);
                    break;
                case 2:
                    player.Interaction(chest);
                    break;
                case 3:
                    player.Interaction(door);
                    break;
                case 4:
                    //player.OpenStore(npc);
                    player.Interaction(storeNPC);
                    break;     
            }
            
        }
    }
}
