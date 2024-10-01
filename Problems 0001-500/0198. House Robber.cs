using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0198
    {
        #region solution
        int[] memory;
        public int Rob_s(int[] nums)
        {
            memory = Enumerable.Repeat(-1, 100).ToArray();

            return robPattern(0, nums);
        }

        public int robPattern(int indx, int[] nums)
        {
            if (indx >= nums.Length) return 0;

            if (this.memory[indx] > -1)
            {
                return this.memory[indx];
            }

            int max = Math.Max(robPattern(indx + 1, nums), robPattern(indx + 2, nums) + nums[indx]);

            this.memory[indx] = max;

            return max;
        }
        #endregion

        #region 06/11/2024
        int[][] dp_2024_06_11;
        public int Rob_2024_06_11(int[] nums)
        {
            dp_2024_06_11 = new int[nums.Length][];
            for(int i =0; i < nums.Length; i++)
            {
                dp_2024_06_11[i] = Enumerable.Repeat(-1, 2).ToArray();
            }

            return helper_2024_06_11(0, nums, 1);

        }
        public int helper_2024_06_11(int index, int[] nums,int canRob)
        {
            if(index >= nums.Length) return 0;

            if (dp_2024_06_11[index][canRob] != -1) return dp_2024_06_11[index][canRob];

            int max = 0;
            if (canRob == 1)
            {
                max = Math.Max(helper_2024_06_11(index + 1, nums, 1), nums[index] + helper_2024_06_11(index + 1, nums, 0));
            }
            else
            {
                max = helper_2024_06_11(index + 1, nums, 1);
            }

            dp_2024_06_11[index][canRob] = max;

            return max;
        }
        #endregion

        #region 09/29/2024
        public int Rob_2024_09_29_Bu(int[] nums)
        {

            int rob = 0;
            int noRob = 0;

            for(int i =0; i < nums.Length; i++)
            {
                int curRob = nums[i] + noRob;
                int curNorob = Math.Max(rob, noRob);

                rob = curRob;
                noRob = curNorob;
            }

            return Math.Min(rob, noRob);
        }
        #endregion
    }
}
