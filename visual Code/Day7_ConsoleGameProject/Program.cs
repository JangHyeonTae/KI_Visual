//1. 콘솔클리어 Console.Clear(); Console.Light?
//2. 2차원 배열 형태
//3. 게임적 메커니즘 ex)미로찾기, 코인모으기.소코반 상자모으기

//추가사항
//4. 레벨메커니즘
//5. 최고기록 최단기록
//6. Key로 재시작

using System.Diagnostics.Metrics;
using System.Reflection;

namespace Day7_ConsoleGameProject
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }

        struct EnemyPosition
        {
            public int x;
            public int y;
        }

        struct Weapon
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            bool gameOver = false;
            bool isWeapon = false;
            Position playerPos;
            EnemyPosition enemyPos;
            Weapon weaponPos;
            char[,] map;

            const int waitTick = 1000/10 ;
            int lastTick = 0;
            int currentTime;
            int counter = 0;

            Start(out playerPos, out enemyPos, out weaponPos, out map);
            while (gameOver == false)
            {
                currentTime = Environment.TickCount;

                if (currentTime - lastTick < waitTick)
                {
                    continue;
                    
                }
                else 
                {
                    lastTick = currentTime;
                    Render(playerPos, enemyPos, weaponPos, map, ref isWeapon);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Input();
                        Update(key, ref playerPos, ref enemyPos, ref weaponPos, map, ref isWeapon, ref gameOver, counter);
                        continue;
                    }
                    
                }
                counter++;
                Console.SetCursorPosition(40, 0);
                Console.Write(counter);
                //Console.Write(isWeapon);
                if (counter > 10)
                {
                    counter -= 10;
                    
                }
            }

            End();
        }

        


        private static void Start(out Position playerPos, out EnemyPosition enemyPos,
            out Weapon weaponPos, out char[,] map)
        {
            Random randPos = new Random();

            playerPos.x = 10;
            playerPos.y = 10;

            enemyPos.x = randPos.Next(2, 17);
            enemyPos.y = randPos.Next(2, 15);

            weaponPos.x = playerPos.x;
            weaponPos.y = playerPos.y - 1;

            map = new char[21, 20]
            {
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#', '#'},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',}

            };
        }

        private static void Render(Position playerPos, EnemyPosition enemyPos,
            Weapon weaponPos, char[,] map, ref bool isWeapon)
        {
            Console.SetCursorPosition(0, 0);
            PrintMap(map);
            PrintPlayer(playerPos);
            PrintEnemy(enemyPos);
            if (isWeapon)
            {
                PrintWeapon(weaponPos, playerPos);
            }


        }

        static void PrintMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        static void PrintPlayer(Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        static void PrintEnemy(EnemyPosition enemyPos)
        {
            Console.SetCursorPosition(enemyPos.x, enemyPos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('E');
            Console.ResetColor();
        }

        static void PrintWeapon(Weapon weaponPos, Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y - 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('*');
            Console.ResetColor();
        }

        private static ConsoleKey Input()
        {
            return Console.ReadKey(true).Key;
        }

        private static void Update(ConsoleKey key, ref Position playerPos, ref EnemyPosition enemyPos,
            ref Weapon weaponPos, char[,] map, ref bool isWeapon, ref bool gameOver, int counter)
        {

            switch (key)
            {
                case ConsoleKey.W:
                    if (map[playerPos.y - 1, playerPos.x] != '#')
                    {
                        playerPos.y--;
                    }
                    break;
                case ConsoleKey.S:
                    if (map[playerPos.y + 1, playerPos.x] != '#')
                    {
                        playerPos.y++;
                    }
                    break;
                case ConsoleKey.A:
                    if (map[playerPos.y, playerPos.x - 1] != '#')
                    {
                        playerPos.x--;
                    }
                    break;
                case ConsoleKey.D:
                    if (map[playerPos.y, playerPos.x + 1] != '#')
                    {
                        playerPos.x++;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (isWeapon == false)
                    {
                        isWeapon = true;
                    }
                    //스페이스바를 누를시 이함수 실행
                    MoveWeapon(ref weaponPos,counter, ref map, isWeapon);
                    break;
                default:
                    return;
            }
        }
        static void MoveWeapon(ref Weapon weaponPos, int counter, ref char[,] map, bool isWeapon)
        {
            if (map[weaponPos.y - 1, weaponPos.x] != '#' && counter >= 100)
            {
                for (int i = 0; i < map.GetLength(0) - weaponPos.y; i++)
                {
                    weaponPos.y--;
                }
            }
        }

        private static void End()
        {

        }
    }
}
