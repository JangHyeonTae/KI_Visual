namespace Searching
{
    internal class Program
    {
        #region <순차탐색>
        //자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
        //시간복잡도 - O(n)

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion


        #region <이진 탐색>
        //정렬이 되어있는 자료구조에서 2분할을 통해 데이터를 탐색
        //단, 이진탐색은 정렬이 되어있는 자료에만 적용가능 
        //시간 복잡도 - O(logn)

       //public static int BinarySearch(int[] array, int target)
       //{
       //    int low = 0;
       //    int high = array.Length - 1;
       //
       //    while (없을떄까지)
       //    {
       //        //중간 위치를 mid로 잡는다;
       //
       //        if(중간값이 찾고자 하는 값보다 더 큰경우)
       //        {
       //            //오른쪽 값들은 무시 -> high를 mid 한칸 앞으로 당긴다
       //        }
       //        else if(중간값이 찾고자 하는 값보다 더 작은 경우)
       //        {
       //            //왼쪽 값들은 무시 -> low를 mid 한칸 뒤로 옮긴다.
       //        }
       //        else //if( 준간 값이 찾고자 하는 값이랑 같은 경우)
       //        {
       //            //값을 찾았다
       //        }
       //    }
       //    return -1;
       //}

        public static int BinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] > target)
                {
                    high = mid - 1;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        #endregion


        #region <DFS - Depth First Search>
        // Stack
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        // 장점: 지금 탐색 상황에서 필요한 정점 데이터만 보관가능하고 탐색이 끝나면 버려도 무관
        // 단점 : 최단경로를 보장하지 않음
        // 일반적으로 트리에 사용을 선호

        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            int size = graph.GetLength(0); //정점의 갯수
            visited = new bool[size];
            parents = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            //함수 호출 스택을 쓰는 방법
            SearchNode(graph, start, visited, parents);
        }
        public static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parents)
        {
            int size = graph.GetLength(0);
            visited[vertex] = true;

            for (int i = 0; i < size; i++)
            {
                if (graph[vertex, i] == true &&   //연결이 되어 있는 정점 찾고자하는정점에서 i와 연결 돼 있으면??? 시작정점에서 도착정점까지 연결여부
                    visited[i] == false)          // 방문한 적 없는 정점
                {
                    parents[i] = vertex;
                    SearchNode(graph,i,visited,parents);
                }
            }
        }
        #endregion


        #region <BFS - Breadth First Search>
        //Queue
        //그래프의 분기를 만났을 때 분기들을 탐색한 뒤, 다음 깊이의 분기들을 탐색
        //장점 : 최단 경로를 보장
        //단점 : 지금 탑색 상황에서 필요하지 않은 정점 데이터도 큐에 보관할 필요가 있다.
        // 일반적으로 그래프에 사용을 선호

        //public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        //{
        //    int size = graph.GetLength(0);
        //    visited = new bool[size];
        //    parents = new int[size];
        //
        //    for (int i = 0; i < size; i++)
        //    {
        //        visited[i] = false;
        //        parents[i] = -1;
        //    }
        //
        //    Queue<int> queue = new Queue<int>();
        //    queue.Enqueue(start);
        //    visited[start] = true;
        //
        //    while (queue.Count > 0)
        //    {
        //        큐에서 다음으로 탐색할 정점을 확인한다;
        //
        //        다음으로 탐색할 정점을 기준으로 탐색할 수 있는 정점들을 큐에 담는다.;
        //        for (정점들을 반복하며)
        //        {
        //
        //            if (연결되어 있으면서 && 이미 찾은 정점이 아닐때)
        //            {
        //                큐에 탐색할 수 있는 정점을 추가한다;
        //                탐색할 수 있는 정점을 방문 표시;
        //                탐색할 수 있는 정점의 이전 정점을 표시한다;
        //            }
        //        }
        //    }
        //}

        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            int size = graph.GetLength(0); //정점의 갯수
            visited = new bool[size];
            parents = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int next = queue.Dequeue();

                for (int vertex = 0; vertex < size; vertex++)
                {
                    if (graph[next, vertex] == true && // 연결이 되어 있는 정점이면서
                        visited[vertex] == false)      // 방문한적 없는 정점인경우
                    {
                        queue.Enqueue(vertex);
                        visited[vertex] = true;
                        parents[vertex] = next;
                    }
                }
            }
        }
        #endregion


        #region <다익스트라 알고리즘 -최단경로>
        //특정한 노드에서 출발하여 다른 노드까지 가는 각각의 최단 경로를 구하는 알고리즘
        //1. 방문하지 않은 노드 중에서 가장 가까운 노드를 선택한후,
        //   선택한 노드를 거쳐서 더 짧아지는 경로가 있는 경우 대체

        const int INF = 9999;
        public static void Dijkstra(int[,] graph, int start, out bool[] visited,
            out int[] parents, out int[] cost)
        {
            int size = graph.GetLength(0);
            visited = new bool[size];
            parents = new int[size];
            cost = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                parents[i] = -1;
                cost[i] = INF; //graph[start,i]해도됨
            }

            cost[start] = 0;

            for (int i = 0; i < size; i++)
            {
                int minIndex = -1; //최소값 설정
                int minCost = INF; //최소값 설정

                //1. 방문하지 않은 정점 중 가장 가까운 정점 선택
                for (int j = 0; j < size; j++)
                {
                    if (visited[j] == false &&  //방문한 적 없으며
                        cost[j] < minCost)      //가장 가까운 정점
                    {
                        minIndex = j;
                        minCost = cost[j];
                    }
                }
                if (minIndex < 0) break; //방문한경우가 없으면

                visited[minIndex] = true;

                // 2. 직접 연결된 거리보다 거쳐서 더 짧아지면 대체
                for (int j = 0; j < size; j++)
                {
                    //cost[j] : 목적지까지 직접 연결 된 거리         (AB)
                    //cost[minIndex] : 중간점까지의 거리            (AC)
                    //graph[minIndex,j] : 중간점부터 목적지까지 거리 (CB)
                    //if (AB > AC + CB)
                    //{
                    //    AB = AC + CB;
                    //}
                    if (cost[j] > cost[minIndex] + graph[minIndex, j])
                    {
                        cost[j] = cost[minIndex] + graph[minIndex, j];
                        parents[j] = minIndex;
                    }
                }
            }
        }

        #endregion



        static void Main(string[] args)
        {
            bool[,] graph = new bool[8, 8];

            BFS(graph, 0, out bool[] visited, out int[] parents);
            Console.WriteLine($"{"Vertex",8}{"Visited",8}{"Parents",8}");
            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}{parents[i],8}");
            }

            //다익스트라
            int[,] dijkstra = new int[8, 8]
            {
                {  0,   6,   7,   2, INF, INF, INF, INF},
                {  6,   0,   8, INF, INF, INF,   2, INF},
                {  6,   8,   0, INF, INF,   2,   7, INF},
                {  2, INF, INF,   0, INF,   2, INF, INF},
                {INF, INF, INF, INF,   0, INF,   8, INF},
                {INF, INF,   2,   2, INF,   0,   1,   1},
                {INF,   2,   7, INF,   8,   1,   0,   4},
                {INF, INF, INF, INF, INF,   1,   4,   0}

            };

            Dijkstra(dijkstra, 0, out bool[] visited1, out int[] parents1, out int[] cost);
            Console.WriteLine($"{"Vertex",8}{"Visited",8}{"Parents",8}{"Costs",8}");
            for (int i = 0; i < visited1.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited1[i],8}{parents1[i],8}{cost[i],8}");
            }
        }
    }
}
