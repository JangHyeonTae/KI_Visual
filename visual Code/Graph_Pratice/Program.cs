namespace Graph_Pratice
{
    internal class Program
    {
        #region 장현태
        //static void Main(string[] args)
        //{
        //    bool[,] graph = new bool[8, 8];
        //
        //    graph[0, 3] = true;
        //    graph[3, 0] = true;
        //    graph[0, 2] = true;
        //    graph[2, 0] = true;
        //    graph[0, 4] = true;
        //    graph[4, 0] = true;
        //
        //    graph[1, 2] = true;
        //    graph[2, 1] = true;
        //    graph[1, 3] = true;
        //    graph[3, 1] = true;
        //    graph[1, 5] = true;
        //    graph[5, 1] = true;
        //    graph[1, 6] = true;
        //    graph[6, 1] = true;
        //
        //    graph[2, 6] = true;
        //    graph[6, 2] = true;
        //
        //    graph[3, 7] = true;
        //    graph[7, 3] = true;
        //
        //    graph[5, 7] = true;
        //    graph[7, 5] = true;
        //
        //    graph[6, 7] = true;
        //    graph[7, 6] = true;
        //}
        #endregion

        public void Main1()
        {
           

        }

        public static void Main()
        {
            List<int>[] graph = new List<int>[8];

            graph[0] = new List<int> { 0,2,4 };
            graph[1] = new List<int> { 2,3,5,6};
            graph[2] = new List<int> { 0,1,6};
            graph[3] = new List<int> { 0,1,7};
            graph[4] = new List<int> { 0 };
            graph[5] = new List<int> { 1,7 };
            graph[6] = new List<int> { 1,2,7 };
            graph[7] = new List<int> { 3,5,6};

        }

    }
}
