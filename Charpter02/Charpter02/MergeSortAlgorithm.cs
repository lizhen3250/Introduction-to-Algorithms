using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter02
{
    public class MergeSortAlgorithm
    {
        public static void Merge(int[] unsorted, int left, int right)
        {
            if (left + 1 < right)
            {
                int mid = (left + right) / 2;
                Merge(unsorted, left, mid);
                Merge(unsorted, mid, left);
                Sort(unsorted, left, mid, right);
            }
        }
        private static void Sort(int[] unsorted, int left, int mid, int right)
        {
            int indexA = left;
            int indexB = mid;
            int tempIndex = 0;
            int[] temp = new int[right];
            while (indexA < mid && indexB < right)
            {
                if (unsorted[indexA] < unsorted[indexB])
                    temp[tempIndex++] = unsorted[indexA++];
                else
                    temp[tempIndex++] = unsorted[indexB++];
            }

            while (indexA < mid)
                temp[tempIndex++] = unsorted[indexA++];
            while (indexB < right)
                temp[tempIndex++] = unsorted[indexB++];

            for (int i = 0; i < tempIndex; i++)
                unsorted[i + left] = temp[i];
        }
    }
}
