using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _244
    {

        Dictionary<string, List<int>> dic;

        public _244(string[] words)
        {
            dic = new Dictionary<string, List<int>>() { };
            for (int i = 0; i < words.Length; i++) {
                if (dic.ContainsKey(words[i]))
                    dic[words[i]].Add(i);
                else {
                    dic.Add(words[i], new List<int>() { i });
                }
            }
        }

        public int Shortest(string word1, string word2)
        {
            List<int> list = dic[word1];
            List<int> list2 = dic[word2];
            int i1 = 0;
            int i2 = 0;
            int min= int.MaxValue;

            while (i1 < list.Count && i2 < list2.Count) {
                int temp = list[i1] - list2[i2];
                if (Math.Abs(temp) == 1) { min = 1;break; }
                if (temp < 0) { i1++; }
                else { i2++; }
                min = Math.Min(Math.Abs(temp), min);
            }
            return min;
        }
    }
}
