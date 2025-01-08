using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0416
    {
        #region Approach 2: Top Down Dynamic Programming - Memoization 09/05/2024 
        Dictionary<(int index, int curSum),bool> dic;
        public bool CanPartition(int[] nums)
        {
            dic = new Dictionary<(int index, int curSum), bool> ();
            int total = 0;
            foreach (int i in nums)
            {
                total += i;
            }
            if (total % 2 == 1) return false;
            return helper_2024_09_05(nums, 0, 0, total/2);
        }

        public bool helper_2024_09_05(int[] nums,int index,int curSum,int target)
        {
            if (curSum == target) return true;
            if (curSum > target) return false;
            if (index >= nums.Length) return false;

            if (dic.ContainsKey((index, curSum))) return dic[(index, curSum)];


            bool isValid = helper_2024_09_05(nums, index + 1, curSum, target) ||
                   helper_2024_09_05(nums, index + 1, curSum + nums[index], target);

             dic.Add((index, curSum), isValid);

            return isValid;

        }
        #endregion

        
    }
}
