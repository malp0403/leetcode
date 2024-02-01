using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0001
    {
        #region LeetCode Solution1: Brute Force
        // O(n^2)
        #endregion
        #region LeetCode Solution2: Two-pass Hash Table
        // time: O(n) space O(n) 
        #endregion
        #region LeetCode Solution2: One-pass Hash Table
        // time: O(n) space O(n) 
        #endregion


        #region answer
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>() { };
            Dictionary<int, int> d = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(target - nums[i]))
                {
                    return new int[] { d[target - nums[i]], i };
                }
                else
                {
                    set.Add(nums[i]);
                    if (!d.ContainsKey(nums[i]))
                    {
                        d.Add(nums[i], i);
                    }

                }
            }
            return null;
        }
        #endregion

        #region 07/10/2022
        public int[] Review_2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int left = target - nums[i];
                if (dic.ContainsKey(left))
                {
                    result[0] = dic[left];
                    result[1] = i;
                    break;
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);

                }
            }
            return result;



        }
        #endregion

        #region 12/27/2022
        public int[] TwoSum_20221227(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { dic[target - nums[i]], i };
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);

                }
            }
            return new int[] { };
        }
        #endregion

        #region 07/14/2023

        public int[] TwoSum_20230714(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            for (int i = 0; i < nums.Length; i++)
            {
                int remain = target - nums[i];
                if (dic.ContainsKey(remain))
                {
                    return new int[] { i, dic[remain] };

                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }


            return new int[] { 0, 0 };


        }
        #endregion

        #region 01/01/2024
        public int[] TwoSum_2024_01_01(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

           for(int i = 0; i < nums.Length; i++)
            {
                int val = target - nums[i];
                if (dic.ContainsKey(val))
                {
                    return new int[] { dic[val], i };
                }
                else
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic.Add(nums[i], i);
                    }
                }
            }
            return null;
            
        }
        #endregion
    }
}
