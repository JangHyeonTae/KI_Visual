namespace _12._Inheritance2
{
    internal class Program
    {
        public abstract class Animal
        {
            public abstract void Run();
        }

        public class Dog : Animal 
        {
            int speed = 10;
            public override void Run()
            {
                Console.WriteLine("{0}속도로 달립니다!", speed);
            }
        }

        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Run();
        }
    }
}
