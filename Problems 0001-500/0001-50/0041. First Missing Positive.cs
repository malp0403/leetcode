using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0041
    {
        #region exceed o(n)
        public int FirstMissingPositive(int[] nums)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
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
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    isOneFound = true;
                }
                if(nums[i] <=0 || nums[i] > nums.Length)
                {
                    nums[i] = 1;
                }
            }
            if (!isOneFound) return 1;

            for(int i =0; i < nums.Length; i++)
            {
                if(Math.Abs(nums[i]) == nums.Length)
                {
                    if (nums[0] > 0) nums[0] = -nums[0];
                }
                else
                {
                    nums[Math.Abs(nums[i])] = -Math.Abs(nums[Math.Abs(nums[i])]); 
                }
            }
            for(int i =1; i < nums.Length; i++)
            {
                if (nums[i] > 0) return i;
            }
            if (nums[0] < 0) return nums.Length+1;
            else return nums.Length;
        }
        #endregion
    }
}
