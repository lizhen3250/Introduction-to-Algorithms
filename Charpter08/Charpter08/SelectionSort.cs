using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter08
{
    public class SelectionSort
    {
        public static void Sort(ref int[] arr)
        {
            int pos = int.MinValue;

            for(int i = 0; i<arr.Length; i++)
            {
                pos = i;
                for(int j = i +1; j<arr.Length; j++)
                {
                    if (arr[pos] > arr[j])
                        pos = j;
                }
                Swap(ref arr[i], ref arr[pos]);
            }
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
