using System.Security.Cryptography.X509Certificates;

namespace _15._generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region swap
            //int a = 10;
            //int b = 20;
            //
            //GenericSwap.Swap<int>(ref a, ref b);
            #endregion
            //int intBigger = Bigger(10, 20);
            //Console.WriteLine(intBigger);



            Item itemSort = Bigger(new Item(), new Item());
        }
        public class Item : IComparable<Item>
        {
            public string name;
            public int CompareTo(Item? other)
            {
                return this.name.CompareTo(other.name);
            }
        }

        public static T Bigger<T>(T value1, T value2) where T : IComparable<T>
        {
            if (value1.CompareTo(value2) > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }





        #region Swap
        //public class GenericSwap
        //{
        //    public static void Swap<T>(ref T a, ref T b)
        //    {
        //        T temp = a;
        //        a = b;
        //        b = temp;
        //    }
        //}
        #endregion
    }
}
