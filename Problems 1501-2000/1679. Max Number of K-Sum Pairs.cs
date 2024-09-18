using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1679
    {
        #region Approach 4: Two Pointer Approach Using Sort 09/16/2024

        public int MaxOperations_app4(int[] nums, int k)
        {
            Array.Sort(nums);

            int l = 0;
            int r = nums.Length - 1;
            int count = 0;
            while(l < r)
            {
                if (nums[l] + nums[r] == k)
                {
                    l++;
                    r--;
                    count++;
                }
                else if (nums[l] + nums[r] < k)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return count;
        }
        #endregion
    }
}
