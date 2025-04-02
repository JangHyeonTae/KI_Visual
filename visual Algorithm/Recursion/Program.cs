namespace Recursion
{
    internal class Program
    {
        //재귀함수 : 내 자신을 참조하는경우


        // 폴더 삭제
        public class Folder
        {
            //public List<string> files;
            public List<Folder> childern;
        }

        public static void RemoveFolder(Folder folder)
        {
            //파일들 삭제하고

            foreach (Folder child in folder.childern)
            {
                RemoveFolder(child);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }

        public static int Factorial(int n)
        {
            if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            else
            {
                return 1;
            }
            
        }
    }
}
