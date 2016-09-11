using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter07
{
    public class QuickSort
    {
        public static int Partition(int[] nums, int start, int end)
        {
            int i = start - 1;
            for(int j = start; j < end; j++)
            {
                if (nums[j] < nums[end])
                {
                    i++;
                    Swap(ref nums[i], ref nums[j]);
                }
            }
            Swap(ref nums[i + 1], ref nums[end]);
            return i + 1;
        }

        public static void Sort(int[] nums, int start, int end)
        {
            if(start < end)
            {
                int mid = Partition(nums, start, end);
                Sort(nums, start, mid - 1);
                Sort(nums, mid + 1, end);
            }
        }

        private static void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
