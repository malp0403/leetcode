using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0016
    {
        #region answer
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int diff = int.MaxValue;
            for (int i = 0; i < nums.Length && diff != 0; i++)
            {
                int lo = i + 1;
                int high = nums.Length - 1;
                while (lo < high)
                {
                    int sum = nums[i] + nums[lo] + nums[high];
                    if (Math.Abs(sum - target) < Math.Abs(diff))
                    {
                        diff = target - sum;
                    }
                    if (sum < target)
                    {
                        lo++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }
            return target - diff;
        }
        #endregion

        #region 07/18/2022
        public int ThreeSumClosest_R1(int[] nums, int target)
        {
            Array.Sort(nums);
            int max = int.MaxValue;
            for(int i =0; i < nums.Length; i++)
            {
                int lo = i + 1;
                int high = nums.Length - 1;
                while (lo < high)
                {
                    int temp = nums[i] + nums[lo] + nums[high];
                    if (temp == target)
                    {
                        return target;
                    }
                    else if (temp < target)
                    {
                        lo++;
                    }
                    else
                    {
                        high--;
                    }
                    max = Math.Abs(temp - target) < Math.Abs(max-target) ? temp : max;
                }
            }
            return max;
        }
        #endregion
    }
}
