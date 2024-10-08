﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0046
    {
        #region answer
        IList<IList<int>> ans;
        public IList<IList<int>> Permute(int[] nums)
        {
            ans = new List<IList<int>>() { };
            backTracking(nums.Length, nums, 0);

            return ans;
        }

        public void backTracking(int length, int[] nums, int start)
        {
            if (start == length)
            {
                ans.Add(nums.ToList());
            }
            for (int i = start; i < nums.Length; i++)
            {
                int temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
                backTracking(length, nums, start + 1);
                temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
            }
        }
        #endregion

        #region 08/02/2022
        IList<IList<int>> result_20220802;
        HashSet<int> set;
        public IList<IList<int>> Permute_20220802(int[] nums)
        {
            result_20220802 = new List<IList<int>>() { };
            set = new HashSet<int>() { };
            helper_20220802_2(nums, new List<int>() { });

            return result_20220802;
        }
        public void helper_20220802(int length, int[] nums, int start)
        {
            if (start == length)
            {
                result_20220802.Add(nums.ToList());
                return;
            }
            for (int i = start; i < nums.Length; i++)
            {
                int temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
                helper_20220802(length, nums, start + 1);
                temp = nums[i];
                nums[i] = nums[start];
                nums[start] = temp;
            }
        }
        public void helper_20220802_2(int[] nums, List<int> list)
        {
            if (set.Count == nums.Length)
            {
                result_20220802.Add(list.Select(x => x).ToList());
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    set.Add(i);
                    list.Add(nums[i]);
                    helper_20220802_2(nums, list);
                    set.Remove(i);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        #endregion

        #region 02/24/2024 BackTracking
        IList<IList<int>> answer_2024_02_24;
        public IList<IList<int>> Permute_2024_02_24(int[] nums)
        {
            answer_2024_02_24 = new List<IList<int>>();
            helper_2024_02_24(nums, new HashSet<int>(), new List<int>());

            return answer_2024_02_24; 


        }
        public void helper_2024_02_24(int[] nums, HashSet<int> seen, List<int> curList)
        {
            if (seen.Count == nums.Length)
            {
                answer_2024_02_24.Add(new List<int>(curList));
                return;
            }

            for(int i =0; i < nums.Length; i++)
            {
                if (!seen.Contains(i))
                {
                    curList.Add(nums[i]);
                    seen.Add(i);
                    helper_2024_02_24(nums, seen, curList);
                    curList.RemoveAt(curList.Count - 1);
                    seen.Remove(i);

                }
            }
        }
        #endregion
    }
}
