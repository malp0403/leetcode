using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _288
    {
        private Dictionary<string, HashSet<string>> dic;
        public _288(string[] dictionary)
        {
            dic = new Dictionary<string, HashSet<string>>();
            for (int i = 0; i < dictionary.Length; i++)
            {

                if (dictionary[i].Length > 2)
                {
                    string str = dictionary[i][0].ToString() + (dictionary[i].Length - 2).ToString() + dictionary[i][dictionary[i].Length - 1].ToString();
                    if (!dic.ContainsKey(str)) dic.Add(str, new HashSet<string>() { dictionary[i] });
                    else
                    {
                        dic[str].Add(dictionary[i]);
                    }
                }
            }
        }
        public bool IsUnique(string word)
        {
            if (String.IsNullOrEmpty(word) || word.Length <= 2) return true;
            string str = word[0].ToString() + (word.Length - 2).ToString() + word[word.Length - 1].ToString();
            if (!dic.ContainsKey(str)) return true;
            else {
                HashSet<string> set = dic[str];
                if (set.Count == 1 && set.Contains(word)) return true;
            }
            return false;
        }
    }
}
