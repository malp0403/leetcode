using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0217
    {
        #region Solution
        public bool ContainsDuplicate__(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])) return true;
                else dic.Add(nums[i], 0);
            }
            return false;
        }
        #endregion

        #region 12/16/2021
        //----------------12/16/2021---------
        public bool ContainsDuplicate_R2(int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {

                if (d.ContainsKey(nums[i])) return true;
                d.Add(nums[i], 1);
            }
            return false;
        }
        #endregion

        #region 08/14/2023
        public bool ContainsDuplicate_230230814(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>() { };
            for(int i =0; i < nums.Length;i++)
            {
                if (seen.Contains(nums[i])) return true;
                seen.Add(nums[i]);
            }
            return false;
        }
        #endregion

    }
}
