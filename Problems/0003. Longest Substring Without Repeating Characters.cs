using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0003
    {
        public int LengthOfLongestSubstring(string s)
        {
            int l = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            int maxLength = 0;

            for(int i =0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    l = Math.Max(dic[s[i]]+1,l);
                    dic[s[i]] = i;
                    
                }

                maxLength = Math.Max(i - l + 1, maxLength);
            }
            return maxLength;

        }
    }
}
