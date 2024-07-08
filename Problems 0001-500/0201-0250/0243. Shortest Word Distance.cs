using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0243
    {
        #region 07/08/2024
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
            dic.Add(word1,new List<int>());
            dic.Add(word2,new List<int>()); 

            for(int i =0; i < wordsDict.Length; i++)
            {
                if (dic.ContainsKey(wordsDict[i]))
                {
                    dic[wordsDict[i]].Add(i);
                }
            }

            int distance = wordsDict.Length;
            int l1 = 0;
            int l2 = 0;
            while(l1 < dic[word1].Count && l2 < dic[word2].Count)
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
