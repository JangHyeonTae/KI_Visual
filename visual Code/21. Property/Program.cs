namespace _21._Property
{
    internal class Program
    {
        public class Player
        {
            private int hp = 100;

            public int GetHP()
            {
                return hp;
            }
            private void SetHP(int hp)
            {
                this.hp = hp;
            }
            //읽는기능 쓰기기능 설정   get 읽기     set 쓰기 - c#기능중 하나
            //get set 변수를 사용할 때 자주 씀
            public int MP { get; private set; }

            private int ap;
            public int AP
            {
                get { return ap; }
                set { ap = value; OnAPChanged?.Invoke(value); }
            }
            public event Action<int> OnAPChanged;

            #region 람다식 예제
            //public bool IsDead => hp <= 0;

            //public bool IsDeadd()
            //{
            //    return hp <= 0;
            //}
            #endregion

            #region
            //public event Action OnDied;
            //public void TakeDamage(int damage)
            //{
            //    hp -= damage;
            //    if (hp <= 0)
            //    {
            //        Die();
            //    }
            //}
            //
            //private void Die()
            //{
            //    if (OnDied != null)
            //    {
            //        OnDied();
            //    }
            //    
            //}
            #endregion
        }

        static void Main()
    {
        Player player = new Player();
        //player.hp =0; 일경우 이벤트함수 실행x 에러 이때
        //hp를 private를 사용하고 프로퍼티를 사용해서 읽기전용을 사용

        int mp = player.MP;
    }
}
}
