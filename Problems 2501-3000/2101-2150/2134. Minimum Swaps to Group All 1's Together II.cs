using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2101_2150
{
    internal class _2134
    {
        #region 10/8/2023 // sliding window; trick: nums+nums;
        public int MinSwaps(int[] nums)
        {
            int[] copy = new int[nums.Length * 2];
            int oneCount = 0;
            for (int i =0; i < copy.Length; i++)
            {
                copy[i] = nums[i % nums.Length];
                if(i <nums.Length && nums[i] == 1)
                {
                    oneCount++;
                }
            }

            int x = 0;
            int maxWindows = 0;
            for(int i =0; i < copy.Length; i++)
            {
                if (i >= oneCount && copy[i - oneCount] == 1) x--;
                if (copy[i] == 1) { x++; }
                maxWindows = Math.Max(x, maxWindows);
            }
            return oneCount - maxWindows;
            
        }
        #endregion
    }
}
