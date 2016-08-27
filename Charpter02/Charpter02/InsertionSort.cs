using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter02
{
    public class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        public static int[] DescendingSort(int[] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >=0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        public static int LinserSearch(int[] arr, int value)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == value)
                    return arr[i];
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int value)
        {
            int[] sortedArray = Sort(arr);
            int start = 0;
            int end = arr.Length - 1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == value)
                    return arr[mid];
                else if (arr[mid] > value)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }

        public static int BinarySearchRecursion(int[] arr, int start, int end, int value)
        {
            if (start > end)
                return -1;
            int mid = start + (end - start) / 2;

            if (arr[mid] == value)
                return arr[mid];
            else if (arr[mid] > value)
                return BinarySearchRecursion(arr, start, mid - 1, value);
            else
                return BinarySearchRecursion(arr, mid + 1, end, value);
        }
    }
}
