using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0424
    {
        int max = 0;
        HashSet<char> set = new HashSet<char>() { };
        public int CharacterReplacement(string s, int k)
        {
            int i = 0;
            while (i < s.Length)
            {
                if (!set.Contains(s[i])) {
                    set.Add(s[i]);
                    max = Math.Max(max, MaxLength(0, s, s[i], k));
                }
                i++;
            }

            return max;
        }

        public int MaxLength(int startIndx,string s,char c,int count)
        {
            int l = startIndx;
            int r = l;
            int sum = 0;
            
            while (r<s.Length)
            {
                if (s[r] != c)
                {
                    count--;
                }
                if (count >=0)
                {
                    sum++;
                }

                if(count < 0)
                {
                    if (s[l] != c)
                    {
                        count++;
                    }
                    l++;
 
                }
                r++;
            }
            return sum;
        }
    }
}
