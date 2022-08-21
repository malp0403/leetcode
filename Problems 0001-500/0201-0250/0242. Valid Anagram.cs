using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] counter = new int[26];
            for(int i=0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }
            for(int i =0; i< 26; i++)
            {
                if(counter[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnagram_R2(string s, string t) {
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
    }
}
