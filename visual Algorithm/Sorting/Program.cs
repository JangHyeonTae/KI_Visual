namespace Sorting
{
    internal class Program
    {
        #region <선택정렬>
        //데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
        //시간복잡도 - O(n^2)
        //공간복잡도 - O(1)
        //불안정정렬

        public static void SelectionSort(int[] array)
        {
            //for (처음부터 끝까지 쭉 훑기)
            //{
            //    가장 낮은 수 찾기;
            //
            //    앞에 교체 해주기;
            //}
        
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
        
                Swap(array,i,minIndex);
            }
        }

        #endregion

        #region <삽입정렬>
        //데이터를 하나씩 꺼내어 정렬된 자료ㅈ중 적합한 위치에 삽입하여 정렬
        // 시간복잡도 -  O(n²)
        // 공간복잡도 -  O(1)
        // 안정정렬

        //public static void InsertionSort(int[] array)
        //{
        //    
        //    for(처음부터 끝까지 반복)
        //    {
        //        for (적합한 위치에 들어갈떄까지 반복)
        //        {
        //            다음 숫자를 하나씩 꺼내서;
        //            앞 숫자와 비교해서 더 작으면 한칸 뒤로 밀고;
        //            작지 않으면 그자리에 넣기;
        //        }
        //            
        //    }
        //}

        public static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        #region <버블정렬>
        //서로 인접한 데이터를 비교하여 정렬
        //시간복잡도 - O(n^2)
        //공간복잡도 - O(1)
        //안정정열

        //public static void BubbleSort(int[] array)
        //{
        //    for (처음부터 끝까지 반복)
        //    {
        //         for (하나씩 골라서하는 잡업을 반복)
        //         {
        //            if(서로 인접한 두 데이터를 비교해서 더 크면)
        //            {
        //
        //            }
        //         }
        //    }
        //}
        public static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        Swap(array, j, j+1);  
                    }
                }
            }
        }

        #endregion

        #region <병합정렬(합병정렬)> - 유저가 보기엔 좋음
        //데이터를 2분할하여 정렬 후 병합
        //시간복잡도 - O(nlogn)
        //공간복잡도 - O(n)
        //안정정렬

        public static void MergeSort(int[] array) => MergeSort(array, 0, array.Length-1);

        public static void MergeSort(int[] array, int start, int end)
        {
            //하나만 남았을떄 쪼개지않음
            if (start == end) return;

            int mid = (start + end) / 2;
            MergeSort(array, start, mid);
            MergeSort(array, mid + 1, end);
            Merge(array, start, mid, end);
        }

        //합치는과정
        //public static void Merge(int[] array, int start,int mid, int end)
        //{
        //    List<int> sortedList = new List<int>();
        //    int leftIndex = start;
        //    int rightIndex = mid + 1;
        //
        //    while(한쪽이 모두 소진될 때까지)
        //    {
        //        if(왼쪽이 작으면)
        //        {
        //            왼쪽 값 정렬된 리스트에 집어넣기;
        //        }
        //        else
        //        {
        //            오른쪽 값 정렬된 리스트에 집어넣기;
        //        }
        //    }
        //    if(왼쪽이 남아있으면)
        //    {
        //     왼쪽 나머지들 모두 정렬된 리스트에 추가;
        //    }
        //    else(왼쪽이 남아있으면)
        //    {
        //     오른쪽 나머지들 모두 정렬된 리스트에 추가;
        //    }
        //}

        public static void Merge(int[] array, int start, int mid, int end)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;

            while(leftIndex <= mid && rightIndex <= end)
            {
                if (array[leftIndex] < array[rightIndex])
                {
                    sortedList.Add(array[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sortedList.Add(array[rightIndex]);
                    rightIndex++;
                }
            }

            if (leftIndex <= mid)
            {
                for (int i = leftIndex; i <= mid; i++)
                {
                    sortedList.Add(array[i]);
                }
            }
            else
            {
                while (rightIndex <= end)                       //for, while상관없음
                {                                               //for, while상관없음
                    sortedList.Add(array[rightIndex]);          //for, while상관없음
                    rightIndex++;                               //for, while상관없음
                }                                               //for, while상관없음
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                array[start + i] = sortedList[i];               //list -> array
            }
        }






        #endregion

        #region <퀵정렬> - 한번만 정렬하던지 유저에게 정렬보여줄 필요 없을때 and 속도 중요시
        //하나의 기준(피벗)으로 작은값과 큰값을 2분할하여 정렬
        //시간복잡도 - 평균 : O(nlogn) 최악 : O(n^2) - 역순에서 최악발생
        //공간복잡도 - O(1)
        //불안정정열
        public static void QuickSort(int[] array) => QuickSort(array,0,array.Length-1);

        public static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            
            int pivot = start;
            int left = pivot + 1;
            int right = end;

            while (left <= right)
            {
                while (array[pivot] >= array[left] && left < right)
                {
                    left++;
                }
                while (array[pivot] < array[right] && left <= right)
                {
                    right--;
                }

                if (left < right)
                {
                    Swap(array, left, right);
                }
                else
                {
                    Swap(array, pivot, right);
                    break;
                }
            }
            QuickSort(array, start, right - 1);
            QuickSort(array, right + 1, end);
        }

        //public static void QuickSort(int[] array, int start, int end)
        //{
        //    if (start >= end) return;
        //
        //    int pivot = start;
        //    int left = pivot + 1;
        //    int right = end;
        //
        //    while(left와 right가 교차할 떄까지 반복)
        //    {
        //        left는 pivot보다 더 큰 값을 볼떄까지 오른쪽으로 이동;
        //        right는 pivot보다 더 작은 값을 볼떄까지 왼쪽으로 이동;
        //        if(left와 right가 교차 안 했다면)
        //        {
        //            left와 right의 값을 교체;
        //        }
        //        else
        //        {
        //            pivot과 right를 교체;
        //        }
        //    }
        //}


        #endregion

        #region <힙정렬>
        //토너먼트구조 - 유니티에서 사용안함
        //시간복잡도 - O(nlign) -> 이론상 좋지만 캐시메모리에 적합하지 않기때문에
        //공간복잡도 - O(1)         c#에 적합한 정렬아님
        //불안정 정열
        #endregion

        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 20;

            int[] selectArray = new int[count];
            int[] insertArray = new int[count];
            int[] bubbleArray = new int[count];
            int[] mergeArray = new int[count];
            int[] quickArray = new int[count];

            Console.WriteLine("랜덤 데이터: ");
            for (int i = 0; i < count; i++)
            {
                int rand = random.Next(0, 100);
                Console.Write($"{rand,3}");

                selectArray[i] = rand;
                insertArray[i] = rand;
                bubbleArray[i] = rand;
                mergeArray[i] = rand;
                quickArray[i] = rand;
            }
            Console.WriteLine();
            Console.WriteLine();

            //선택정렬
            SelectionSort(selectArray);
            Console.WriteLine("선택 정렬 결과 : ");
            foreach (int value in selectArray)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            //삽입 정렬
            InsertionSort(insertArray);
            Console.WriteLine("삽입 정렬 결과: ");
            foreach (int value in insertArray)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            BubbleSort(bubbleArray);
            Console.WriteLine("버블 정렬 결과: ");
            foreach (int value in bubbleArray)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            MergeSort(mergeArray);
            Console.WriteLine("병합 정렬 결과: ");
            foreach (int value in mergeArray)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            QuickSort(quickArray);
            Console.WriteLine("퀵 정렬 결과: ");
            foreach (int value in quickArray)
            {
                Console.Write($"{value,3}");
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

