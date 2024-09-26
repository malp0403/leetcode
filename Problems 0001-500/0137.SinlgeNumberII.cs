using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0137
    {
        #region Solution
        public int SinlgeNumber_(int[] nums)
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
        public int SinlgeNumber_2024_03_26(int[] nums)
        {
            long sum = 0;
            long total = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!set.Contains(item))
                {
                    set.Add(item);
                    sum += item;
                }
                total += item;
            }

            return (int)((sum*3 - total )/ 2);

        }
        #endregion

    }
}
