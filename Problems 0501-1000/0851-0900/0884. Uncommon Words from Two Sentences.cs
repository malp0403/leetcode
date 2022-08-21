using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0884
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>() { };
            //Dictionary<string, int> d2 = new Dictionary<string, int>() { };
            foreach (var string1 in s1.Split(' '))
            {
                if (d1.ContainsKey(string1)) d1[string1]++;
                else d1.Add(string1, 1);
            }
            foreach (var string2 in s2.Split(' '))
            {
                if (d1.ContainsKey(string2)) d1[string2]++;
                else d1.Add(string2, 1);
            }
            List<string> list = new List<string>() { };
            foreach (var key in d1.Keys)
            {
                if(d1[key]==1 )
                {
                    list.Add(key);
                }
            }


            return list.ToArray();
        }
    }
}
