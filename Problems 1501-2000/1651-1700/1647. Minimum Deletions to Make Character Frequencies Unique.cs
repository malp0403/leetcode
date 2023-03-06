using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1647
    {
        #region attemp, It is like LeetCode Approach 1: Decrement Each Duplicate Until it is Unique
        int min = int.MaxValue;
        public int MinDeletions(string s)
        {
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (var item in s)
            {
                arr[item - 'a']++;
            }
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int c = arr[i];

                    if (dic.ContainsKey(c))
                    {
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c, 1);
                    }
                }
            }

            var keys = dic.Keys.OrderByDescending(x => x);
            keys.ToList();
            int count = 0;
            foreach (var key in keys)
            {
                if (dic[key] == 1) continue;
                else
                {

                    while (true)
                    {
                        int cur = dic[key];
                        dic[key]--;

                        int k = key;
                        while (k != 0)
                        {
                            if (dic.ContainsKey(k))
                            {
                                k--;
                                count++;
                            }
                            else
                            {
                                dic.Add(k, 1);
                                break;
                            }
                        }


                        if (dic[key] == 1) break;
                    }

                }
            }
            return count;
        }

        #endregion

        #region LeetCode Approach 1: Decrement Each Duplicate Until it is Unique
        public int MinDeletions_approach1(string s)
        {
            int[] freq = Enumerable.Repeat(0, 26).ToArray();
            foreach (var c in s)
            {
                freq[c - 'a']++;
            }


        }

        #endregion


    }
}
