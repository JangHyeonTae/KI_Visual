namespace _12._Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //업캐스팅(자동으로 가능)
            Monster monster = new Slime();
            //Monster monster = new Dragon();// 다운캐스팅에서 이경우 안됨
            monster.Move();

            //다운캐스팅(불가능한 경우가 있기때문에 확인후 변환가능
            //is 만약 A is B : B 가 true true반환
            //형변환이 가능하면 true 아니면 false
            if (monster is Slime) 
            {
                Slime slime = (Slime)monster;
                slime.Move();
                slime.Split();
            }
            else if (monster is Dragon)
            {
                Dragon dragon = (Dragon)monster;
                dragon.Breath();
            }
            //다운캐스팅 안 좋은예
            //Slime slime = (Slime)monster;
            //slime.Move();
            //slime.Split();

            //as : 형변환이 가능하면 바꿔서 주고. 아니면 null
            Dragon dragon1 = monster as Dragon;
        }

        class Player
        {
            public int attackPoint;

            public void Attack(Monster monster)
            {
                monster.TakeDamage(attackPoint);
            }
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
    }
}
