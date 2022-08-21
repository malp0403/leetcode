using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0032
    {
        #region solution 1 
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length; i++) {
                max = Math.Min(helper(i, s), max);
            }
            return max;
        }
        public int helper(int i, string s)
        {
            int count = 0;
            int l = 0;
            for(int j =i; j < s.Length; j++)
            {
                if (s[j] == ')')
                {
                    l--;
                    if(l ==0)
                    {
                        count = j - i+1;
                    }else if (l < 0)
                    {
                        return count;
                    }
                }
                else
                {
                    l++;
                }
            }
            return count;
        }
        #endregion
    }
}
