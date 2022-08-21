using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0340
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            if (k == 0) return 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int l = 0;
            int r = 0;
            int max = 0;
            while (r < s.Length)
            {
                if (!dic.ContainsKey(s[r])) dic.Add(s[r], 1);
                else dic[s[r]]++;

                if(dic.Keys.Count <= k) max = Math.Max(max, r - l + 1);

                while (dic.Keys.Count > k)
                {
                    dic[s[l]]--;
                    if(dic[s[l]] == 0)
                    {
                        dic.Remove(s[l]);
                    }
                    l++;
                }
                r++;
            }
            return max;
        }
    }
}
