using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test case
/*
             var obj = new _0291();
            obj.WordPatternMatch("abba", "redblueredblue");
 */
#endregion
namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0291
    {
        #region 07/15/2024
        int total_uniq_key_2024_07_15;
        int total_key_2024_07_15;
        List<List<string>> lists_2024_07_15;
        public Boolean WordPatternMatch(string pattern, string s)
        {
            total_uniq_key_2024_07_15 = 0;
            total_key_2024_07_15 = pattern.Length;
            HashSet<char> set = new HashSet<char>();
            lists_2024_07_15 = new List<List<string>>();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            List<char> keys = new List<char>();
            foreach (var item in pattern)
            {
                set.Add(item);
                keys.Add(item);
            }
            total_uniq_key_2024_07_15 = set.Count;

            helper(0, s, new List<string>(), new HashSet<string>());

            for(int i =0; i < lists_2024_07_15.Count; i++)
            {
                if (map_2024_07_15(keys, lists_2024_07_15[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool map_2024_07_15(List<char> list1,List<string> list2)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            HashSet<string> seen = new HashSet<string>();

            for(int i =0; i < list1.Count; i++)
            {
                if (!dic.ContainsKey(list1[i]))
                {
                    if (seen.Contains(list2[i])) return false;
                    dic.Add(list1[i], list2[i]);
                }
                else
                {
                    if (dic[list1[i]] != list2[i]) return false;
                }
                seen.Add(list2[i]);
            }

            return true;

        }

        public void helper(int index,string s, List<string> curlist,HashSet<string> set)
        {
            if(index >= s.Length)
            {
                Console.WriteLine("set count: " + set.Count + " curList count " + curlist.Count);
                if(set.Count == total_uniq_key_2024_07_15 &&curlist.Count == total_key_2024_07_15)
                {
                    lists_2024_07_15.Add(curlist.ToList());
                }
                return;
            }

            if (set.Count > total_uniq_key_2024_07_15) return;
            if (curlist.Count >= total_key_2024_07_15) return;

            for (int len=1; len <= s.Length-index; len++)
            {
                string str = s.Substring(index, len);
                bool isAdded = true;
                curlist.Add(str);
                if (set.Contains(str)) { isAdded = false; }
                else {
                    set.Add(str);
                }
                helper(index + len, s, curlist, set);
                curlist.RemoveAt(curlist.Count - 1);
                if (isAdded)
                {
                    set.Remove(str);
                }

            }
        }
        #endregion
    }
}
