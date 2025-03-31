namespace Graph
{
    internal class Program
    {

        #region Graph기본
        //static void Main(string[] args)
        //{
        //    GraphNode<int> node0 = new GraphNode<int>(0);
        //    GraphNode<int> node1 = new GraphNode<int>(1);
        //    GraphNode<int> node2 = new GraphNode<int>(2);
        //    GraphNode<int> node3 = new GraphNode<int>(3);
        //    GraphNode<int> node4 = new GraphNode<int>(4);
        //    GraphNode<int> node5 = new GraphNode<int>(5);
        //    GraphNode<int> node6 = new GraphNode<int>(6);
        //    GraphNode<int> node7 = new GraphNode<int>(7);
        //
        //    node0.AddEdge(node3);
        //    node3.AddEdge(node0);
        //    node0.AddEdge(node4);
        //    node4.AddEdge(node0);
        //
        //}
        //
         public class GraphNode<T>
         {
             private T vertex;
             public T Vertex { get { return vertex; } set { vertex = value; } }
         
             private List<GraphNode<T>> edges = new List<GraphNode<T>>();
         
             public GraphNode(T vertex)
             {
                 this.vertex = vertex;
             }
         
             public void AddEdge(GraphNode<T> node)
             {
                 edges.Add(node);
             }
         
             public void RemoveEdge(GraphNode<T> node)
             {
                 //연결끊기
                 edges.Remove(node);
             }
         
             public bool IsConnect(GraphNode<T> node)
             {
                 return edges.Contains(node);
             }
         
         }
        #endregion

        public static void Main()
        {
            //그래프 간단하게 구성하는범
            //1. 인접행렬 그래프
            //그래프 내의 각 정점의 인접 관계를 나타내는 그래프
            //2차원 배열을 [출발정점, 도착정점]으로 표현
            //장점: 인접 여부가 빠름
            //단점: 메모리 사용량이 많음


            bool[,] graph = new bool[8, 8];

            bool connect = graph[0, 2]; //연결 여부
            graph[0, 3] = true; //연결 추가
            graph[3, 0] = true;
            graph[3, 0] = false; //연결 해제

            Console.WriteLine("0 - 3{0}", graph[0, 3]);

            const int INF = int.MaxValue;
            int[,] intGraph = new int[8, 8]; //가중치가 있는 그래프
            int distance = intGraph[0, 2];
            intGraph[0, 1] = 5;
            intGraph[0, 1] = INF;
            intGraph[1, 3] = 6;

            //2. 인접 리스트 그래프
            //그래프 내의 각 정점의 인접 관계를 표현하는 리스트
            //장점 : 메모리 사용량이 적음
            //단점 : 인접여부를 확인하기 위해 리스트 탐색이 필요

            List<int>[] listGraph = new List<int>[8];

            listGraph[0] = new List<int> { 2, 4 };
            listGraph[1] = new List<int> { 2, 3 };

            listGraph[2] = new List<int> { 0, 1, 4 };
            listGraph[3] = new List<int> { 1, 7 };
            listGraph[4] = new List<int> { 0, 2 };

            listGraph[0].Add(5); //연결추가
            listGraph[5].Add(0);

            listGraph[1].Remove(2); //연결 끊기
            listGraph[2].Remove(1);

            bool connect1 = listGraph[0].Contains(1); //포함여부
            #region 그래프정의
            //static void Main12(string[] args)
            //{
            //    /************************************************************************
            //     * 그래프 (Graph)
            //     * 
            //     * 정점의 모음과 이 정점을 잇는 간선의 모음의 결합
            //     * 한 노드에서 출발하여 다시 자기 자신의 노드로 돌아오는 순환구조를 가짐
            //     * 간선의 방향성에 따라 단방향 그래프, 양방향 그래프가 있음
            //     * 간선의 가중치에 따라   연결 그래프, 가중치 그래프가 있음
            //     ************************************************************************/
            //
            //    // <인접행렬 그래프>
            //    // 그래프 내의 각 정점의 인접 관계를 나타내는 행렬
            //    // 2차원 배열을 [출발정점, 도착정점] 으로 표현
            //    // 장점 : 인접여부 접근이 빠름
            //    // 단점 : 메모리 사용량이 많음
            //
            //    // 예시 - 양방향 연결 그래프
            //    bool[,] matrixGraph1 = new bool[5, 5]
            //    {
            //    { false, false,  true, false,  true },
            //    { false, false,  true, false, false },
            //    {  true,  true, false,  true, false },
            //    { false, false,  true, false,  true },
            //    {  true, false, false,  true, false },
            //    };
            //
            //
            //    const int INF = int.MaxValue;
            //    // 예시 - 단방향 가중치 그래프 (단절은 최대값으로 표현)
            //    int[,] matrixGraph2 = new int[5, 5]
            //    {
            //    {   0, 132, INF, INF,  16 },
            //    {  12,   0, INF, INF, INF },
            //    { INF,  38,   0, INF, INF },
            //    { INF,  12, INF,   0,  54 },
            //    { INF, INF, INF, INF,   0 },
            //    };
            //
            //    // [0, 2] => 출발정점(0) -> 도착정점(2)
            //    int distance = matrixGraph2[0, 2];  // 0에서 2까지 가중치
            //    matrixGraph2[0, 2] = 10;            // 가중치 변경
            //
            //
            //    // <인접리스트 그래프>
            //    // 그래프 내의 각 정점의 인접 관계를 표현하는 리스트
            //    // 인접한 간선만을 리스트에 추가하여 관리
            //    // 장점 : 메모리 사용량이 적음
            //    // 단점 : 인접여부를 확인하기 위해 리스트 탐색이 필요
            //
            //    List<int>[] listGraph = new List<int>[5];
            //
            //}
            #endregion
        }
    }
}




