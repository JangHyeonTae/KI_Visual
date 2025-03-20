using System;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 호감도테스트
            //int num;
            //int currentPoint = 0;
            //
            //Console.WriteLine("어떤 동물을 좋아하시나요?");
            //Console.WriteLine("토끼, 강아지, 고양이");
            //
            //string answer = Console.ReadLine();
            //
            //Console.WriteLine("--------------------------------------------");
            //
            //switch (answer)
            //{
            //    case "토끼":
            //        Console.WriteLine("저는 별로,,,");
            //        currentPoint += 0;
            //        break;
            //    case "강아지":
            //        Console.WriteLine("저도 강아지 좋아해요!");
            //        currentPoint += 20;
            //        break;
            //    case "고양이":
            //        Console.WriteLine("고양이 알러지가 있어서...");
            //        currentPoint -= 10;
            //        break;
            //}
            //
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("어떤 게임장르 좋아하시나요?");
            //Console.WriteLine("1. FPS   2. RPG   3. 안해요");
            //
            //string numString = Console.ReadLine();
            //int.TryParse(numString, out num);
            //
            //if (num == 1)
            //{
            //    Console.WriteLine("저도 좋아해요!");
            //    currentPoint += 20;
            //}
            //else if (num == 2)
            //{
            //    Console.WriteLine("좋네요~");
            //    currentPoint += 10;
            //}
            //else
            //{
            //    Console.WriteLine("아....");
            //    currentPoint -= 30;
            //}
            //
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine($"호감도 점수는~~ : {currentPoint}");
            //if (currentPoint < 10)
            //{
            //    Console.WriteLine("저랑은 안 맞으시네요...");
            //}
            //else if (currentPoint >= 10 && currentPoint <20)
            //{
            //    Console.WriteLine("합이 살짝 안 맞네요...");
            //}
            //else if (currentPoint >= 20 && currentPoint < 30)
            //{
            //    Console.WriteLine("잘 맞을 수 있을거 같아요~");
            //}
            //else if (currentPoint > 30)
            //{
            //    Console.WriteLine("천생연분!");
            //}
            #endregion

            #region 계산기
            Console.WriteLine("숫자를 입력해주세요");
            
            
            int result = 0;
            
            int num1;
            int num2;
            char operation;
            
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            string operationRead = Console.ReadLine();
            //char.TryParse()
            
            bool correct1 = int.TryParse(number1, out num1);
            bool correct2 = int.TryParse(number2, out num2);
            char.TryParse(operationRead, out operation);
            
            Console.WriteLine("------------------------------------------");
            
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (correct2 == false || num2 == 0)
                    {
                        return;
                    }
                    result = num1 / num2;
                    
                    break;
                case '%':
                    if (correct2 == false || num2 == 0)
                    {
                        return;
                    }
                    result = num1 % num2;
                    break;
            }
            
            Console.WriteLine($"{num1} {operation} {num2} = {result} ");
            #endregion

            #region 숫자맞추기
            //Random random = new Random();
            //int num = random.Next(1,100);
            //int myNum;
            //
            //int cnt = 0;
            //while (cnt < 10)
            //{
            //    Console.Write("번호를 입력하세요.");
            //    myNum = Convert.ToInt32(Console.ReadLine());
            //    if (num > myNum)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("틀렸습니다. 더 높습니다");
            //        Console.ResetColor();
            //    }
            //    else if (num < myNum)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine("틀렸습니다. 더 낮습니다");
            //        Console.ResetColor();
            //    }
            //    else if (num == myNum)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("정답입니다.");
            //        Console.ResetColor();
            //        break;
            //    }
            //    cnt++;
            //
            //    if (cnt == 10)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("땡!");
            //        Console.ResetColor();
            //    }
            //
            //
            //}
            #endregion

        }

    }
}
