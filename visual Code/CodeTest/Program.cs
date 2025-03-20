
namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 낮은숫자 출력하기 문제7
            //int[] num = new int[6];
            //
            //
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = i + 1;
            //    for (int j = 1; j < num.Length; j++)
            //    {
            //        if (num[i] > j)
            //        {
            //            Console.WriteLine(num[i]+ "는" + j + "보다 크다");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            solution([1,2,3]);
        }


        static public int solution(int[] sides)
        {
            int max = 0;
            int min = 0;
            int mid = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] > max)
                {
                    max = sides[i];
                }
                else if (sides[i] < max && sides[i] > mid)
                {
                    mid = sides[i];
                }
                else if (sides[i] < mid)
                {
                    min = sides[i];
                }
            }

            if (max < min + mid)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        }

    }
}
