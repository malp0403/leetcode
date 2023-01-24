using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0387
    {
        #region LeetCode Solution1: Linear time solution; hashmap
        public int FirstUniqChar_hashmap(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>() { };
            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            for(int i =0; i < s.Length; i++)
            {
                if(map.ContainsKey(s[i]) && map[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region my try
        public int FirstUniqChar(string s)
        {
            HashSet<char> set = new HashSet<char>() { };
            int ind = -1;
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                    int temp = s.LastIndexOf(s[i]);
                    if (temp == i)
                    {
                        ind = i;
                        break;
                    }
                }
            }
            return ind;
        }
        #endregion

        #region 12/19/2021
        //------------------------12/19/2021-----------------
        public int FirstUniqChar_R2(string s)
        {
            Dictionary<char, List<int>> d = new Dictionary<char, List<int>>() { };

            for (int i = 0; i < s.Length; i++)
            {
                if (!d.ContainsKey(s[i])) d.Add(s[i], new List<int>() { i });
                else
                    d[s[i]].Add(i);
            }
            int ans = Int32.MaxValue;
            foreach (var key in d.Keys)
            {
                if (d[key].Count == 1)
                {
                    ans = Math.Min(ans, d[key].First());

                }
            }

            return ans != Int32.MaxValue ? ans : -1;
        }
        #endregion

        #region 12/30/2022
        public int FirstuniqChar(string s)
        {
            int[] arr = Enumerable.Repeat(-1, 26).ToArray();
            for(int i =0; i < s.Length; i++)
            {
                if (arr[s[i] -'a'] == -1)
                {
                    arr[s[i] - 'a'] = i;
                }else
                {
                    arr[s[i] - 'a'] = -2;
                }
            }
            int index = int.MaxValue;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] != -1 && arr[i] != -2)
                {
                    index = Math.Min(index, arr[i]);
                }
            }
            return index == int.MaxValue ? -1 : index;
        }
        #endregion

    }
}
