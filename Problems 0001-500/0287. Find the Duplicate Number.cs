using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0287
    {
        #region Solution
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    return nums[i];
                }
                seen.Add(nums[i]);
            }
            return 0;
        }
        //************Solution 2********************
        public int FindDuplicate_R2(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, nums.Length + 1).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[i] == 1) return arr[i];
                arr[i]++;
            }
            return -1;
        }
        #endregion

        #region 09/04/2023

        public int FindDuplicate_20230904(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] < 0)
                {
                    return Math.Abs(nums[i]);
                }
                nums[index] = -nums[index];
            }

            return 0;
        }


        #endregion

        #region 07/15/2024 catch it if it is negative value
        public int FindDuplicate_2024_07_15(int[] nums)
        {
           
            for(int i =0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0) return Math.Abs(nums[i]);
                nums[index] = -nums[index];
            }
            return 0;
           
        }

        #endregion
    }
}
