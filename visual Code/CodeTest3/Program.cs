namespace CodeTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10 };
            solution(arr);
        }

        public static int[] solution(params int[] num_list)
        {
            int[] answer = new int[] { };
            Stack<int> stack = new Stack<int>();
            Array.Sort(num_list);

            for (int i = num_list.Length - 1; i > 4; i--)
            {
                stack.Push(num_list[i]);
            }
            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine($"{stack.Pop()}");
            //}
            answer = stack.ToArray();
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine($"{answer[i]}");
            }
            
            
            return answer;
        }
    }
}
