using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Question
/*
 You are given an inclusive range [lower, upper] and a sorted unique integer array nums, where all elements are within the inclusive range.

A number x is considered missing if x is in the range [lower, upper] and x is not in nums.

Return the shortest sorted list of ranges that exactly covers all the missing numbers. That is, no element of nums is included in any of the ranges, and each missing number is covered by one of the ranges.

 

 

Example 1:

Input: nums = [0,1,3,50,75], lower = 0, upper = 99
Output: [[2,2],[4,49],[51,74],[76,99]]
Explanation: The ranges are:
[2,2]
[4,49]
[51,74]
[76,99]
Example 2:

Input: nums = [-1], lower = -1, upper = -1
Output: []
Explanation: There are no missing ranges since there are no missing numbers.
 

Constraints:

-109 <= lower <= upper <= 109
0 <= nums.length <= 100
lower <= nums[i] <= upper
All the values of nums are unique.
 */
#endregion

namespace leetcode.Problems
{
    class _0163
    {
        #region Solution
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            IList<string> list = new List<string>() { };
            int pre = lower - 1;
            for (int i = 0; i <= nums.Length; i++)
            {
                int cur = i < nums.Length ? nums[i] - 1 : upper;
                if (pre + 1 <= cur - 1)
                {
                    list.Add(formatRange(pre + 1, cur - 1));
                }
                pre = cur;
            }
            return list;
        }
        private string formatRange(int lo, int up)
        {
            if (lo == up) return lo.ToString();
            return lo + "->" + up;
        }
        #endregion

        #region 12/30/2021
        //----------------12-30-2021----------------
        public IList<string> FindMissingRanges_R2(int[] nums, int lower, int upper)
        {
            IList<string> answer = new List<string>() { };

            int[] extendNums = Enumerable.Repeat(0, nums.Length + 2).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                extendNums[i + 1] = nums[i];
            }
            extendNums[0] = lower - 1;
            extendNums[extendNums.Length - 1] = upper + 1;

            for (int i = 1; i < extendNums.Length; i++)
            {
                if (extendNums[i] - extendNums[i - 1] == 2)
                {
                    answer.Add(formatRange(extendNums[i - 1] + 1, extendNums[i - 1] + 1));
                    ;
                }
                else if (extendNums[i] - extendNums[i - 1] > 2)
                {
                    answer.Add(formatRange(extendNums[i - 1] + 1, extendNums[i] - 1));
                }
            }
            return answer;
        }

        #endregion
        #region Solution
        public IList<string> FindMissingRanges_R3(int[] nums, int lower, int upper)
        {
            IList<string> answer = new List<string>() { };
            int prev = lower - 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int curr = i < nums.Length ? nums[i] : upper + 1;
                if (curr - prev >= 2)
                {
                    answer.Add(formatRange(prev + 1, curr - 1));
                }

                prev = curr;

            }
            return answer;
        }
        #endregion

        #region 03/31/2024
        public IList<IList<int>> FindMissingRanges_2024_03_31(int[] nums, int lower, int upper)
        {
            if(nums.Length==0) return new List<IList<int>>() { new List<int>() { lower,upper} };
            IList < IList<int> > res = new List<IList<int>>();

            if (nums[0] > lower)
            {
                res.Add(new List<int>() { lower, nums[0] - 1 });
            }

            for(int i =1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    res.Add(new List<int>() { nums[i - 1] + 1, nums[i] - 1 });
                }
            }

            if (nums[nums.Length-1] < upper)
            {
                res.Add(new List<int>() { nums[nums.Length - 1] + 1, upper });
            }


            return res;
        }
        #endregion

    }
}
