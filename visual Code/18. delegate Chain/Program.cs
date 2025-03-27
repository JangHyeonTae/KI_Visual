namespace _18._delegate_Chain
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Action action;
        //    action = Func1; //델리게이트에 Func1 저장
        //    action += Func2;// 델리게이트에 Func2 추가저장
        //    action += Func3;
        //
        //    action -= Func1;
        //    if (action != null) // action()?.Invoke();
        //    {
        //        action();
        //    }
        //}
        //
        //public static void Func1() { Console.WriteLine("Func1");}
        //public static void Func2() { Console.WriteLine("Func2");}
        //public static void Func3() { Console.WriteLine("Func3");}




        public static void Main()
        {
            Action action;
            action = Test1;
            action += Test2;
            action += Test3;
            action -= Test3;

            action = Test3;
            action?.Invoke();
        }

        public static void Test1() { Console.WriteLine("Test1"); }
        public static void Test2() { Console.WriteLine("Test2"); }
        public static void Test3() { Console.WriteLine("Test3"); }

    }
}
