﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0017
    {


        #region  Solution
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() { };
        public IList<string> LetterCombinations_s(string digits)
        {
            if (digits.Length == 0) return new List<string>() { };
            dic.Add("2", new List<string>() { "a", "b", "c" });
            dic.Add("3", new List<string>() { "d", "e", "f" });
            dic.Add("4", new List<string>() { "g", "h", "i" });
            dic.Add("5", new List<string>() { "j", "k", "l" });
            dic.Add("6", new List<string>() { "m", "n", "o" });
            dic.Add("7", new List<string>() { "p", "q", "r", "s" });
            dic.Add("8", new List<string>() { "t", "u", "v" });
            dic.Add("9", new List<string>() { "w", "x", "y", "z" });

            return helper(digits);

        }
        public IList<string> helper(string digits)
        {
            if (digits.Length == 1) return dic[digits];
            IList<string> list1 = helper(digits.Substring(0, 1));
            IList<string> list2 = helper(digits.Substring(1, digits.Length - 1));
            IList<string> result = new List<string>() { };
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    result.Add(list1[i] + list2[j]);
                }
            }
            return result;

        }
        #endregion

        #region 01/21/2024
        IList<string> result_2024_01_21 = new List<string>();
        Dictionary<char, List<string>> dic_2024_01_21 = new Dictionary<char, List<string>>();
        public IList<string> LetterCombinations_2024_01_21(string digits)
        {
            if (digits.Length == 0) return new List<string>() { };
            dic_2024_01_21.Add('2', new List<string>() { "a", "b", "c" });
            dic_2024_01_21.Add('3', new List<string>() { "d", "e", "f" });
            dic_2024_01_21.Add('4', new List<string>() { "g", "h", "i" });
            dic_2024_01_21.Add('5', new List<string>() { "j", "k", "l" });
            dic_2024_01_21.Add('6', new List<string>() { "m", "n", "o" });
            dic_2024_01_21.Add('7', new List<string>() { "p", "q", "r", "s" });
            dic_2024_01_21.Add('8', new List<string>() { "t", "u", "v" });
            dic_2024_01_21.Add('9', new List<string>() { "w", "x", "y", "z" });
            helper_2024_01_21(0, new StringBuilder(), digits);
            return result_2024_01_21;
        }

        public void helper_2024_01_21(int index, StringBuilder sb, string s)
        {
            if (index >= s.Length)
            {
                result_2024_01_21.Add(sb.ToString());
                return;
            }
            if (s[index] == '1')
            {
                helper_2024_01_21(index + 1, sb, s);
            }
            else
            {

                foreach (var item in dic_2024_01_21[s[index]])
                {
                    sb.Append(item);
                    helper_2024_01_21(index + 1, sb, s);
                    sb.Remove(sb.Length - 1, 1);
                }
            }


        }

        #endregion

        #region 2024/09/29
        public IList<string> LetterCombinations_2024_09_29(string digits)
        {
            var result = new List<string>();

            if (digits.Length == 0) return result;
            if (digits.Length == 1) return setupDic()[digits[0]];

            List<string> list = setupDic()[digits[0]];
            IList<string> list2 = LetterCombinations_2024_09_29(digits.Substring(1));

            foreach (var item in list)
            {
                foreach (var item2 in list2)
                {
                    result.Add(item + item2);
                }
            }
            return result;

        }
        #endregion

        #region 10/07/2024
        public IList<string> LetterCombinations_2024_10_07(string digits)
        {
            var dic = setupDic();
            IList<string> ans = new List<string>();
            if (digits.Length == 0) return ans;
            if (digits.Length == 1) return dic[digits[0]];
            IList<string> list = LetterCombinations_2024_10_07(digits.Substring(1));
            List<string> list2 = dic[digits[0]];
            foreach (var item in list2)
            {
                foreach (var item2 in list)
                {
                    ans.Add(item + item2);
                }
            }

            return ans;

        }

        #endregion

        public Dictionary<char, List<string>> setupDic()
        {
            Dictionary<char, List<string>> dic = new Dictionary<char, List<string>>();

            dic.Add('2', new List<string>() { "a", "b", "c" });
            dic.Add('3', new List<string>() { "d", "e", "f" });
            dic.Add('4', new List<string>() { "g", "h", "i" });
            dic.Add('5', new List<string>() { "j", "k", "l" });
            dic.Add('6', new List<string>() { "m", "n", "o" });
            dic.Add('7', new List<string>() { "p", "q", "r", "s" });
            dic.Add('8', new List<string>() { "t", "u", "v" });
            dic.Add('9', new List<string>() { "w", "x", "y", "z" });
            return dic;
        }
    }
}
