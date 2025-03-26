using System.ComponentModel;

namespace _12._Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slime slime = new Slime();
            Dragon dragon = new Dragon();

            //상속받은 함수 사용 가능
            slime.Move();
            dragon.Move();

            //상속 받았을때 추가로 멤버함수 가능
            slime.Split();
            dragon.Breath();

            //업캐스팅 : 자식클래스는 부모클래스 자료형으로 형변환가능
            Monster monster0 = new Slime();
            Monster monster1 = new Dragon();

            //업캐스팅을 통해 간편히 Attack호출로 몬스터 공격가능
            //player는 Monster와 상호작용하여 여러 종류의 몬스터에 접근가능
            Player player = new Player();

            player.Attack(slime);
            player.Attack(dragon);

            //Item[] inventory = new Item[20];  // 업캐스팅
            //inventory[0] = new Potion();
            //inventory[1] = new Weapon();



        }

        class Monster
        {
            protected string name; //자식에서만 사용가능
            public int hp;
            public float speed;

            public void Move()
            {
                Console.WriteLine($"{name} 이 {speed}속도로 움직입니다.");
            }

            public void TakeDamage(int damage)
            {
                hp -= damage;
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 10;
                speed = 3.5f;
            }

            public void Split()
            {
                Console.WriteLine("몸을 분열합니다.");
            }
        }

        class Dragon : Monster
        {
            public float speed; //드래곤 speed
            //구분방법 this- 자신용, base -부모용
           public Dragon()
            {
                name = "드래곤";
                hp = 100;
                base.speed = 10f; //Monster speed
                this.speed = 5.5f;
            }

            public void Breath()
            {
                Console.WriteLine("불을 뿜습니다");
            }
        }
        class Player
        {
            public int attackPoint;

            
            public void Attack(Monster monster)
            {
                monster.TakeDamage(attackPoint);
            }
        }

        //업캐스팅 예제
        //class Item
        //{
        //    public string name;
        //    public string icon;
        //    public int weight;
        //}
        //
        //class Potion : Item { }
        //class Weapon : Item { }
    }
}
