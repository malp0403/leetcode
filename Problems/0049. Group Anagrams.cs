using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };

            foreach (var s in strs)
            {
                int[] arr = Enumerable.Repeat(0, 26).ToArray();
                foreach (var c in s)
                {
                    arr[c - 'a']++;
                }
                StringBuilder sb = new StringBuilder();
                for(int i=0; i < arr.Length; i++)
                {
                    sb.Append('#');
                    sb.Append(arr[i]);
                }
                string key = sb.ToString();
                if (!dic.ContainsKey(key)) dic.Add(key, new List<string>() { s });
                else dic[key].Add(s);
            }
            IList<IList<string>> ans = new List<IList<string>>() { };
            foreach (var val in dic.Values)
            {
                ans.Add(val);
            }
            return ans;


        }
        //02/05/2022
        public IList<IList<string>> GroupAnagrams_R2(string[] strs) {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
            foreach (var str in strs)
            {
                //form keys;
                int[] arr = Enumerable.Repeat(0, 26).ToArray();
                foreach (var c in str)
                {
                    arr[c - 'a']++;
                }
                StringBuilder sb = new StringBuilder() { };
                for(int i=0;i < arr.Length; i++)
                {
                    sb.Append(arr[i]);
                    sb.Append('#');
                }
                string key = sb.ToString();
                if (dic.ContainsKey(key)) dic[key].Add(str);
                else dic.Add(key, new List<string>() { str });
            }
            IList<IList<string>> ans = new List<IList<string>>() { };
            foreach (var val in dic.Values)
            {
                ans.Add(val);
            }
            return ans;
        }
    }
}
