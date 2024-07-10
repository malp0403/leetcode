using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0260
    {
        #region LeetCode Approach 2: Two bitmasks

        #endregion

        #region 07/08/2024
        public int[] SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    if (nums[i] != nums[i + 1])
                    {
                        result.Add(nums[i]);
                    }
                }
                else if (i == nums.Length - 1)
                {
                    if (nums[i] != nums[i - 1])
                    {
                        result.Add(nums[i]);
                    }
                }
                else
                {
                    if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                    {
                        result.Add(nums[i]);
                    }
                }
            }
            return result.ToArray();
        }
        #endregion

    }
}
