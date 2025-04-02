namespace Algorithm
{
    internal class Program
    {

        #region 선택 정렬
        //가장 낮은 값을 선택하여 정렬하는 방법




        #endregion

        #region 삽입 정렬
        //선택한 값을 순서에 맞게 삽입하여 정렬하는 방법

        #endregion

        #region <버블 정렬>
        //두개의 값을 비교하여 작은쪽이 왼쪽 큰쪽이 오른쪽으로 가는 방법

        //public void BubbleSort(int[] array)
        //{
        //    for (모든 배열을 돈다)
        //    {
        //        for (모든 배열을 돌면서 값을 비교)
        //        {
        //            if(배열인덱스보다 다음 인덱스의 배열값이 크면)
        //             { Swap(); }
        //        }
        //    }
        //}

        //public static void BubbleSort(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length-1; j++)
        //        {
        //            if (array[j] >= array[j+1])
        //            {
        //                Swap(array, j, j + 1);
        //            }
        //        }
        //    }
        //}



        #endregion

        #region <병합 정렬>
        //값들을 두개씩 뗴어내서 정렬하고, 정렬한 값들을 또 모아서 왼,오른쪽 으로 정렬한다
        //이때 왼쪽 오른쪽 둘중에 하나의 값들이 다 정렬에 들어갔다면 자동으로 할당하여 정렬된다.
        //public static void MergeSort(int[] array) => MergeSort(array, 0, array.Length - 1);

        
        public static void MergeSort(int[] array, int start, int end)
        {
            if (start == end) return;

            int mid = (start + end) / 2;
            MergeSort(array, start, mid);
            MergeSort(array, mid + 1, end);
            Merge(array, start, mid, end);
        }

        public static void Merge(int[] array, int start, int mid, int end)
        {
            List<int> mergeList = new List<int>();

            int left = start;
            int right = mid + 1;

            while (left <= mid && right <=end)
            {
                if (array[left] < array[right])
                {
                    mergeList.Add(array[left]);
                    left++;
                }
                else
                {
                    mergeList.Add(array[right]);
                    right++;
                }
            }

            if (left <= mid)
            {
                for (int i = left; i <= mid; i++)
                {
                    mergeList.Add(array[i]);
                }
            }
            else
            {
                for (int i = right; i <= end; i++)
                {
                    mergeList.Add(array[i]);
                }
            }

            for (int i = 0; i < mergeList.Count; i++)
            {
                array[start + 1] = mergeList[i];
            }
        }


        #endregion

        #region <퀵 정렬>
        //기준을 선정하고 왼쪽,오른쪽 시작점을 생성한다. 왼쪽은 +, 오른쪽은 - 방향으로 진행하면서 
        //왼쪽은 기준값보다 클경우 멈추고 오른쪽은 기준 값보다 작을경우 멈춰서 진행,
        //만약 오른쪽이 왼쪽점을 넘어갈 시 기준점과 해당 오른쪽같은 바꿔준다. 그 후 기준점 변경후 다시 시작


        #endregion
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 2, 7, 1, 9, 2, 8, 5, 3 ,22,10 };

            //SelectSort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i],3}");
            //}
            //Console.WriteLine();

            //BubbleSort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i],5}");
            //}
            //Console.WriteLine();

            MergeSort(array,0,array.Length-1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],5}");
            }
            Console.WriteLine();
        }

        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}

