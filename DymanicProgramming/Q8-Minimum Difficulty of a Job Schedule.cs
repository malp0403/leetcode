using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q8_Minimum_Difficulty_of_a_Job_Schedule
    {
        #region answer
        int[][] memo;
        int[] maxRemaing;
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            if (jobDifficulty.Length < d) return -1;
            int[][] memo = new int[jobDifficulty.Length][];
            for(int i =0; i <= memo.Length; i++)
            {
                memo[i] = Enumerable.Repeat(-1, d+1).ToArray();
            }
            maxRemaing = Enumerable.Repeat(0, jobDifficulty.Length).ToArray();
            int curMax = int.MinValue;
            for(int j=jobDifficulty.Length-1; j >= 0; j++)
            {
                curMax = Math.Max(jobDifficulty[j], curMax);
                maxRemaing[j] = curMax;
            }


            return helper(0, 1,jobDifficulty,d);
        }

        public int helper(int i, int day, int[] jobDifficulty, int d)
        {
            if(day == d)
            {
                return maxRemaing[i];
            }
            if (memo[i][day] != -1) return memo[i][day];
            int best = int.MaxValue;
            int hardest = 0;
            for(int j=i; j <jobDifficulty.Length-( d - day); j++)
            {
                hardest = Math.Max(hardest, jobDifficulty[j]);
                best = Math.Min(best, hardest + helper(j + 1, day + 1, jobDifficulty, d));
            }
            memo[i][day] = best;
            return memo[i][day];
        }

        #endregion
    }
}
