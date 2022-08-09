using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q5_Maximum_Score_from_Performing_Multiplication_Operations
    {
        #region answer
        int[][] memo;
        public int td(int[] nums, int[] multipliers)
        {
            memo = new int[multipliers.Length][];
            for(int i =0; i < memo.Length; i++)
            {
                memo[i] = Enumerable.Repeat(0, multipliers.Length).ToArray();
            }

            int n = nums.Length;
            int m = multipliers.Length;


            return helper(0, 0, nums, multipliers);
        }
        public int helper(int i, int left,int[] nums, int[] multipliers)
        {
            if (i == multipliers.Length) return 0;

            int mult = multipliers[i];
            int right = nums.Length - 1 - (i - left);
            if(memo[i][left] == 0)
            {
                memo[i][left] = Math.Max(mult * nums[left] + helper(i + 1, left + 1, nums, multipliers),
                    mult * nums[right] + helper(i + 1, left, nums, multipliers));
            }

            return memo[i][left];

        }

        public int bu(int[] nums, int[] multipliers)
        {
            int[][] memo2 = new int[multipliers.Length+1][];
            for (int i = 0; i < memo.Length; i++)
            {
                memo2[i] = Enumerable.Repeat(0, multipliers.Length+1).ToArray();
            }
            int m = multipliers.Length;
            memo2[multipliers.Length - 1][multipliers.Length - 1] = 0;
            for(int i = m-1; i >=0; i--)
            {
                for(int j = i; j >=0; j--)
                {
                    int mult = multipliers[j];
                    int right = nums.Length - 1 - (i - j);
                    memo2[i][j] = Math.Max(mult * nums[j] + memo2[i + 1][j + 1], mult * nums[right] + memo2[i + 1][j]);
                }
            }

            return memo2[0][0];
        }
        #endregion

        #region 06/22/2022
        int[][] memo_r1;
        public int MaximumScore_tdR1(int[] nums, int[] multipliers)
        {
            memo_r1 = new int[multipliers.Length][];
            for(int i =0; i < multipliers.Length; i++)
            {
                memo_r1[i] = Enumerable.Repeat(0, multipliers.Length).ToArray();
            }


            return helper_r1(0,0,nums,multipliers);
        }
        public int helper_r1(int n,int left,int[] nums, int[] multipliers)
        {
           if(n == multipliers.Length)
            {
                return 0;
            }

            int right = nums.Length - 1 - (n - left);

            if(memo_r1[n][left] == 0)
            {
                memo_r1[n][left] = Math.Max(multipliers[n] * nums[left] + helper_r1(n+1,left+1,nums,multipliers)
                    , multipliers[n] * nums[right]+helper_r1(n + 1, left, nums, multipliers));
            }
            return memo_r1[n][left];
            
        }

        public int MaximumScore_buR1(int[] nums, int[] multipliers)
        {
            int[][] memo_r1 = new int[multipliers.Length+1][];
            for (int i = 0; i < multipliers.Length; i++)
            {
                memo_r1[i] = Enumerable.Repeat(0, multipliers.Length+1).ToArray();
            }
            memo_r1[multipliers.Length - 1][multipliers.Length - 1] = 0;

            for (int i = multipliers.Length - 1; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    int right = multipliers.Length - 1 - (i - j);
                    memo_r1[i][j] = Math.Max(multipliers[j] * nums[j] + memo_r1[i + 1][j + 1],
                        multipliers[j] * nums[right] + memo_r1[i + 1][j]);
                }
            }


            return memo_r1[0][0];
        }



        #endregion

        #region 06/27/2022
        int[][] memo2;
        int m_r2;
        int n_r2;
        public int td_r2(int[] nums, int[] multiplier)
        {
            m_r2 = multiplier.Length;
            n_r2 = nums.Length;
            memo2 = new int[m_r2][];
            for(int i =0;i < m_r2; i++)
            {
                memo2[i] = Enumerable.Repeat(0, n_r2).ToArray();
            }

            return helper_r2(0, 0, nums, multiplier);




        }

        public int helper_r2(int m, int left, int[] nums, int[] multipliers)
        {
            if (m == multipliers.Length) return 0;
            if (memo2[m][left] > 0) return memo2[m][left];
            int multi = multipliers[m];
            int right = nums.Length - 1 - (m - left);
            int a = helper_r2(m + 1, left + 1, nums, multipliers) + multi * nums[left+1];
            int b = helper_r2(m + 1, left, nums, multipliers) + multi * nums[right];
            memo2[m][left] = Math.Max(a, b);
            return memo2[m][left];
        }
        #endregion
    }
}

/*
 You are given two integer arrays nums and multipliers of size n and m respectively, where n >= m. The arrays are 1-indexed.

You begin with a score of 0. You want to perform exactly m operations. On the ith operation (1-indexed), you will:

Choose one integer x from either the start or the end of the array nums.
Add multipliers[i] * x to your score.
Remove x from the array nums.
Return the maximum score after performing m operations.
     
     */
