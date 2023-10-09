using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0805
    {
        #region 09/18/2023
        HashSet<int> set = new HashSet<int>();
        public bool SplitArraySameAverage(int[] nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += n;
            }
            int average = sum / nums.Length;
            int remain = sum % nums.Length;

            return helper(nums, 0, 0, average, remain);



        }
        
        public bool helper(int[] nums, int curCount,float curSum,int average,int remain)
        {
            if (curCount != 0 && curSum / curCount == average && curSum % curCount == remain) {
                return true;
            }

            bool valid = false;
            for(int i =0; i < nums.Length; i++)
            {
                if (!set.Contains(i) && set.Count < nums.Length-1)
                {
                    set.Add(i);
                    valid = valid || helper(nums, curCount + 1, curSum + nums[i], average,remain);
                    set.Remove(i);

                }
            }

            return valid;
        }
        
        #endregion
    }
}
