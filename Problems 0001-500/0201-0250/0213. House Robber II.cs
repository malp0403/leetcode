using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Case
/*
        var obj = new _0213();
            obj.Rob(new int[] {2,3,2});
 */
#endregion

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0213
    {
        #region 07/07/2024
        int[][] dp1;
        int[][] dp2;
        public int Rob(int[] nums)
        {



            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if(nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int result = helper1(0, nums.Length - 2, nums);
            int reuslt2= helper1(1,nums.Length - 1, nums);
            return Math.Max(result, reuslt2);
        }
        public int helper1(int start, int end, int[] nums)
        {
            int t1 = 0;
            int t2 = 0;
            for(int i = start; i < end; i++)
            {
                int temp = t1;
                int cur = nums[i];
                t1 = Math.Max(t2 + cur, t1);
                t2 = temp;
            }
            return t1;

        }
        public int helper2(int i, int canRob, int[] nums, int[][] dp)
        {
            if (i >= nums.Length) return 0;

            if (dp[i][canRob] != int.MinValue)
            {
                return dp[i][canRob];
            }
            int money1 = 0;
            int money2 = 0;
            if (canRob == 1)
            {
                money1 = nums[i] + helper2(i + 1, 0, nums, dp);
            }
            money2 = helper2(i + 1, 1, nums, dp);

            dp[i][canRob] = Math.Max(money1, money2);

            return dp[i][canRob];
        }
        #endregion
    }
}
