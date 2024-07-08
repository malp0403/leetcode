using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0249
    {
        #region Solution
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
            for (int i = 0; i < strings.Length; i++)
            {
                var k = formKey(strings[i]);
                if (dic.ContainsKey(k)) dic[k].Add(strings[i]);
                else
                {
                    dic.Add(k, new List<string>() { strings[i] });
                }
            }
            IList<IList<string>> li = new List<IList<string>>() { };
            foreach (var (key, val) in dic)
            {
                li.Add(val);
            }
            return li;

        }
        public string formKey(string s)
        {
            if (s.Length == 1) return "a";
            char c = s[0];
            string key = "";
            int count = 0;
            while (c != 'a')
            {
                c = (char)(c - 1);
                count++;
            }
            key += c.ToString();
            for (int j = 1; j < s.Length; j++)
            {
                char temp = (char)(s[j] - 'a' < count ? s[j] + 26 - count : s[j] - count);

                key += temp.ToString();
            }
            return key;
        }

        #endregion

        #region 01/11/2022
        // 01-11-2022-------------------------------------
        public IList<IList<string>> GroupStrings_R2(string[] strings)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
            foreach (var s in strings)
            {
                var key = Helper_R2(s);
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
        public string Helper_R2(string s)
        {
            StringBuilder sb = new StringBuilder() { };
            for (int i = 1; i < s.Length; i++)
            {
                //char k = (char)((s[i] - s[i - 1] + 26) % 26 + 'a');
                //sb.Append(k);
                string str = ((s[i] - s[i - 1] + 26) % 26).ToString();
                sb.Append(str);
                sb.Append('#');
            }
            return sb.ToString();
        }
        #endregion

        #region 07/08/2022
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            foreach (var item in strings)
            {
                string key = formKey_2024_07_07(item);
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(item);
                }
                else
                {
                    dic.Add(key, new List<string>() { item });
                }
            }
            IList<IList<string>> answer = new List<IList<string>>() { };
            foreach (var item in dic.Keys)
            {
                answer.Add(dic[item]);
            }

            return answer;
        }
        public string formKey_2024_07_07(string s)
        {
            int dif = s[0] - 'a';
            StringBuilder sb = new StringBuilder();

            for(int i =1; i < s.Length; i++)
            {
                string str = ((s[i] - s[i - 1] + 26) % 26).ToString();
                sb.Append(str);
                sb.Append('#');
            }
            return sb.ToString();
        }
        #endregion

    }
}
