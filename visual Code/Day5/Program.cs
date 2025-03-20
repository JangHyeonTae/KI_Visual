namespace Day5
{
    internal class Program
    {
        #region 스킬구조체
        //struct Skill
        //{
        //    public string name;
        //    public float coolTime;
        //    public int cost;
        //    public float range;
        //}
        #endregion

        struct Item
        {
            public string name;
            public int itemID;
        }

        //struct Inventory
        //{
        //    public Item[] itemArr;
        //}
        static void Main(string[] args)
        {
            #region
            //arr.Replace('a', 'x'); //바꾸기
            //arr.Split(' '); //나누기

            //첫번째 문자 대문자로 바꾸기
            //string text = "abcde";
            //char[] array = text.ToCharArray();
            //
            //array[0] = char.ToUpper(array[0]);
            //
            //text = new string(array);
            //Console.WriteLine(text);
            #endregion
            #region 스킬
            //    Skill fireball;
            //    fireball.name = "파이어볼";
            //    fireball.coolTime = 2.5f;
            //    fireball.cost = 10;
            //    fireball.range = 3.5f;
            //
            //    Skill smash;
            //    smash.name = "강타";
            //    smash.coolTime = 10f;
            //    smash.cost = 3;
            //    smash.range = 20f;
            //
            //    Skill roll;
            //    roll.name = "눈굴리기";
            //    roll.coolTime = 4.2f;
            //    roll.cost = 10;
            //    roll.range = 5f;
            //
            //    Skill run;
            //    run.name = "속도증가";
            //    run.coolTime = 50f;
            //    run.cost = 50;
            //    run.range = 0f;
            //
            //    Skill[] skills = new Skill[4];
            //
            //    skills[0] = fireball;
            //    skills[1] = smash;
            //    skills[2] = roll;
            //    skills[3] = run;
            //
            //
            //    while (true)
            //    {
            //        Console.WriteLine("사용할 스킬 : ");
            //        string input = Console.ReadLine();
            //        int value = int.Parse(input);
            //
            //        Console.WriteLine($"{skills[value].name}을 사용합니다.");
            //        Console.WriteLine($"마나가 {skills[value].cost}만금 감소합니다");
            //        Console.WriteLine($"쿨타임 {skills[value].coolTime}을 적용합니다");
            //        Console.WriteLine($"범위 {skills[value].range}를 확인합니다.");
            //        Console.WriteLine();
            //    }
            #endregion
            ItemFunc();
        }


        static void ItemFunc()
        {
            Item[] inventory = new Item[4];

            Item water;
            water.name = "물";
            water.itemID = 1;

            Item gun;
            gun.name = "총";
            gun.itemID = 2;

            Item cap;
            cap.name = "모자";
            cap.itemID = 3;

            Item book;
            book.name = "책";
            book.itemID = 4;

            inventory[0] = water;
            inventory[1] = gun;
            inventory[2] = cap;
            inventory[3] = book;


            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine($"{inventory[i].name}의 아이템 아이디는 {inventory[i].itemID}입니다.");

            }
        }

    }
}

