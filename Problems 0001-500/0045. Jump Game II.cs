using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


#region Example

#endregion

#region Test

#endregion

namespace leetcode.Problems
{
    class _0045
    {
        #region answer
        public int Jump(int[] nums)
        {
            if (nums.Length == 1) return 0;

            int furthest = 0;
            int[] dp = Enumerable.Repeat(0, nums.Length).ToArray();
            for(int i=0; i < nums.Length; i++)
            {
                if (nums[i] == 0) continue;
                dp[i]++;
                int max = Math.Min(nums.Length - 1, i + nums[i]);
                if (max == nums.Length - 1) return dp[i];
                if(max > furthest)
                {
                    for(int j = furthest+1; j <= max; j++)
                    {
                        dp[j] = dp[i];
                    }
                    furthest = max;
                }
            }
            return 0;
        }

        public int Jump_v2(int[] nums)
        {
            int steps = 0; int curEnd = 0; int fathest = 0;
            for(int i =0; i < nums.Length-1; i++)
            {
                fathest = Math.Max(i + nums[i], fathest);
                if(i == curEnd)
                {
                    steps++;
                    curEnd = fathest;
                }
            }
            return steps;
        }
        #endregion
        #region 08/02/2022
        public int jump_20220802(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] records = Enumerable.Repeat(0, nums.Length+1).ToArray();

            for(int i = 1; i < nums.Length; i++)
            {
                int min = int.MaxValue;
                for(int j = 0; j < i; j++)
                {
                    if(nums[j]>= i-j)
                    {
                        min = Math.Min(min, records[j]);
                    }
                }
                records[i] = min+1;
            }
            return records[nums.Length - 1];
        }
        public int jump_20220802_2(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] dp = Enumerable.Repeat(0, nums.Length).ToArray();

            int furthest = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i == 0) continue;
                dp[i]++;
                int max = Math.Min(nums.Length - 1, i + nums[i]);
                if (max == nums.Length - 1) return dp[i];
                if (max > furthest)
                {
                    for(int j =furthest+1; j <= max; j++)
                    {
                        dp[j] = dp[i];
                    }
                    furthest = max;
                }
            }
            return 0;
        }
        #endregion

        #region 12/28/2022  Buttom Up
        public int Jump_20221228(int[] nums)
        {
            int[] arr = Enumerable.Repeat(int.MaxValue, nums.Length).ToArray();
            arr[0] = 0;
            for(int i =0; i < nums.Length; i++)
            {
                for(int j = i; j <= nums[i] + i; j++)
                {
                    if (j >= nums.Length) break;
                    arr[j] = Math.Min(arr[j], arr[i] + 1);
                }
            }
            return arr[nums.Length - 1];
        }
        #endregion
        #region  TD
        public int Jump_20221228TD(int[] nums)
        {
            int[] dp = Enumerable.Repeat(int.MaxValue, nums.Length).ToArray();
            dp[0] = 0;
            return helper(nums.Length - 1, dp, nums);
        }
        public int helper(int i,int[] dp,int[] nums)
        {
            if (dp[i] != int.MaxValue) return dp[i];
            int min = int.MaxValue;
            for(int j = 0; j < i; j++)
            {
                if(j+nums[j] >= i)
                {
                    int temp=helper(j, dp, nums);
                    if (temp +1< min)
                    {
                        min = temp+1;
                    }
                }
            }
            dp[i] = min;
            return dp[i];
        }
        #endregion

        #region 12/28/2022 jump
        public int Jump_20221228v3(int[] nums)
        {
            if (nums.Length <= 1) return 0;
            int start = 1;
            int furthest = nums[0];
            int step = 1;
            while (true)
            {

                if (furthest >= nums.Length - 1) break;
                int temp = furthest;
                for (int i = start; i <= temp; i++)
                {
                    if (nums[i] + i > furthest)
                    {
                        furthest = nums[i] + i;
                    }
                }
                start = temp + 1;
                step++;
            }
            return step;


        }
        #endregion

        #region 02/24/2024
        public int Jump_2024_02_24(int[] nums)
        {
            
            if (nums.Length <= 1) return 0;

            int farthest = 0;
            int jumpCount = 0;

            for (int i =0; i < nums.Length;)
            {
                int temp = farthest;

                while(i < nums.Length && i <= farthest){
                    temp = Math.Max(nums[i] + i, temp);
                    i++;
                }

                jumpCount++;

                if (temp >= nums.Length - 1) break;

                i = farthest + 1;
                farthest = temp;


            }

            return jumpCount;
            
        }

        #endregion
    }
}
