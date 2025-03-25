namespace ClassPosition
{
    //클래스 심화
    internal class Program
    {


        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            player.Attack(monster);
        }
    }
}
