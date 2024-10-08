using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0539
    {
        #region LeetCode Approach 1: Sort; convert to mins

        #endregion

        #region LeetCode Approach 2: Bucket Sort; 24*60 buckets

        #endregion

        #region 10/06/2024
        public int FindMinDifference_2024_10_06(IList<string> timePoints)
        {
            List<int> result = new List<int>();
            for(int i =0; i< timePoints.Count; i++)
            {
                string[] part = timePoints[i].Split(":");
                int sum = int.Parse(part[0])*60 + int.Parse(part[1]);
                result.Add(sum);
            }
            result.Sort();
            int ans = int.MaxValue;
            for(int i =0; i < result.Count-1;i++)
            {
                ans = Math.Min(ans, result[i+1] - result[i]);
            }

            return Math.Min(ans, 24 * 60 - result[result.Count - 1] + result[0]);
        }
        #endregion














    }
}
