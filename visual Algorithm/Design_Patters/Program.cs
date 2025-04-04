using System.Threading;

namespace Design_Patters
{
    //Factory Pattern
    //class의 단일책임 해결에 유용
    //책임 분산
    //코드가 길어질 수 있음


    //Builder Pattern
    //부품들로 다양한 객체 생성
    //체인메서드 필요
    internal class Program
    {
        #region <Factory Pattern>
        //static void Main(string[] args)
        //{
        //    // 스테이지 1-1
        //    MonsterFactory level1Factory = new MonsterFactory();
        //    level1Factory.rate = 1;
        //
        //    // 1. 처음 맵 만들어 졌을 때 -> 몬스터 3마리
        //    Monster monster11 = level1Factory.Create("슬라임");
        //    Monster monster33 = level1Factory.Create("슬라임");
        //    Monster monster55 = level1Factory.Create("슬라임");
        //
        //    // 2. 다음 장소로 이동했을 때 -> 몬스터 5마리
        //    Monster monster1 = level1Factory.Create("슬라임");
        //    Monster monster2 = level1Factory.Create("슬라임");
        //    Monster monster3 = level1Factory.Create("슬라임");
        //    Monster monster4 = level1Factory.Create("고블린");
        //    Monster monster5 = level1Factory.Create("고블린");
        //
        //    // 3. 보스룸 입장하면 -> 몬스터 2마리
        //    Monster bossMonster = level1Factory.Create("오크족장");
        //    Monster subMonster1 = level1Factory.Create("고블린");
        //    Monster subMonster2 = level1Factory.Create("고블린");
        //
        //
        //    // 스테이지 2-1
        //    MonsterFactory level2Factory = new MonsterFactory();
        //    level2Factory.rate = 1.1f;
        //    Monster level2monster1 = level2Factory.Create("슬라임");
        //    Monster level2monster2 = level2Factory.Create("슬라임");
        //
        //}
        //
        //public class MonsterFactory
        //{
        //    public float rate;
        //
        //    public Monster Create(string name)
        //    {
        //        Monster monster;
        //        switch (name)
        //        {
        //            case "슬라임": monster = new Monster("슬라임", 1, 100); break;
        //            case "고블린": monster = new Monster("고블린", 3, 200); break;
        //            case "오크족": monster = new Monster("오크족장", 10, 2000); break;
        //            default: return null;
        //        }
        //
        //        monster.hp = (int)(monster.hp * rate);
        //        return monster;
        //    }
        //
        //    public Monster Create(string name, float rate)
        //    {
        //        Monster monster = Create(name);
        //        monster.hp = (int)(monster.hp * rate);
        //        return monster;
        //    }
        //}
        //
        //public class Monster
        //{
        //    public string name;
        //    public int level;
        //    public int hp;
        //
        //    public Monster(string name, int level, int hp)
        //    {
        //        this.name = name;
        //        this.level = level;
        //        this.hp = hp;
        //    }
        //}
        #endregion

        #region Chain method
        //static void Main(string[] args)
        //{
        //    GameObject gameObject = new GameObject();
        //
        //    gameObject.SetX(10).SetY(5).SetZ(3); //체인메서드 : 연달아서 호출가능
        //}
        //
        //public class GameObject
        //{
        //    public int x;
        //    public int y;
        //    public int z;
        //
        //    public GameObject SetX(int x)
        //    {
        //        this.x = x;
        //        return this;
        //    }
        //    public GameObject SetY(int y)
        //    {
        //        this.y = y;
        //        return this;
        //    }
        //
        //    public GameObject SetZ(int z)
        //    {
        //        this.z = z;
        //        return this;
        //    }
        //}
        #endregion

        #region <Builder Pattern>
        //static void Main(string[] args)
        //{
        //    MonsterBuilder orcArcherBuilder = new MonsterBuilder();
        //    orcArcherBuilder.SetName("오크 궁수").SetWeapon("나무 활").SetArmor("가죽 갑옷");
        //
        //    MonsterBuilder orcWarriorBuilder = new MonsterBuilder();
        //    orcWarriorBuilder.SetName("오크 전사").SetArmor("철 갑옷");
        //    
        //    Monster monster0 = orcArcherBuilder.Build();
        //    Monster monster1 = orcWarriorBuilder.Build();
        //}
        //
        //public class MonsterBuilder
        //{
        //    public string name;
        //    public string weapon;
        //    public string armor;
        //
        //    public MonsterBuilder()
        //    {
        //        name = "몬스터";
        //        weapon = "기본무기";
        //        armor = "기본갑옷";
        //    }
        //        
        //    public Monster Build()
        //    {
        //        Monster monster = new Monster();
        //        monster.name = name;
        //        monster.weapon = weapon;
        //        monster.armor = armor;
        //
        //        return monster;
        //    }
        //
        //    public MonsterBuilder SetName(string name)
        //    {
        //        this.name = name;
        //        return this;
        //    }
        //
        //    public MonsterBuilder SetWeapon(string weapon)
        //    {
        //        this.weapon = weapon;
        //        return this;
        //    }
        //
        //    public MonsterBuilder SetArmor(string armor)
        //    {
        //        this.armor = armor;
        //        return this;
        //    }
        //}
        //
        //public class Monster
        //{
        //    public string name;
        //    public string weapon;
        //    public string armor;
        //
        //
        //}
        #endregion
    }



}
