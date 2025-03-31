namespace _250331_Graph_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[8, 8];

            graph[0, 1] = GraphWeight(3);
            graph[0, 2] = GraphWeight(4);

            graph[1, 3] = GraphWeight(1);
            graph[1, 5] = GraphWeight(5);

            graph[2, 4] = GraphWeight(2);
            graph[2, 6] = GraphWeight(6);

            graph[3, 5] = GraphWeight(4);
            graph[3, 6] = GraphWeight(2);

            graph[4, 6] = GraphWeight(3);

            graph[5, 1] = GraphWeight(6);
            graph[5, 6] = GraphWeight(1);
            graph[5, 7] = GraphWeight(-1);

            graph[7, 4] = GraphWeight(4);

            Console.WriteLine("---------------가중치 그래프----------");
            Console.WriteLine($"0노드 : 1노드, 가중치 {graph[0, 1]} - 2노드, 가중치 {graph[0, 2]}");
            Console.WriteLine($"1노드 : 3노드, 가중치 {graph[1, 3]} - 5노드, 가중치 {graph[1, 5]}");
            Console.WriteLine($"2노드 : 4노드, 가중치 {graph[2, 4]} - 6노드, 가중치 {graph[2, 6]}");
            Console.WriteLine($"3노드 : 5노드, 가중치 {graph[3, 5]} - 6노드, 가중치 {graph[3, 6]}");
            Console.WriteLine($"4노드 : 6노드, 가중치 {graph[4, 6]}");
            Console.WriteLine($"5노드 : 1노드, 가중치 {graph[5, 1]} - 6노드, 가중치 {graph[5, 6]}- 7노드, 가중치 {graph[5, 7]}");
            Console.WriteLine($"5노드 : 4노드, 가중치 {graph[7, 4]}");
        }
            public static int GraphWeight(int weight)
            {
            const int INF = int.MaxValue;
            if (weight >= 0)
            {
                return weight;
            }
            else
            {
                return INF;
            }
        }

        //public class GraphNode<T>
        //{
        //    private T vertex;
        //    public T Vertex { get { return vertex; } set { vertex = value; } }
        //
        //    private List<GraphNode<T>> edges = new List<GraphNode<T>>();
        //
        //    public GraphNode(T vertex)
        //    {
        //        this.vertex = vertex;
        //    }
        //    
        //
        //    public void AddEdge(GraphNode<T> node)
        //    {
        //        edges.Add(node);
        //    }
        //
        //    public void RemoveEdge(GraphNode<T> node)
        //    {
        //        edges.Remove(node);
        //    }
        //
        //    public bool IsConnect(GraphNode<T> node)
        //    {
        //        return edges.Contains(node);
        //    }
        //}

        
    }
}
