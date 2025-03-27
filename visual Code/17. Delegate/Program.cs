namespace _17._Delegate
{
    
    internal class Program
    {
        //public delegate float DelegateMethod1(float a, float b);
        //public static float Plus(float a, float b) { return a + b; }

        #region callback
        //public class File
        //{
        //    public void Save()
        //    {
        //        Console.WriteLine("Save");
        //    }
        //
        //    public void Load()
        //    {
        //        Console.WriteLine("Load");
        //    }
        //}
        //
        //public class Player
        //{
        //    public void Jump()
        //    {
        //        Console.WriteLine("Jummp");
        //    }
        //}
        //
        //public class Button
        //{
        //    public delegate void ClickListener();
        //    public ClickListener click;
        //
        //    public void ButtonClick()
        //    {
        //        if (click != null)
        //        {
        //            click();
        //        }
        //    }
        //
        //}
        //
        //
        //static void Main(string[] args)
        //{
        //    File file = new File();
        //    Player player = new Player();
        //    
        //    Button save = new Button();
        //    Button load = new Button();
        //    Button jump = new Button();
        //    
        //    save.click = file.Save;
        //    load.click = file.Load;
        //    jump.click = player.Jump;
        //    
        //    save.ButtonClick();
        //    load.ButtonClick();
        //    jump.ButtonClick();
        //
        //
        //
        //    //DelegateMethod1 delegate1 = Plus;
        //}
        #endregion

        #region func델리게이트
        //public static float Test(int value1,string value2) { return 0; }
        //Func<int, string, float> func = Test;
        //
        //public static string Test2(float value) { return " 안녕"; }
        //Func<float, string>func2 =  Test2;
        #endregion

        #region Action delegate
        //Action 델리게이트
        //void는 일반화 안되기 때문에 action사용
        //반환형이 void이며 매개변수를 지정한 델리게이트
        //Action<매개변수1,매개변수2,...>
        //
        //static void Message(string message) { Console.WriteLine(message); }
        //void Main2()
        //{
        //    Action<string> action;
        //    action = Message;
        //}
        //public static void Test1(float x,int value,string text) { }
        //public static void Main()
        //{
        //    Action<string> action = Message;
        //
        //    Action<float, int, string> ac = Test1;
        //}
        #endregion
    }
}
