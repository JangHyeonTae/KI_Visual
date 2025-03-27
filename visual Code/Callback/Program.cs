namespace Callback
{
    internal class Program
    {

        public class Call
        {
            public void Calling()
            {
                Console.WriteLine("연락받고 전화 드렸어요~~");
            }
        }

        public class Guest
        {
            public delegate void Guest1();
            public Guest1 guest;
            public void WaitCall()
            {
                Console.WriteLine("나중에 오시면 연락주세요~");
                guest?.Invoke();
            }
        }
        static void Main(string[] args)
        {
            Call call = new Call();
            Guest wait = new Guest();

            wait.guest = call.Calling;

            wait.WaitCall();
        }
    }
}
