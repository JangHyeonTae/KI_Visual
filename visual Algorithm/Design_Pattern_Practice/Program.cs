using System.Security.Cryptography.X509Certificates;

namespace Design_Pattern_Practice
{
    internal class Program
    {
        #region WeaponFactory
        //public enum Grade
        //{
        //    normal,
        //    epic,
        //    legend
        //};
        //
        //static void Main(string[] args)
        //{
        //    WeaponFactory weapon = new WeaponFactory();
        //    Weapon weapon1 = weapon.Create("철검");
        //    Weapon weapon2 = weapon.Create("철검", Grade.epic);
        //    Weapon weapon3 = weapon.Create("쇠도끼", Grade.legend);
        //
        //    Console.WriteLine($"{weapon1.name} : {weapon1.Power} : {weapon1.range}");
        //    Console.WriteLine($"{weapon2.name} : {weapon2.Power} : {weapon2.range}");
        //    Console.WriteLine($"{weapon3.name} : {weapon3.Power} : {weapon3.range}");
        //}
        //
        //public class WeaponFactory
        //{
        //    public Weapon Create(string name)
        //    {
        //        Weapon weapon;
        //        switch (name)
        //        {
        //            case "철검":
        //                return weapon = new Weapon("철검", 10, 10);
        //            case "나무창":  
        //                return weapon = new Weapon("나무창", 5, 15);
        //            case "쇠도끼":
        //                return weapon = new Weapon("쇠도끼", 15, 5);
        //            default:
        //                return null;
        //        }
        //    }
        //    public Weapon Create(string name, Grade grade)
        //    {
        //        Weapon weapon = Create(name);
        //        if (grade == Grade.epic)
        //        {
        //            weapon.Power = (int)(weapon.Power * 1.1f);
        //        }
        //        else if (grade == Grade.legend)
        //        {
        //            weapon.Power = (int)(weapon.Power * 1.2f);
        //        }
        //        else
        //        {
        //            weapon.Power = (int)weapon.Power;
        //        }
        //        return weapon;
        //    }
        //}
        //
        //
        //public class Weapon
        //{
        //    public string name;
        //    private int power;
        //    public int Power { get { return power; } set { power = value; } }
        //    public float range;
        //
        //    public Weapon(string name, int power, float range)
        //    {
        //        this.name = name;
        //        this.power = power;
        //        this.range = range;
        //    }
        //}
        #endregion


        public enum Grade
        {
            normal,
            epic
        };

        public static void Main(string[] args)
        {
            Grade grade;
            AnimalBuilder sheepBuilder = new AnimalBuilder();
            AnimalBuilder cowBuilder = new AnimalBuilder();
            AnimalBuilder chickenBuilder = new AnimalBuilder();

            chickenBuilder.grade = Grade.epic;

            sheepBuilder
                .SetName("양")
                .SetMake("털")
                .SetCry("매애앵")
                .SetEat("풀");

            cowBuilder
                .SetName("소")
                .SetMake("우유")
                .SetCry("음매애애")
                .SetEat("풀");

            if (chickenBuilder.grade == Grade.epic)
            {
                chickenBuilder
                .SetName("닭")
                .SetMake("후라이드 치킨")
                .SetCry("꼬꼬댁")
                .SetEat("모이");
            }
            else
            {
                chickenBuilder
                .SetName("닭")
                .SetMake("달걀")
                .SetCry("꼬꼬댁")
                .SetEat("모이");
            }

            sheepBuilder.Build();
            cowBuilder.Build();
            chickenBuilder.Build();

            Console.WriteLine($"{sheepBuilder.name} : {sheepBuilder.make} : {sheepBuilder.cry} : {sheepBuilder.eat}");
            Console.WriteLine($"{chickenBuilder.name} : {chickenBuilder.make} : {chickenBuilder.cry} : {chickenBuilder.eat}");
        }

        public class AnimalBuilder
        {
            public string name;
            public string make;
            public string cry;
            public string eat;
            public Grade grade;
            public AnimalBuilder()
            {
                name = "이름";
                make = "생산품";
                cry = "울음소리";
                eat = "사료";
                grade = Grade.normal;
            }

            public Animal Build()
            {
                Animal animal = new Animal();

                animal.name = name;
                animal.make = make;
                animal.cry = cry;
                animal.eat = eat;
                animal.grade = grade;

                return animal;
            }

            public AnimalBuilder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public AnimalBuilder SetMake(string make)
            {
                this.make = make;
                return this;
            }

            public AnimalBuilder SetCry(string cry)
            {
                this.cry = cry;
                return this;
            }

            public AnimalBuilder SetEat(string eat)
            {
                this.eat = eat;
                return this;
            }

            public AnimalBuilder SetGrade(Grade grade)
            {
                this.grade = grade;
                return this;
            }
        }

        public class Animal
        {
            public string name;
            public string make;
            public string cry;
            public string eat;
            public Grade grade;
        }
    }
}
