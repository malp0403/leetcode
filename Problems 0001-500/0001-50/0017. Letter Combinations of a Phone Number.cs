using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0017
    {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new List<string>(){ };
            dic.Add("2",new  List<string>(){ "a","b","c"});
            dic.Add("3", new List<string>() { "d", "e", "f" });
            dic.Add("4", new List<string>() { "g", "h", "i" });
            dic.Add("5", new List<string>() { "j", "k", "l" });
            dic.Add("6", new List<string>() { "m", "n", "o" });
            dic.Add("7", new List<string>() { "p", "q", "r","s" });
            dic.Add("8", new List<string>() { "t", "u", "v" });
            dic.Add("9", new List<string>() { "w", "x", "y","z" });

            return helper(digits);

        }
        public IList<string> helper(string digits)
        {
            if (digits.Length == 1) return dic[digits];
            IList<string> list1 = helper(digits.Substring(0, 1));
            IList<string> list2 = helper(digits.Substring(1,digits.Length-1));
            IList<string> result = new List<string>() { };
            for(int i =0;i < list1.Count; i++)
            {
                for(int j = 0; j < list2.Count; j++)
                {
                    result.Add(list1[i] + list2[j]);
                }
            }
            return result;

        }
    }
}
