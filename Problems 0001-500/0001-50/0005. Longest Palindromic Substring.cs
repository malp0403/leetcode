using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0005
    {
        #region Approach 4
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int end = 0;
            for(int i =0; i < s.Length; i++)
            {
                int len1 = helper(s, i, i);
                int len2 = helper(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start+1)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }

            }
            return s.Substring(start, end - start + 1);
        }

        public int helper(string s, int left, int right)
        {
            int R = right;
            int L = left;
            while(R < s.Length && L>=0 && s[R] == s[L])
            {
                R++;
                L--;
            }
            return R - L - 1;
        }

        #endregion

        #region Dynamic Programming
        bool[][] matrix;
        int[][] records;
        public string LongestPalindrome_dynamic(string s)
        {
            string result = "";
            matrix = new bool[s.Length][];
            int maxlen = 0;
            for(int i =0; i < matrix.Length; i++)
            {
                matrix[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }

            for(int len = 1; len <= s.Length; len++)
            {
                for(int i =0; i < s.Length; i++)
                {
                    int end = i + len-1;
                    if (end >= s.Length)
                    {
                        break;
                    }
                    matrix[i][end] = (len == 1 || len == 2 || matrix[i+1][end-1]) && s[i] == s[end];
                    if(matrix[i][end] && len > maxlen)
                    {
                        maxlen = len;
                        result = s.Substring(i, len);
                    }
                }
            }
            return result;
        }




        #endregion
    }
}
