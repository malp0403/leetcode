using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0242
    {
        #region  LeetCode Solution1: Sorting; T:O(nlogn) S:O(1)
        #endregion

        #region LeetCode Solution2: Frequency Counter; O(n):O(1)
        public bool IsAnagram_FrequencyCounter(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] counter = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (counter[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region my try
        public bool IsAnagram_R2(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] reference = Enumerable.Repeat(0, 26).ToArray();
            foreach (var c1 in s)
            {
                reference[c1 - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                reference[t[i] - 'a']--;
                if (reference[t[i] - 'a'] < 0) return false;
            }
            return true;
        }
        #endregion

        #region 12/30/2022
        public bool IsAnagram_20221230(string s, string t)
        {
            //uneven length
            if (s.Length != t.Length) return false;

            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (var c in s)
            {
                arr[c - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                arr[t[i] - 'a']--;
                if (arr[t[i] - 'a'] < 0) return false;
            }
            return true;
        }
        #endregion

        #region 09/04/2023
        public bool IsAnagram_20230904(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] arr = Enumerable.Repeat(0, 26).ToArray();

            for(int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;

            }
            for (int i =0; i <26; i++)
            {
                if (arr[i] != 0) return false;

            }
            return true;
            
        }
        #endregion
    }
}
