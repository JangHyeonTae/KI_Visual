using System.Xml.Linq;

namespace _01_HellowWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "장현태";           //데이터 형에 따른 변수 초기화
            int age1 = 27;                     //데이터 형에 따른 변수 초기화
            float height = 173f;               //데이터 형에 따른 변수 초기화
            string major1 = "멀티미디어";      //데이터 형에 따른 변수 초기화
            string hobby1 = "운동";            //데이터 형에 따른 변수 초기화
            bool girlFriend1 = false;          //데이터 형에 따른 변수 초기화

            //{i}는 자리표시자로 변수의 값이 들어갑니다.
            //Console.WriteLine은 콘솔에 데이터를 출력하는 것이고 줄바꿈을 실행합니다
            //Console.Write는 콘솔에 데이터를 출력하는 것이고 줄바꿈을 하지않고 실행합니다.
            //\n은 줄바꿈을 실행합니다
            Console.WriteLine("안녕하세요 저는 {0}입니다", name1); //{0}에 name1값이 들어감
            Console.WriteLine("저는 {0}살이고 키는 {1}cm 입니다", age1, height); //{0}에 age1, {1}에 height 값이 들어감
            Console.Write("제 취미는 {0}이고, 전공은 {1}입니다. \n", hobby1, major1);//{0}에 hobby, {1}에 major1 값이 들어감 
            Console.WriteLine("여자친구는 {0} 입니다.\n\n", girlFriend1);//{0}에 girlFriend1 값이 들어감

        }
    }
}
