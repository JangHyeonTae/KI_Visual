namespace Class
{
    internal class Program
    {
        public class Monster
        {
            public string name;
            public int hp;
            public int level;

            //생성자
            public Monster()
            {
                name = "몬스터";
                hp = 100;
                level = 1;
            }

            ////매개변수 가능
            //public Monster(string _name/*, int _hp, int _level*/)
            //{
            //    name = _name;
            //    //hp = _hp;
            //    //level = _level;
            //    switch (name)
            //    {
            //        case "슬라임":
            //            hp = 30;
            //            level = 3;
            //            break;
            //        case "드래곤":
            //            hp = 1000;
            //            level = 1;
            //            break;
            //        case "오크":
            //            hp = 50;
            //            level = 10;
            //            break;
            //    }
            //}

        }

        static void Main(string[] args)
        {
            Monster monster = new Monster();
            monster.name = "드래곤";
            monster.hp = 1000;

            Console.Write("{0}, {1}",monster.name,monster.hp);
        }
    }
}
