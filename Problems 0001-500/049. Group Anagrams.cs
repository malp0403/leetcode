using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> x = new List<IList<string>>() { };
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>> { };
            foreach (string s in strs)
            {
                var key = generateKey(s);
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, new List<string>() { s });
                }
                else
                {
                    dic[key].Add(s);
                }

            }
            return dic.Select(x => x.Value).ToList();
        }

        public string generateKey(string str)
        {
            string res = string.Empty;

            int[] result = Enumerable.Repeat(0, 26).ToArray();

            foreach (char a in str)
            {
                result[a - 'a']++;
            }
            for(int i =0; i < 26; i++)
            {
                res += ("#" + result[i].ToString());
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
