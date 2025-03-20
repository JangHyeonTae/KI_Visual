namespace Day6
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            bool gameOver = false;
            Position playerPos;
            Position goalPos;
            bool[,] map;

            Start(out playerPos,out goalPos, out map);

            while (gameOver == false)
            {
                //게임루프
                Render(playerPos,goalPos, map);
                ConsoleKey key = Input();
                Update(key, ref playerPos, goalPos, map, ref gameOver);
            }

            End();

        }

        //out 맵을 결과로 출력되길 원해서 사용
        static void Start(out Position playerPos,out Position goalPos, out bool[,] map)
        {
            //시작 작업

            Console.CursorVisible = false;  

            //플레이어 초기위치 설정
            playerPos.x = 1;
            playerPos.y = 1;

            //목적지 위치 설정하기
            goalPos.x = 12;
            goalPos.y = 8;

            map = new bool[10,15]
            {
                {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                {false, true,  true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, true,  true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, true,  true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, true,  true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, true,  true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {false, false,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {true, true,  false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
                {true, true, false, false, false, false, false, false, false, false, false, false, false, false, false },
            };

            ShowTitle();
        }

        static void ShowTitle()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("미로찾기");
            Console.WriteLine("=======================");
            Console.WriteLine("");
            Console.WriteLine("아무키나 눌러서 시작하세요");

            Console.ReadKey(true);
            Console.Clear();
        }
        static void Render(Position playerPos,Position goalPos, bool[,] map)
        {
            //출력작업

            //백버퍼 - 지워주기
            Console.Clear(); // 콘솔 지우기

            PrintMap(map);

            PrintPlayer(playerPos);

            PrintGoal(goalPos);
        }

        static void PrintMap(bool[,] map)
        {
            //맵 출력
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == false)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        static void PrintPlayer(Position playerPos)
        {
            //플레이어 위치로 커서 옮기기
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            //플레이어 출력
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        static void PrintGoal(Position goalPos)
        {
            Console.SetCursorPosition(goalPos.x, goalPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('G');
            Console.ResetColor();
        }

        static ConsoleKey Input()
        {
            //입력작업
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        static void Update(ConsoleKey key, ref Position playerPos,Position goalPos, bool[,] map,ref bool gameOver)
        {
            //처리작업

            Move(key, ref playerPos, map);

            //골에 도달했는지 확인
            bool isClear = CheckGameClear(playerPos, goalPos);
            if (isClear)
            {
                //게임종료
                gameOver = true;
            }
        }

        static void Move(ConsoleKey key, ref Position playerPos, bool[,] map)
        {
            //이동
            switch (key)
            {
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (map[playerPos.y, playerPos.x - 1] == true)
                    {
                        playerPos.x--;
                    }
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (map[playerPos.y, playerPos.x + 1] == true)
                    {
                        playerPos.x++;
                    }
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (map[playerPos.y - 1, playerPos.x] == true)
                    {
                        playerPos.y--;
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (map[playerPos.y + 1, playerPos.x] == true)
                    {
                        playerPos.y++;
                    }
                    break;
            }
        }

        static bool CheckGameClear(Position playerPos, Position goalPos)
        {
            bool success = (playerPos.x == goalPos.x) && (playerPos.y == goalPos.y);

            return success;
        }
        static void End()
        {
            //종료
            Console.Clear();
            Console.WriteLine("축하합니다!");
        }
    }
}
