using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0396
    {
        #region 09/04/2024 get nextSum based on previous Sum  
        public int MaxRotateFunction(int[] nums)
        {
            int sum = 0;
            int weight = 0;

            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
                weight += (nums[i] * (i));
            }
            int max = weight;

            for(int i = nums.Length - 1; i > 0; i--)
            {
                weight = weight + sum - nums[i] * (nums.Length);

                max = Math.Max(max, weight);
            }

            return max;
        }
        #endregion
    }
}
