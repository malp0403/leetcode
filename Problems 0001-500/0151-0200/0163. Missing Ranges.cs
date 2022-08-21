using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0163
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            IList<string> list = new List<string>() { };
            int pre = lower - 1;
            for(int i=0; i <= nums.Length; i++)
            {
                int cur = i < nums.Length ? nums[i] - 1 : upper;
                if(pre +1<= cur-1)
                {
                    list.Add(formatRange(pre + 1, cur - 1));
                }
                pre = cur;
            }
            return list;
        }
        private string formatRange(int lo,int up)
        {
            if (lo == up) return lo.ToString();
            return lo + "->" + up;
        }

        //----------------12-30-2021----------------
        public IList<string> FindMissingRanges_R2(int[] nums, int lower, int upper)
        {
            IList<string> answer = new List<string>() { };

            int[] extendNums = Enumerable.Repeat(0, nums.Length + 2).ToArray();
            for(int i = 0; i < nums.Length; i++)
            {
                extendNums[i + 1] = nums[i];
            }
            extendNums[0] = lower-1;
            extendNums[extendNums.Length - 1] = upper + 1;

            for(int i=1; i < extendNums.Length; i++)
            {
                if(extendNums[i] - extendNums[i-1] == 2)
                {
                    answer.Add(formatRange(extendNums[i - 1] + 1, extendNums[i - 1] + 1));
;                }else if(extendNums[i] - extendNums[i - 1] > 2)
                {
                    answer.Add(formatRange(extendNums[i - 1] + 1, extendNums[i] - 1));
                }
            }
            return answer;
        }

        public IList<string> FindMissingRanges_R3(int[] nums, int lower, int upper)
        {
            IList<string> answer = new List<string>() { };
            int prev = lower - 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int curr = i < nums.Length ? nums[i] : upper + 1;
                if(curr- prev >= 2)
                {
                    answer.Add(formatRange(prev + 1, curr-1));
                }

                prev=curr;

            }
            return answer;
        }
    }
}
