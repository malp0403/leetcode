using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _316
    {
        public string RemoveDuplicateLetters(string s)
        {

            int[] records = new int[26];
            int pos = 0;
            for (int i = 0; i < s.Length; i++) records[s[i] - 'a']++;
            for(int i=0;i < s.Length; i++)
            {
                if (s[i] < s[pos]) pos = i;
                if (--records[s[i] - 'a'] == 0) break;
            }

            return s.Length == 0 ? "": s[pos].ToString() + RemoveDuplicateLetters(s.Substring(pos + 1).Replace(s[pos].ToString(), ""));
        }
    }
}
