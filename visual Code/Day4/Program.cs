using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day4
{
    internal class Program
    {
        private static int _repeatCount = 0;
        static void Main(string[] args)
        {
            int playerHealth;

            while (true)
            {
                _repeatCount++;

                playerHealth = InputPlayerHealth();

                PrintRepeatCount();

                if (IsZero(playerHealth))
                {
                    Console.WriteLine("Game Over - 게임종료");
                    break;
                }
            }
        }

        private static bool IsZero(int playerHealth)
        {
            if (playerHealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int InputPlayerHealth()
        {
            
            while (true)
            {
                string numString = Console.ReadLine();
                int num;

                bool ok = int.TryParse(numString, out num);
                if (num >= 0 && num <= 100 && ok == true)
                {
                    return num;
                }
                
            }
        }

        private static void PrintRepeatCount()
        {
            Console.WriteLine("반복문이 출력된 횟수는 {0} 입니다", _repeatCount);
        }

        
    }
}
