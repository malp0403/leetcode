using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0692
    {
        #region 12/05/2023 LeetCode Solution1: Brute Force
        public IList<string> TopKFrequent_2023_12_05_bruteForce(string[] words, int k)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word]++;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }

            List<string> list = new List<string>();

            foreach (string key in dic.Keys)
            {
                list.Add(key);
            }

            list.Sort(delegate (string s1, string s2) {
                return dic[s1] != dic[s2] ? dic[s2].CompareTo(dic[s1]) : s1.CompareTo(s2);
            });

            return list.Take(k).ToList();

        }
        #endregion

    }
}
