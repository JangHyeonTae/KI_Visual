namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 사이값 합구하기
            //Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요");
            //
            //string numString1 = Console.ReadLine();
            //int num1;
            //bool check1 = int.TryParse(numString1, out num1);
            //
            //Console.WriteLine("끝 수를 입력해주세요");
            //
            //
            //string numString2 = Console.ReadLine();
            //int num2;
            //bool check2 = int.TryParse(numString2, out num2);
            //
            //if (num1 > num2)
            //{
            //    Console.WriteLine("첫번쨰 수가 더 큽니다!");
            //    return;
            //}
            //
            //int sum = 0;
            //
            //for (int i = num1+1; i < num2; i++)
            //{
            //    sum += i;
            //}
            //
            //Console.WriteLine($"{num1}과 {num2}사이의 숫자의 합은 {sum}입니다");
            #endregion

            #region 별만들기
           //for(int i = 0; i <= 5; i++)
           //{
           //    for (int j = 0; j < i; j++)
           //    {
           //        Console.Write("*");
           //    }
           //    Console.WriteLine();
           //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //
            //
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int m = 0; m < 4 - i; m++)
            //    {
            //    Console.Write(" ");
            //    }
            //
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //
            //for (int i = 5; i > 0; i--)
            //{
            //    for (int m = 0; m < 5-i; m++)
            //    {
            //        Console.Write(" ");
            //    }
            //
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //
            //    Console.WriteLine();
            //}
            #endregion

            #region 다이아만들기
            //int num;
            //
            //Console.WriteLine("출력할 다이아몬드를 홀수로 입력: ");
            //string numString = Console.ReadLine();
            //int.TryParse(numString, out num);
            //
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("홀수를 입력하세요");
            //}
            //else if (num == 1)
            //{
            //    Console.WriteLine("1이 아닌값을 입력하세요");
            //}
            //else if (num != 1 && num % 2 != 0)
            //{
            //    int half = num / 2;
            //
            //    for (int i = 0; i <= half; i++)
            //    {
            //        for (int m = 0; m < half - i; m++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 0; j < 2 * i + 1; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //
            //    for (int i = half - 1; i >= 0; i--)
            //    {
            //        for (int m = 0; m < half - i; m++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 0; j < 2 * i + 1; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //
            //}
            #endregion

        }
    }
}
