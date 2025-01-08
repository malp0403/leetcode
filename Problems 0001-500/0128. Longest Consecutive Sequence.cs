using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0128
    {
        #region LeetCode Approach 3: HashSet and Intelligent Sequence Building
        public int LongestConsecutive_app3(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    int count = 0;
                    int start = nums[i];
                    while (set.Contains(start))
                    {
                        count++;
                        start++;
                    }
                    max = Math.Max(max, count);
                }
            }
            return max;
        }
        #endregion

        #region answer
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            Array.Sort(nums);
            int prev = nums[0];
            int max = 1;
            int count = 1;
            for(int i=1; i < nums.Length; i++)
            {
                if (nums[i] == prev) continue;
                if(nums[i] == prev + 1)
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 1;
                }
                prev = nums[i];
            }
            max = Math.Max(max, count);

            return max;
        }
        #endregion

        #region 08/17/2022
        public int LongestConsecutive_20220817(int[] nums)
        {
            HashSet<int> set = new HashSet<int>() { };
            foreach (var num in nums)
            {
                set.Add(num);
            }
            int max = 0;
            foreach (var num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int cur = num;
                    int count = 1;
                    while (set.Contains(cur + 1))
                    {
                        count++;
                        cur++;
                    }
                    max = Math.Max(max, count);
                }
            }
            return max;
        }

        #endregion

        #region 03/25/2024
        public int LongestConsecutive_2024_03_25(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    int count = 0;
                    int start = nums[i];
                    while (set.Contains(start))
                    {
                        count++;
                        start++;
                    }
                    max = Math.Max(max, count);
                }
            }
            return max;
        }
        #endregion
    }
}
