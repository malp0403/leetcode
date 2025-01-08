using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0327
    {
        #region 07/24/2024 TLE
        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            long[] sum= new long[nums.Length+1];
            int count = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum[i+1] = nums[i] + sum[i - 1];
            }

            for(int i=0;i < nums.Length; i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    long dif = sum[j] - nums[i];
                    if (dif >= (long)lower && dif <= (long)upper)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        #endregion
    }
}
