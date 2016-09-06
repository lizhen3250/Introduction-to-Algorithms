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
    }
}
