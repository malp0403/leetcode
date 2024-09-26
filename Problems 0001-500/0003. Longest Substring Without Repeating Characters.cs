using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0003
    {

        #region LeetCode Solution1: Brute Force: T O(n^3), S O(min(n,m))
        #endregion

        #region LeetCode Solution2: Sliding Window T O(2n), S O(min(n,m))
        public int LengthOfLongestSubstring_SlidingWindow(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            if (s == "") return 0;
            if (s.Trim() == " ") return 1;
            int left = 0;
            int right = 0;
            int max = 0;
            while (right < s.Length)
            {
                if (dic.ContainsKey(s[right]))
                {
                    dic[s[right]]++;
                }
                else
                {
                    dic.Add(s[right], 1);
                }
                while (dic[s[right]] > 1)
                {
                    dic[s[left]]--;
                    left++;
                }
                max = Math.Max(max, right - left + 1);
                right++;
            }
            return max;
        }
        #endregion

        #region LeetCode Solution3: Sliding Window Optimized T O(n), S O(min(n,m))
        //making records of the index
        public int LengthOfLongestSubstring_SlidingWindowoptimized(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int max = 0;
            for (int i = 0, j = 0; j < s.Length; j++)
            {
                if (dic.ContainsKey(s[j]))
                {
                    i = Math.Max(i, dic[s[j]]);
                    dic[s[j]] = j + 1;
                }
                else
                {
                    dic.Add(s[j], j + 1);
                }
                max = Math.Max(max, j - i + 1);

            }
            return max;
        }
        #endregion

        #region answer
        public int LengthOfLongestSubstring(string s)
        {
            int l = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    l = Math.Max(dic[s[i]] + 1, l);
                    dic[s[i]] = i;

                }

                maxLength = Math.Max(i - l + 1, maxLength);
            }
            return maxLength;

        }
        #endregion

        #region 07/10/2022

        public int LengthOfLongestSubstring2(string s)
        {
            int l = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int maxLen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    l = Math.Max(dic[s[i]] + 1, l);
                    dic[s[i]] = i;
                }
                maxLen = Math.Max(i - l + 1, maxLen);
            }
            return maxLen;
        }
        #endregion

        #region 12/27/2022
        public int LengthOfLongestSubstring_20221227(string s)
        {
            int max = 0;
            int start = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    start = dic[s[i]] + 1;
                    dic = new Dictionary<char, int>() { };
                    i = start - 1;
                }
                else
                {
                    dic.Add(s[i], i);
                }
                max = Math.Max(max, i - start + 1);
            }
            return max;
        }
        #endregion

        #region 12/28/2022 Dictionary with Index
        public int LengthOfLongestSubstring_20221228(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int start = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dic[s[i]]);
                    dic[s[i]] = i + 1;
                }
                else
                {
                    dic.Add(s[i], i + 1);
                }
                max = Math.Max(max, i - start + 1);

            }
            return max;
        }

        #endregion

        #region 07/14/2023
        public int LengthOfLongestSubstring_20230714(string s)
        {
            int start = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dic[s[i]] + 1);
                    dic[s[i]] = i;
                }
                else
                {
                    dic.Add(s[i], i);
                }
                max = Math.Max(max, i - start + 1);
            }

            return max;

        }
        #endregion

        #region 01/02/2024
        public int LengthOfLongestSubstring_2024_01_02(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            int start = -1;
            int max = 0;
            for(int i =0;i < s.Length; i++)
            {
                char c = s[i];
                if (dic.ContainsKey(c))
                {
                    start = Math.Max(start, dic[c]);
                    dic[c] = i;
                }
                else
                {
                    dic.Add(c, i);
                }
                max = Math.Max(max, i - start);

            }

            return max;

        }
        #endregion
    }
}
