namespace Dictionary
{
    internal class Program
    {
        public class Monster
        {
            public string name;
            public int id;
            
            public Monster(string _name, int _id)
            {
                this.name = _name;
                this.id = _id;
            }

        }

        static void Main(string[] args)
        {
            Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();

            //추가 : O(1)
            monsterDic.Add("피카츄", new Monster("피카츄", 1));
            monsterDic.Add("파이리", new Monster("파이리", 2));
            monsterDic.Add("꼬부기", new Monster("꼬부기", 3));
            monsterDic.Add("이상해씨", new Monster("이상해씨", 4));

            monsterDic.TryAdd("피카츄", new Monster("other Monster", 5));
            
            //삭제 : O(1)
            monsterDic.Remove("피카츄"); //Remove(key)

            //탐색 : O(1)
            monsterDic.ContainsKey("파이리");
            monsterDic.TryGetValue("파이리", out Monster monster);

            //인덱서를 통한 간략한 사용
            Monster find = monsterDic["파이리"]; // 파이리 찾기
            monsterDic["피카츄"] = new Monster("피카츄", 1); //피카츄 value 바꾸기
        }
    }
}
