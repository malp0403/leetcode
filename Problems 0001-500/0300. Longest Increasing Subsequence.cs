using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0300
    {
       
        #region Solution
        int max = 1;
        int[] nums;
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            foreach (var c in dp)
            {
                max = Math.Max(max, c);
            }
            return max;


        }

        public void travel(int indx, int preValue, int count)
        {
            if (indx >= nums.Length)
            {
                max = Math.Max(count, max);
                return;
            }
            int temp = indx;
            while (indx < nums.Length)
            {
                if (nums[indx] > preValue)
                {
                    travel(indx + 1, nums[indx], count + 1);
                }
                indx++;
            };
        }
        #endregion

        #region 09/04/2023
        public int LengthOfLIS_20230904(int[] nums)
        {
            (int count, int curMax)[][] dp = new (int count, int curMax)[3][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = Enumerable.Repeat((0, -10001), nums.Length + 1).ToArray();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > dp[2][i].curMax)
                {
                    dp[0][i + 1] = (dp[2][i].count + 1, nums[i]);
                    dp[1][i + 1] = dp[0][i];
                    dp[2][i + 1] = helper_20230904(dp[0][i + 1], dp[1][i + 1]);
                }
                else
                {
                    int j = i;
                    int target = j;
                    int count = -1;
                    for (; j >= 0; j--)
                    {
                        if (dp[0][j].curMax < nums[i])
                        {
                            if (dp[0][j].count + (dp[0][j].curMax != nums[i] ? 1 : 0) > count)
                            {
                                count = dp[0][j].count + (dp[0][j].curMax != nums[i] ? 1 : 0);
                                target = j;
                            }
                        }
                    }

                    dp[0][i + 1] = (dp[0][target].count + (dp[0][target].curMax != nums[i] ? 1 : 0), nums[i]);
                    dp[1][i + 1] = dp[2][i];
                    dp[2][i + 1] = helper_20230904(dp[0][i + 1], dp[1][i + 1]);

                }

            }

            return dp[2][nums.Length].count;

        }

        public (int count, int curMax) helper_20230904((int count, int curMax) a, (int count, int curMax) b)
        {
            if (a.count > b.count) return a;
            if (b.count > a.count) return b;
            if (a.curMax < b.curMax) return a;
            else return b;
        }
        #endregion

        #region 09/05/2023
        public int LengthOfLIS_20230905(int[] nums)
        {
            int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
                    }
                }
            }
            int longest = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                longest = Math.Max(dp[i], longest);
            }
            return longest;


        }
        #endregion
    }
}
