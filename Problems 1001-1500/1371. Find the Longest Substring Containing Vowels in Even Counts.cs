using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1351_1400
{
    internal class _1371
    {
        #region 10/30/2023
        Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();
        public int FindTheLongestSubstring(string s)
        {
            dic.Add('a', new List<int>() { });
            dic.Add('e', new List<int>() { });
            dic.Add('i', new List<int>() { });
            dic.Add('o', new List<int>() { });
            dic.Add('u', new List<int>() { });
            int max = 0;
            for(int i=0;i< s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]].Add(i);
                }

                max = Math.Max(helper(i), max);
                if (max >= 831)
                {
                    var test = ' ';
                }
            }
            return max;
        }
        public int helper(int index)
        {
            int start = 0;
            foreach (var item in dic.Keys)
            {
                if(dic[item].Count %2 == 0)
                {
                    continue;
                }
                else
                {
                    start = Math.Max(start,dic[item][0] + 1);
                }
 
            }
            return index - start+1;
        }
        #endregion
    }
}
