using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Game.Items;
using Text_Game.Monsters;
using Text_Game.Scenes;

namespace Text_Game
{
    public static class Game
    {
        
        //게임에 필요한 정보들
        //1. 상황들
        private static bool gameOver;

        //씬을 보관하고 빠르게 해당씬을 보여주는 방법 Dictionary
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        public static Monster monster;
        
        private static Player player;
        public static Inventory inventory = new();
        public static Item item;
        public static Player Player { get{ return player; } }
        
        public static Item Item { get{ return item; } }
        
        //게임에 필요한 기능들
        //1. 게임시작
        public static void Start()
        {
            //Speed speed = new Speed();
            //Bead bead = new Bead();
            //Defence defence = new();
            //Power power = new();
            //게임 시작시에 필요한 작업들

            //게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());
            sceneDic.Add("Battle", new Battle());
            sceneDic.Add("Field", new Field());

            // 처음 시작할 씬을 선정
            curScene = sceneDic["Title"];

            player = new Player();
            player.HP = 20;
            player.Power = 10;
            player.Speed = 8;
            player.Point = 100;

            

        }

        //2. 게임 종료
        public static void End()
        {
            //게임 종료시에 필요한 작업들

        }

        //3. 게임동작
        public static void Run()
        {

            //게임 동작시에 필요한 작업들
            while (gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*         GAME OVER            *");
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine(reason);
            player.HP = 10;
            player.Power = 10;
            player.Speed = 8;
            player.Point = 100;

            gameOver = true;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("\t\t\t\t\t\t---------------------------------------------");
            Console.WriteLine($"\t\t\t\t\t\tPlayer 체력 : {player.HP}, 힘 : {player.Power}, 속도 : {player.Speed},방어 : {player.Defence} Point : {player.Point}         ");
            Console.Write($"\t\t\t\t\t\tInventory : ");
            InventoryPrint();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t---------------------------------------------");
        }

        public static void InventoryPrint()
        {
            if (inventory == null)
            {
                Console.Write("아이템이 없습니다.");
                return;
            }
            else
            {
                for (int i = 0; i < inventory.list.Count; i++)
                {
                    Console.Write($"{inventory.list[i].name}, ");
                }
            }
            
        }
    }
}
