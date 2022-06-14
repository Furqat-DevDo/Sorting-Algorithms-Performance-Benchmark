using BenchmarkDotNet.Attributes;


namespace BenchmarkTest
{
 
    public class TestingSortAlgorithms
    {
        public void BubbleSort(int[] input)
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }
 
        public void insertionSort(int[] input)
        {
            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;
                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }
                input[currentIndex] = item;

            }
        }


        public  void SelectionSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
        }


         public void MergeMethod(int[] numbers, int left, int mid, int right)
         {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {

                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
         }
         public void SortMethod(int[] numbers, int left, int right)
         {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
         }


        public  void heapsort(int[] Array)
        {
            int n = Array.Length;
            int temp;
            for (int i = n / 2; i >= 0; i--)
            {
                heapify(Array, n - 1, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                
                temp = Array[i];
                Array[i] = Array[0];
                Array[0] = temp;
                
                heapify(Array, i - 1, 0);
            }
        }
       
         void heapify(int[] Array, int n, int i)
         {
            int max = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            
            if (left <= n && Array[left] > Array[max])
            {
                max = left;
            }
            
            if (right <= n && Array[right] > Array[max])
            {
                max = right;
            }
           
            if (max != i)
            {
                int temp = Array[i];
                Array[i] = Array[max];
                Array[max] = temp;
              
                heapify(Array, n, max);
            }
         }

        public  void quicksort(int[] arr, int begin, int end)
        {
            int pivot = arr[(begin + (end - begin) / 2)];
            int left = begin;
            int right = end;
            while (left <= right)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            if (begin < right)
            {
                quicksort(arr, begin, left - 1);
            }
            if (end > left)
            {
                quicksort(arr, right + 1, end);
            }
        }
         void swap(int[] items, int x, int y)
         {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
         }

        
    }
}
