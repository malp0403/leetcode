using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0318
    {
        #region 07/23/2024 precomputation  need to learn bitmask too
        public int MaxProduct(string[] words)
        {
            int max = 0;
            List<HashSet<int>> list = new List<HashSet<int>>();
            for (int i = 0; i < 26; i++)
            {
                list.Add(new HashSet<int>());
            }

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                foreach (var item in word)
                {
                    list[item - 'a'].Add(i);
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 1; j < words.Length; j++)
                {
                    bool isOverLap = false;
                    foreach (var item in list)
                    {
                        if (item.Contains(i) && item.Contains(j))
                        {
                            isOverLap = true;
                        }
                    }
                    if (!isOverLap)
                    {
                        max = Math.Max(words[i].Length * words[j].Length, max);
                    }
                }
            }

            return max;


        }
        #endregion

    }
}
