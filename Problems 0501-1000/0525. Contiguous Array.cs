using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0525
    {
        public int FindMaxLength(int[] nums)
        {
            int n = nums.Length;
            int[] arr = Enumerable.Repeat(-2, 2 * n + 1).ToArray();
            arr[n] = -1;
            int count = 0;
            int max = 0;
            for(int i =0; i < nums.Length; i++)
            {
                count = count + nums[i] == 0 ? -1 : 1;
                if(arr[count+n] >= -1) {
                    max = Math.Max(max, i - arr[count + n]);
                }
                else
                {
                    arr[count + n] = i;
                }
            }
            return max;
        }
    }
}
