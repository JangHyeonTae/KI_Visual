namespace Event_Practice
{
    internal class Program
    {
        class Player
        {
            public event Action OnDestroy;
            public event Action AccessoriesAttack;
            public int armorDefense = 10;
            public int TakeDamage(int damage)
            {
                armorDefense -= damage;
                if (armorDefense <= 0)
                {
                    armorDefense = 0;
                }
                Console.WriteLine($"Player가 {damage}만큼 데미지를 받았습니다");
                Console.WriteLine($"갑옷의 내구도 : {armorDefense}");
                return armorDefense;
            }

            public void TakeOn()
            {
                Console.WriteLine("값옷을 입었다");
            }

            public void TakeOff(Armor armor)
            {
                if (armorDefense <= 0)
                {
                    OnDestroy?.Invoke();
                    Console.WriteLine("갑옷을 벗었다");
                }
            }

            public void Attack()
            {
                AccessoriesAttack?.Invoke();
            }
        }

        class AttackAccessories
        {
            public string itemName;
            public int attackDamage;
            public void AttackDamage()
            {
                Console.WriteLine($"{itemName}이/가 {attackDamage}만큼 공격합니다.");
            }
        }

        class Armor : AttackAccessories
        {
            public Armor()
            {
                itemName = "갑옷";
                attackDamage = 10;
            }

            public void Destroy()
            {
                Console.WriteLine("갑옷이 부셔졌다");
            }
        }

        class Ring : AttackAccessories
        {
            public Ring()
            {
                itemName = "반지";
                attackDamage = 30;
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor armor = new Armor();
            Ring ring = new Ring();


            player.AccessoriesAttack += armor.AttackDamage;
            player.AccessoriesAttack += ring.AttackDamage;

            player.Attack();

            player.TakeDamage(3);
            player.TakeDamage(4);
            player.TakeDamage(5);


            player.OnDestroy += armor.Destroy;
            player.TakeOff(armor);

        }
    }
}
