using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0410
    {
        #region Approach 3: Binary Search 09/05/2024
        public int SplitArray(int[] nums, int k)
        {
            int maxElement = 0;
            int totalSum = 0;
            foreach (int i in nums)
            {

                maxElement = Math.Max(maxElement, i);
                totalSum += i;
            }

            int left = maxElement;
            int right = totalSum;
            int minimumLargetSplitSum = 0;
            while(left <= right)
            {
                int maxAllowed = left + (right - left) / 2;

                if(helper_app3(nums,maxAllowed) <= k)
                {
                    right = maxAllowed - 1;
                    minimumLargetSplitSum = maxAllowed;
                }
                else
                {
                    left = maxAllowed + 1;
                }
            }

            return minimumLargetSplitSum;
        }

        public int helper_app3(int[] nums,int maxSumAllowed)
        {
            int curSum = 0;
            int splitRequired = 0;

            foreach (int i in nums) { 
            
                if(curSum + i <= maxSumAllowed)
                {
                    curSum += i;
                }
                else
                {
                    curSum = i;
                    splitRequired++;
                }
            }
            return splitRequired + 1;
        }
        #endregion
    }
}
