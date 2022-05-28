using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _243
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            int min = Int32.MaxValue;
            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>() { };
            for (int i = 0; i < words.Length; i++)
            {
                if (!dic.ContainsKey(words[i]))
                {
                    dic.Add(words[i], new List<int>() { i });
                }
                else {
                    dic[words[i]].Add(i);
                }
            }
            int i1 = 0;
            int i2 = 0;
            while (i1 < dic[word1].Count && i2 < dic[word2].Count) {
                int temp = dic[word1][i1] - dic[word2][i2];
                if (temp < 0) i1++;
                else i2++;
                if (Math.Abs(temp) < min) min = Math.Abs(temp);
            }
            return min;
        }
    }
}
