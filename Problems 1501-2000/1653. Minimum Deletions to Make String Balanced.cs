using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1653
    {
        #region attempt
        int min = int.MaxValue;
        public int MinimumDeletions(string s)
        {
            int[] count = Enumerable.Repeat(0, s.Length).ToArray();

            for (int i = s.Length - 2; i >= 0; i--)
            {
                //count the 'a' amount behind index i;
                count[i] = count[i + 1] + ((s[i + 1] == 'a') ? 1 : 0);
            }
            helper(0, 0, count, s);

            return min;

        }

        public void helper(int index, int cur, int[] count, string s)
        {
            if (index == s.Length)
            {
                if (cur < min)
                {
                    min = cur;
                }
                return;
            }
            if (s[index] == 'b')
            {
                //to keep;
                min = Math.Min(cur + count[index], min);
                //to remove;
                helper(index + 1, cur + 1, count, s);
            }
            else
            {
                helper(index + 1, cur, count, s);
            }
        }
        #endregion



    }
}
