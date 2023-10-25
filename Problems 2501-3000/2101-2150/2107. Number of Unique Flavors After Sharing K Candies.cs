using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2101_2150
{
    internal class _2107
    {
        #region Sliding windows
        public int ShareCandies_20231009(int[] candies, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in candies)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }

            int total = dic.Keys.Count;
            int count = total;
            int max = int.MinValue;
            for (int i = 0; i < candies.Length; i++)
            {

                dic[candies[i]]--;
                if (dic[candies[i]] == 0)
                {
                    count--;
                }
                if (i == k - 1)
                {
                    max = Math.Max(count, max);
                }
                if (i >= k)
                {
                    dic[candies[i]]--;
                    if (dic[candies[i]] == 0)
                    {
                        count--;
                    }
                    dic[candies[i - k]]++;
                    if (dic[candies[i - k]] == 1)
                    {
                        count++;
                    }
                    max = Math.Max(count, max);
                }
            }
            return max;
        }
        #endregion
    }
}
