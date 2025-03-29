namespace Stack_Queue
{
    internal class Program
    {
        #region stack
        //Stack UI에 자주사용
        //설정 -> 사운드 -> 배경사운드
        //미로찾기 출발위치 -> A -> A-1 -> A -> 출발위치 ->
        //         B -> B-1 -> B-2

        //class MyStack<T>
        //{
        //    private List<T> list = new List<T>();
        //
        //    public int Count => list.Count;
        //
        //    public void Push(T item)
        //    {
        //        list.Add(item);
        //    }
        //
        //    public T Pop()
        //    {
        //        T result = list[list.Count - 1];
        //        list.RemoveAt(list.Count - 1);
        //        return result;
        //    }
        //
        //    public T Peek()
        //    {
        //        T result = list[list.Count - 1];
        //        return result;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //MyStack<int> stack = new MyStack<int>();

        //추가 : O(1),
        //최악(용량이 가득 찼을때) O(n)
        //-> 이유 : 더 큰배열을 넣을경우 새로운 배열을
        //만들어 이전의 데이터 복사하여 다시 넣음
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);

        //빼기 : O(1)
        //stack.Pop();
        //보기 : O(1)
        //stack.Peek();

        //세기 : O(n)
        //stack.Count(); ?????

        //Stack<int> stack = new Stack<int>();
        //stack.Push(1); //추가
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);
        //stack.Push(5);
        //
        //stack.Pop(); //꺼내기
        //stack.Pop();
        //
        //stack.Peek(); //확인
        //
        //stack.Count(); //남은 갯수
        //
        ////스택은 없으면 오류
        //stack.TryPop(out int pop); //있으면 pop 없으면 0
        //stack.TryPeek(out int peek); //있으면 peek 없으면 0


        //}
        #endregion

        //Queue - 선입선출
        //먼저 들어온 순서대로 처리


        public static void Main()
        {
            //Queue<int> queue = new Queue<int>();
            //
            ////추가 : O(1) 최악 O(n)
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //
            ////꺼내기 : O(1)
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //
            //Console.WriteLine(queue.Peek());

        }
    }
}
