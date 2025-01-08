using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Test Data
//var obj = new _0041();
//var answer = obj.FirstMissingPositive_20230725(new int[] { 3, 4, -1, 1 });
#endregion

namespace leetcode.Problems
{
    class _0041
    {
        #region exceed o(n)
        public int FirstMissingPositive(int[] nums)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    if (dic.ContainsKey(nums[i])) { continue; }
                    else { dic.Add(nums[i], 1); }
                }
            }
            int k = dic.FirstOrDefault().Key;
            int count = 1;
            while (dic.ContainsKey(count))
            {
                count++;
            }
            return count;
        }
        #endregion

        #region answer
        public int FirstMissingPositive_v2(int[] nums)
        {
            bool isOneFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    isOneFound = true;
                }
                if (nums[i] <= 0 || nums[i] > nums.Length)
                {
                    nums[i] = 1;
                }
            }
            if (!isOneFound) return 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) == nums.Length)
                {
                    if (nums[0] > 0) nums[0] = -nums[0];
                }
                else
                {
                    nums[Math.Abs(nums[i])] = -Math.Abs(nums[Math.Abs(nums[i])]);
                }
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0) return i;
            }
            if (nums[0] < 0) return nums.Length + 1;
            else return nums.Length;
        }
        #endregion

        #region 07/25/2023 Attempt
        public int FirstMissingPositive_20230725(int[] nums)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] <= 0 || nums[i] > len)
                {
                    nums[i] = len + 1;
                }
            }

            for (int i = 0; i < len; i++)
            {
                int val = Math.Abs(nums[i]);
                if (val != (len + 1))
                {
                    nums[val - 1] = -Math.Abs(nums[val - 1]);
                }
            }
            for (int i = 0; i < len; i++)
            {
                if (nums[i] >= 0)
                {
                    return i + 1;

                }
            }
            return len + 1;

        }
        #endregion

        #region 02/19/2024
        public int FirstMissingPositive_2024_02_19(int[] nums)
        {
            int max = nums.Length + 1;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] <= 0 || nums[i] >= max ) nums[i] = max;
            }

            for(int i =0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]);
                if(index != max)
                {
                    nums[index-1] = -Math.Abs(nums[index-1]);
                }
            }

            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] > 0) return i + 1;
            }

            return max;
            
        }
        #endregion
    }
}
