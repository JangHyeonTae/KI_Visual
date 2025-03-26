using System.Security.Cryptography.X509Certificates;

namespace PoketMon_Inheritance
{
    internal class Program
    {
        public class Trainer
        {
            public Pokemon[] pokemon = new Pokemon[6]
            {
                new Bulbasaur(),
                new Charmander(),
                new Squirtle(),
                new Butterfree(),
                new Pikachu(),
                new Golbat(),
            };

            public Pokemon Pick(int index)
            {
                return pokemon[index];
            }

            public void Print()
            {
                for (int i = 0; i < pokemon.Length; i++)
                {
                    Console.Write("나의 포켓몬은 : ");
                    Console.Write($"{pokemon[i].name}");
                    Console.WriteLine();
                }
            }
        }

        public abstract class Pokemon
        {
            public string name;
            public int level;
            public void Name()
            {
                Console.Write($"{name} ");

            }
            public abstract void Attack();
        }

        public class Bulbasaur : Pokemon
        {
            public Bulbasaur()
            {
                name = "이상해씨";
                level = 1;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("줄기로 때려");
            }
        }

        public class Charmander : Pokemon
        {
            public Charmander()
            {
                name = "파이리";
                level = 2;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("불덩이~");
            }
        }

        public class Squirtle : Pokemon
        {
            public Squirtle()
            {
                name = "꼬부기";
                level = 3;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("물대포!");
            }
        }

        public class Butterfree : Pokemon
        {
            public Butterfree()
            {
                name = "나비";
                level = 4;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("꽃가루를 날려");
            }
        }

        public class Pikachu : Pokemon
        {
            public Pikachu()
            {
                name = "피카츄";
                level = 5;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("백만볼트");
            }
        }

        public class Golbat : Pokemon
        {
            public Golbat()
            {
                name = "골벳";
                level = 6;
            }
            public override void Attack()
            {
                base.Name();
                Console.WriteLine("돌로 때려");
            }
        }

        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            trainer.Print();

            Console.WriteLine($"{trainer.Pick(2).name}의 레벨은 {trainer.Pick(2).level} 입니다.");
            trainer.Pick(2).Attack();
        }
    }
}
