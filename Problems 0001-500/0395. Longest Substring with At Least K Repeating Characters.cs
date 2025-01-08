using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0395
    {
        #region Approach 2: Divide And Conquer 09/01/2024 Using invalid char to split


        public int LongestSubstring_app2(string s, int k)
        {
            return helper_app2(s, k, 0, s.Length);


        }

        public int helper_app2(string s, int k, int start, int end)
        {
            if (end - start < k) return 0;
            int[] map = Enumerable.Repeat(0, 26).ToArray();
            for (int i = start; i < end; i++)
            {
                map[s[i] - 'a']++;
            }

            for (int i = start; i < end; i++)
            {
                if (map[s[i] - 'a'] >= k) continue;
                int midNext = i + 1;
                while (midNext < end && map[s[midNext] - 'a'] < k) midNext++;

                return Math.Max(helper_app2(s, k, start, i), helper_app2(s, k, midNext, end));
            }

            return end - start;
        }
        #endregion

        #region Approach 3: Sliding Window
        public int LongestSubstring_app3(string s, int k)
        {
            return 0;
        }

        #endregion

       

    }
}
