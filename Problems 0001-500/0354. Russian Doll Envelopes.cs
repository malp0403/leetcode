using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0354
    {
        #region 08/31/2024
        public int MaxEnvelopes_2024_08_31(int[][] envelopes)
        {
            Array.Sort(envelopes, (a, b) =>
            {
                if (a[0] == b[0]) return b[1] - a[1];
                else return a[0] - b[0];
            });
            int[] nums = Enumerable.Repeat(0, envelopes.Length).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = envelopes[i][1];
            }

            List<int> list = new List<int>();
            list.Add(nums[0]);

            for(int i =1; i< nums.Length; i++)
            {
                int num = nums[i];
                if(num > list[list.Count - 1])
                {
                    list.Add(num);
                }
                else
                {
                    int j = 0;
                    // Find the first element in sub that is greater than or equal to num

                    while (num> list[j])
                    {
                        j++;
                    }
                    list[j] = num;
                }
            }
            return list.Count;





            int[] dp = Enumerable.Repeat(1,envelopes.Length).ToArray();

            int max = 1;
            for(int i =0; i < dp.Length; i++)
            {
                int len = 1;
   

                for(int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        len = Math.Max(len, dp[j] + 1);
                    }
                }
                dp[i] = len;
                max = Math.Max(max, len);
            }

            return max;

        }
        #endregion
    }
}
