using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0387
    {
        public int FirstUniqChar(string s)
        {
            HashSet<char> set = new HashSet<char>() { };
            int ind = -1;
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                    int temp = s.LastIndexOf(s[i]);
                    if (temp == i)
                    {
                        ind = i;
                        break;
                    }
                }
            }
            return ind;
        }
        //------------------------12/19/2021-----------------
        public int FirstUniqChar_R2(string s)
        {
            Dictionary<char, List<int>> d = new Dictionary<char, List<int>>() { };

            for(int i =0; i < s.Length; i++)
            {
                if (!d.ContainsKey(s[i])) d.Add(s[i], new List<int>() { i });
                else
                    d[s[i]].Add(i);
            }
            int ans = Int32.MaxValue;
            foreach (var key in d.Keys)
            {
                if (d[key].Count == 1)
                {
                    ans = Math.Min(ans, d[key].First());

                }
            }

            return ans != Int32.MaxValue ? ans: -1;
        }
    }
}
