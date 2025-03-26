namespace _12._static
{
    internal class Program
    {
        class Monster
        {
            public static int hp = 100;

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine(hp);
            }
        }

        static void Main(string[] args)
        {
            Monster monster = new Monster();
            Monster monster2 = new Monster();
            monster.TakeHit(10);
            monster2.TakeHit(10);
        }
    }
}
