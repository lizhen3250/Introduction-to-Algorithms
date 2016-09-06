using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter04
{
    public class SumOfMaximumArray
    {
        public static int MaximumSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = int.MinValue;
            for(int i = 0; i<nums.Length; i++)
            {
                if (sum > 0)
                    sum += nums[i];
                else
                    sum = nums[i];
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        private static int FindMaximumCrossingSubArray(int[] nums, int first, int end)
        {
            if (first == end)
                return nums[first];
            int mid = (first + end) / 2;
            int leftSum = int.MinValue;
            int rightSum = int.MinValue;
            int sum = 0;

            int maxPre = FindMaximumCrossingSubArray(nums, first, mid);
            int maxEnd = FindMaximumCrossingSubArray(nums, mid + 1, end);

            for(int i = mid; i >= first; i--)
            {
                sum += nums[i];
                if (leftSum < sum)
                    leftSum = sum;
            }

            sum = 0;

            for(int i = mid + 1; i<=end; i++)
            {
                sum += nums[i];
                if (rightSum < sum)
                    rightSum = sum;
            }

            sum = leftSum + rightSum;
            return Math.Max(sum, Math.Max(maxPre, maxEnd));
        }

        public static int DivideMaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            return FindMaximumCrossingSubArray(nums, 0, nums.Length - 1);
        }
    }
}
