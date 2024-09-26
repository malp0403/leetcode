using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0244
    {
        #region 07/08/2024
        Dictionary<string, List<int>> dic;
        public _0244(string[] wordsDict)
        {
            dic = new Dictionary<string, List<int>>();


            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (dic.ContainsKey(wordsDict[i]))
                {
                    dic[wordsDict[i]].Add(i);
                }
                else
                {
                    dic.Add(wordsDict[i],new List<int>() { i});
                }
            }

        }

        public int Shortest(string word1, string word2)
        {
            int distance = int.MaxValue;
            int l1 = 0;
            int l2 = 0;
            while (l1 < dic[word1].Count && l2 < dic[word2].Count)
            {
                distance = Math.Min((int)Math.Abs(dic[word1][l1] - dic[word2][l2]), distance);
                if (dic[word1][l1] < dic[word2][l2])
                {
                    l1++;
                }
                else
                {
                    l2++;
                }
            }
            return distance;
        }
        #endregion
    }
}
