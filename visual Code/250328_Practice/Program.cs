namespace _250328_Practice
{
    internal class Program
    {
        #region 요세푸스
        //public static int Circle(int n, int k)
        //{
        //    Queue<int> queue = new Queue<int>(n);
        //
        //    for (int i = 1; i <= n; i++)
        //    {
        //        queue.Enqueue(i);
        //    }
        //
        //    int count = 0;
        //    while (queue.Count > 1)
        //    {
        //        count++;
        //        if (count % k == 0)
        //        {
        //            queue.Dequeue();
        //        }
        //        else
        //        {
        //            int value = queue.Dequeue();
        //            queue.Enqueue(value);
        //        }
        //    }
        //
        //    return queue.Dequeue();
        //}
        //
        //static void Main(string[] args)
        //{
        //    int n = 7;
        //    int k = 3;
        //    int value = Circle(n, k);
        //
        //    Console.WriteLine(" n , k : {0}", value);
        //}
        #endregion

        #region 괄호검사
        public static bool InStack(string str)
         {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char strChar = str[i];
                switch (strChar)
                {
                    case '[':
                    case '{':
                    case '(':
                        stack.Push(strChar);
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '(') return false;
                        stack.Pop();
                        break;
                    case '}':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '{') return false;
                        stack.Pop();
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '[') return false;
                        stack.Pop();
                        break;
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
         }

        public static void Main()
        {
            Console.WriteLine($"{InStack("[{}()]")}");
        }
        #endregion
    }
}
