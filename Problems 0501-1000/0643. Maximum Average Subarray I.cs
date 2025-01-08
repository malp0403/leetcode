using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0643
    {
        #region solution
        public double FindMaxAverage(int[] nums, int k)
        {
            int l = 0; int r = 0;
            double sum = 0;
            double max = Int32.MinValue;
            while (r < nums.Length)
            {
                sum += nums[r];
                if ((r - l + 1) < k)
                {
                    r++; continue;
                }
                if (r - l + 1 > k)
                {
                    sum -= nums[l];
                    l++;
                }
                max = Math.Max(sum / (r - l + 1), max);
                r++;

            }
            return max;
        }
        #endregion

        #region 09/16/2024 
        public double FindMaxAverage_2024_09_16(int[] nums, int k)
        {
            int i = 0;
            int start = 0;

            double sum = 0;
            double max = Int64.MinValue;
            while(i < nums.Length)
            {
                sum += nums[i];

                if(( i - start +1)== k)
                {
                    max = Math.Max(max, sum);

                    sum -= nums[start];
                    start++;
                }

                i++;
            }

            return (double)max / k;
        }
        #endregion
    }
}
