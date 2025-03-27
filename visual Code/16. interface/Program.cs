namespace _16._interface
{
    internal class Program
    {
        public interface IEnterable
        {
            public void Enter();
        }

        public interface IOpenable
        {
            public void Open();
        }

        public class Dungeon : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("던전에 들어갑니다");
            }
        }

        public class Chest : IOpenable
        {
            public void Open()
            {
                Console.WriteLine("상자를 엽니다.");
            }
        }

        public class Door : IEnterable, IOpenable
        {
            public void Enter()
            {
                Console.WriteLine("문에 들어갑니다");
            }

            public void Open()
            {
                Console.WriteLine("문을 엽니다");
            }
        }
        public class Player
        {
            public void Enter(IEnterable enterable)
            {
                enterable.Enter();
            }

            public void Open(IOpenable openable)
            {
                openable.Open();
            }

        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Dungeon dungeon = new Dungeon();
            Chest chest = new Chest();

            player.Enter(dungeon);
            player.Open(chest);

            Door door = new Door();
            player.Enter(door);
            player.Open(door);
        }
    }
}
