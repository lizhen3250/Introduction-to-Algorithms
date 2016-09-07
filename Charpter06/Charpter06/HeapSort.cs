using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter06
{
    public class HeapSort
    {
        public static void MaxHeapify(int[] nums, int i, int heapSize)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest = 0;

            if (left < heapSize && nums[left] > nums[i])
                largest = left;
            else
                largest = i;

            if (right < heapSize && nums[right] > nums[largest])
                largest = right;

            if(largest != i)
            {
                int temp = nums[i];
                nums[i] = nums[largest];
                nums[largest] = temp;
                MaxHeapify(nums, largest, heapSize);
            }
        }

        public static void BuildMaxHeap(int[] nums)
        {
            for (int i = nums.Length/2 - 1; i >= 0; i--)
                MaxHeapify(nums, i, nums.Length);
        }

        public static void Sort(int[] nums)
        {
            int heapSize = nums.Length;
            BuildMaxHeap(nums);
            for(int i = heapSize - 1; i>=1; i--)
            {
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
                heapSize--;
                MaxHeapify(nums, 0, i);
            }
        }
    }
}
