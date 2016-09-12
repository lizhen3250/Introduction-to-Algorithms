using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter08
{
    public class RadixSort
    {
        public static void Sort(ref int[] arr)
        {
            List<int> sortedList = new List<int>();
            List<int>[] listArr = new List<int>[10];
            int maxLength = FindNumberOfDigit(arr);

            for (int i = 0; i < 10; i++)
                listArr[i] = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var number in arr)
                {
                    string currentNumber = SetCurrentNumber(number.ToString(), maxLength);
                    char currentDigit = currentNumber[currentNumber.Length - i - 1];
                    InsertNumberIntoListArray(currentDigit, listArr, number);
                }

                for (int j = 0; j < listArr.Length; j++)
                    foreach (var number in listArr[j].ToArray<int>())
                    {
                        sortedList.Add(number);
                        listArr[j].Clear();
                    }
                arr = sortedList.ToArray<int>();
                sortedList.Clear();
            }
        }

        private static void InsertNumberIntoListArray(char currentDigit, List<int>[] listArr, int number)
        {
            switch (currentDigit)
            {
                case '0':
                    listArr[0].Add(number);
                    break;
                case '1':
                    listArr[1].Add(number);
                    break;
                case '2':
                    listArr[2].Add(number);
                    break;
                case '3':
                    listArr[3].Add(number);
                    break;
                case '4':
                    listArr[4].Add(number);
                    break;
                case '5':
                    listArr[5].Add(number);
                    break;
                case '6':
                    listArr[6].Add(number);
                    break;
                case '7':
                    listArr[7].Add(number);
                    break;
                case '8':
                    listArr[8].Add(number);
                    break;
                case '9':
                    listArr[9].Add(number);
                    break;
            }
        }

        private static int FindNumberOfDigit(int[] arr)
        {
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max.ToString().Length;
        }

        private static string SetCurrentNumber(string currentNumber, int maxLength)
        {
            StringBuilder sb = new StringBuilder();

            if (currentNumber.Length < maxLength)
            {               
                for (int k = maxLength - currentNumber.Length; k >= 0; k--)
                {
                    sb.Append("0");
                }
                
            }

            sb.Append(currentNumber);
            return sb.ToString();
        }

    }
}
