using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter08
{
    public class CountingSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            int max = FindMaximumValue(arr);
            int[] countArray = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
                countArray[arr[i]]++;

            for (int i = 1; i < countArray.Length; i++)
                countArray[i] = countArray[i] + countArray[i - 1];

            for(int i = 0; i<arr.Length; i++)
            {
                sortedArray[countArray[arr[i]] - 1] = arr[i];
                countArray[arr[i]]--;
            }

            return sortedArray;
        }

        private static int FindMaximumValue(int[] arr)
        {
            int max = int.MinValue;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
