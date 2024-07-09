using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0259
    {
        #region 07/09/2024 Two Pointers
        public int ThreeSumSmaller(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            for(int i =0; i < nums.Length - 2; i++)
            {
                sum += helper_2024_07_09(i+1, nums, target - nums[i]);
            }

            return sum;
        }
        public int helper_2024_07_09(int start, int[] nums,int target)
        {
            if (nums[start] + nums[start + 1] >= target) return 0;

            int l = start;
            int r = nums.Length - 1;
            int sum = 0;
            while (l < r)
            {
                if (nums[l] + nums[r] < target)
                {
                    sum += r - l;
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return sum;
        }
        #endregion
    }
}
