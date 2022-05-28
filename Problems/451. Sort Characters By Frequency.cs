using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _451
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };

            foreach (var c in s)
            {
                if (dic.ContainsKey(c)) dic[c]++;
                else dic.Add(c, 1);
            }

            List<char> characters = dic.Keys.ToList();
            characters.Sort((x, y) => { return dic[y] - dic[x]; });

            StringBuilder ans = new StringBuilder();
            for(int i=0; i < characters.Count; i++)
            {
                int count = dic[characters[i]];
                string ele = characters[i].ToString();
                while(count > 0)
                {
                    ans.Append(ele);
                    count--;
                }
            }
            return ans.ToString();
        }
    }
}
