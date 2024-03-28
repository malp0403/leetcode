using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0136
    {

        #region LeetCode Approach 3: Math
        public int SingleNumber_Approach3(int[] nums)
        {
            int sum = 0;
            int total = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!set.Contains(num))
                {
                    set.Add(num);
                    sum += num;
                }
                total += num;
            }

            return sum * 2 - total;
        }
        #endregion

        #region Solution
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                {
                    return i;
                }
            }
            return nums.Length - 1;
        }
        #endregion

        #region 03/26/2024
        public int SingleNumber_2024_03_26(int[] nums)
        {
            int sum = 0;
            int total = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!set.Contains(num))
                {
                    set.Add(num);
                    sum += num;
                }
                total += num;
            }

            return sum * 2 - total;
        }
        #endregion

       

    }
}
