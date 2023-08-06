using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcode.Problems
{
    class _0005
    {
        #region LeetCode Approach3: Dynamic Programming; len-> start
        public string LongestPalindrome_DP(string s)
        {
            bool[][] matrix = new bool[s.Length][];
            string answer = "";
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                matrix[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }

            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int end = i + len - 1;
                    if (end >= s.Length) continue;
                    matrix[i][end] = (len == 1 || len == 2 || matrix[i + 1][end - 1])
                        && (s[i] == s[end]);
                    if (matrix[i][end] && len > maxLen)
                    {
                        maxLen = len;
                        answer = s.Substring(i, len);
                    }
                }
            }
            return answer;

        }
        #endregion
        #region LeetCode Approach4: Expand Around Center: T O(n^2) S O(1) 
        // helper(i,i) && helper(i , i+1)
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = helper(s, i, i);
                int len2 = helper(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start + 1)
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
            while (R < s.Length && L >= 0 && s[R] == s[L])
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
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }

            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int end = i + len - 1;
                    if (end >= s.Length)
                    {
                        break;
                    }
                    matrix[i][end] = (len == 1 || len == 2 || matrix[i + 1][end - 1]) && s[i] == s[end];
                    if (matrix[i][end] && len > maxlen)
                    {
                        maxlen = len;
                        result = s.Substring(i, len);
                    }
                }
            }
            return result;
        }




        #endregion

        #region 12/27/2022 extend in one point
        public string LongestPalindrome_20221227(string s)
        {
            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                int length1 = helper_20221227(s, i, i);
                int length2 = helper_20221227(s, i, i + 1);
                if (length1 > length2)
                {
                    string temp = s.Substring(i - (length1 - 1) / 2, length1);
                    if (temp.Length > answer.Length)
                    {
                        answer = temp;
                    }
                }
                else
                {
                    string temp = s.Substring(i - (length1 - 2) / 2, length2);
                    if (temp.Length > answer.Length)
                    {
                        answer = temp;
                    }
                }

            }
            return answer;
        }
        public int helper_20221227(string s, int index1, int index2)
        {
            int left = index1;
            int right = index2;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
        #endregion

        #region 12/28/2022 DP
        public string LongestPalindrome_20221228(string s)
        {
            bool[][] m = new bool[s.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }
            int max = 0;
            string answer = "";
            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int end = i + len - 1;
                    if (end >= s.Length) continue;
                    m[i][end] = (len == 1 || len == 2 || m[i + 1][end - 1]) && (s[i] == s[end]);
                    if (m[i][end] && len > max)
                    {
                        max = len;
                        answer = s.Substring(i, len);
                    }
                }
            }
            return answer;
        }
        #endregion

        #region 12/28/2022 extend in one point
        public string LongestPalindrome_20221228v2(string s)
        {
            int max = 0;
            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                int temp1 = helper_20221228(s, i, i);
                int temp2 = helper_20221228(s, i, i + 1);
                int temp3 = Math.Max(temp1, temp2);
                if (temp3 > max)
                {
                    max = temp3;
                    answer = s.Substring(i - (temp3 - 1) / 2, temp3);
                }
            }
            return answer;
        }

        public int helper_20221228(string s, int i, int j)
        {
            int left = i;
            int right = j;
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }
            return j - i - 1;
        }
        #endregion

        #region 07/14/2023

        public string LongestPalindrome_20230714(string s)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                string s1 = helper_20230714(i, i, s);
                if (s1.Length > answer.Length)
                {
                    answer = s1;
                }
                if (i + 1 < s.Length)
                {
                    string s2 = helper_20230714(i, i + 1, s);
                    if (s2.Length > answer.Length)
                    {
                        answer = s2;
                    }
                }

            }
            return answer;
        }

        public string helper_20230714(int i, int j, string s)
        {
            int len = 0;
            if (s[i] != s[j]) return "";

            while (i - len >= 0 && j + len < s.Length && s[i-len] == s[j+len])
            {
                len++;

            }

            return s.Substring(i - len + 1, j - i + 1 + 2 * (len - 1));
        }

        #endregion
    }
}
