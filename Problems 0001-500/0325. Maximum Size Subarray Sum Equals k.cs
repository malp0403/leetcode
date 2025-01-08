using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0325
    {
        #region Solution
        public int MaxSubArrayLen(int[] nums, int k)
        {
            int sum = 0;
            int max = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    max = i + 1;
                }
                if (dic.ContainsKey(k - sum))
                {
                    max = Math.Max(max, i - dic[k - sum]);
                }
                if (!dic.ContainsKey(sum))
                    dic.Add(sum, i);
            }
            return max;
        }
        #endregion

        #region 07/24/2024
        public int MaxSubArrayLen_2024_07_24(int[] nums, int k)
        {
            int sum = 0;
            int max = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(sum == k)
                {
                    max = Math.Max(i+1, max);
                }
                if (dic.ContainsKey(sum-k))
                {
                    max = Math.Max(i - dic[sum - k], max);
                }
                if (!dic.ContainsKey(sum))
                {
                    dic.Add(sum, i);
                }
            }
            return max;
        }

        #endregion
    }
}
