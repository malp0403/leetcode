using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0135
    {
        #region LeetCode Approach 2: Using two arrays
        public int Candy_app2(int[] ratings)
        {
            int[] left = Enumerable.Repeat(1, ratings.Length).ToArray();
            int[] right = Enumerable.Repeat(1, ratings.Length).ToArray();

            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    left[i] = left[i - 1] + 1;
                }
            }
            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    right[i] = right[i - 1] + 1;
                }
            }
            int sum = 0;
            for (int i = 0; i < ratings.Length; i++)
            {
                sum += Math.Max(left[i], right[i]);
            }
            return sum;
        }

        #endregion
        #region 03/26/2024
        public int Candy_2024_03_26(int[] ratings)
        {
            int[] left = Enumerable.Repeat(1, ratings.Length).ToArray();
            int[] right = Enumerable.Repeat(1, ratings.Length).ToArray();

            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    left[i] = left[i - 1] + 1;
                }
            }
            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    right[i] = right[i - 1] + 1;
                }
            }
            int sum = 0;
            for (int i = 0; i < ratings.Length; i++)
            {
                sum += Math.Max(left[i], right[i]);
            }
            return sum;
        }
        #endregion

        



    }
}
