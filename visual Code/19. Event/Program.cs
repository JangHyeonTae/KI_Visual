namespace _19._Event
{
    internal class Program
    {
        public class Player
        {
            public int hp = 100;

            public event Action OnDied;
            public Action<int> OnHPChanged;

            public void SetHp(int hp)
            {
                this.hp = hp;
                if (OnHPChanged != null)
                {
                    OnHPChanged(hp);
                }
            }

            public void Die()
            {
                Console.WriteLine("플레이어가 죽었습니다");
                if(OnDied != null)
                {
                    OnDied();
                }
            }
            
            //public void LevelUp()
            //{
            //    level++;
            //    if (OnLevelUped != null)
            //    {
            //        OnLevelUped();
            //    }
            //}

        }

        public class HPBar
        {
            public void SetHpBar(int hp)
            {
                Console.WriteLine("체력바의 수치를 {0)로 설정합니다", hp);
            }
        }

        public class Monster
        {
            public void Stop()
            {
                Console.WriteLine("몬스터가 더이상 플레이어를 따라가지 않습니다");
            }
        }

        public class  Game
        {
            public void GameOver()
            {
                Console.WriteLine("게임오버 UI를 띄웁니다");
            }
        
        }

        public class SFX
        {
            public void DieSound()
            {
                Console.WriteLine("슬플 음악이 재생됩니다");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            #region 1.delegate 사용한 event
            Monster monster1 = new Monster();
            Monster monster2 = new Monster();
            Game game = new Game();
            SFX sfx = new SFX();

            player.OnDied += monster1.Stop;
            player.OnDied += monster2.Stop;
            player.OnDied += game.GameOver;
            player.OnDied += sfx.DieSound;

            player.Die();
            #endregion

            #region event키워드 사용이유
            //event키워드 사용이유
            //문제1. 대입을 할경우
            //event 키워드의경우 대입을 막아버림
            //Monster bossMonster = new Monster(); //gameUI,sfx, monster1,
            //player.OnDied = bossMonster.Stop;    //monster2 함수실행안됨

            //문제2. 외부에서도 접근이 가능할경우 플레이어가
            //안 죽었을때. private사용시 플레이어 ondied접근조차 안됨
            //event 키워드의경우 플레이어에서만 OnDied를 호출가능
            //player.OnDied();
            #endregion


            #region 2. delegate 사용한 event
            //HPBar playerHpBar = new HPBar();
            //player.OnHPChanged = playerHpBar.SetHpBar;
            //player.SetHp(100);
            //player.SetHp(90);
            #endregion
            

            
        }
    }
}
