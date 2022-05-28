using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _245
    {
        public int ShortestWordDistance(string[] words, string word1, string word2)
        {
            int min = Int16.MaxValue;

            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>() { };
            for (int i = 0; i < words.Length; i++) {
                if (dic.ContainsKey(words[i])) dic[words[i]].Add(i);
                else dic.Add(words[i], new List<int>() { i });
            }
            if (word1 != word2)
            {
                var l1 = dic[word1];
                var l2 = dic[word2];
                int i1 = 0;
                int i2 = 0;
                while (i1 < l1.Count && i2 < l2.Count)
                {
                    int temp = l1[i1] - l2[i2];
                    min = Math.Min(Math.Abs(temp), min);
                    if (temp < 0) i1++;
                    else i2++;
                }
            }
            else {
                var l = dic[word1];
                for (int j = 0; j < l.Count-1; j++) {
                    min = Math.Min(l[j + 1] - l[j], min);
                }
            }
            return min;
        }
    }
}
