using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0049
    {
        #region LeetCode Solution1: Categorzie by Sorted String
        #endregion

        #region LeetCode Solution2: Categorzie by Count
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
                for (int i = 0; i < arr.Length; i++)
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
        #endregion

        #region 02/05/2022
        public IList<IList<string>> GroupAnagrams_R2(string[] strs)
        {
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
                for (int i = 0; i < arr.Length; i++)
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
        #endregion

        #region 08/03/2022
        public IList<IList<string>> GroupAnagrams_20220803(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
            for (int i = 0; i < strs.Length; i++)
            {
                string key = "";
                if (strs[i] == "")
                {
                    key = "0";
                }
                else
                {
                    int[] arr = Enumerable.Repeat(0, 26).ToArray();
                    for (int j = 0; j < strs[i].Length; j++)
                    {
                        arr[strs[i][j] - 'a']++;
                    }
                    key = string.Join("#", arr);
                }
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(strs[i]);
                }
                else
                {
                    dic.Add(key, new List<string> { strs[i] });
                }
            }
            IList<IList<string>> answer = new List<IList<string>>() { };
            foreach (var key in dic.Keys)
            {
                answer.Add(dic[key]);
            }
            return answer;

        }
        #endregion

        #region 12/29/2022
        public IList<IList<string>> GroupAnagrams_20221229(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
            foreach (var s in strs)
            {
                string key = FormKey(s);
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(s);
                }
                else
                {
                    dic.Add(key, new List<string>() {s });
                }
            }
            IList<IList<string>> ans = new List<IList<string>>() { };
            foreach (var item in dic.Keys)
            {
                ans.Add(dic[item]);
            }
            return ans;
        }
        public string FormKey(string s)
        {
            int[] arr= Enumerable.Repeat(0, 26).ToArray();
            foreach (var c in s)
            {
                arr[c - 'a']++;
            }
            return String.Join('#', arr);
        }
        #endregion

        #region 07/26/2023
        public IList<IList<string>> GroupAnagrams_20230726(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };

            for(int i = 0;i<strs.Length; i++)
            {
                string k = formKey_20230726(strs[i]);
                if (dic.ContainsKey(k)) dic[k].Add(strs[i]);
                else dic.Add(k,new List<string>() { strs[i]});    

            }
            IList<IList<string>> answer = new List<IList<string>>() { };
            foreach (var item in dic.Keys)
            {
                answer.Add(dic[item]);
            }
            return answer;

        }
        public string formKey_20230726(string s)
        {
            int[] array = Enumerable.Repeat(0,26).ToArray();
            for(int i =0; i < array.Length; i++)
            {
                array[s[i] - 'a']++;
            }
            return string.Join('#', array);
        }

        #endregion

    }
}
