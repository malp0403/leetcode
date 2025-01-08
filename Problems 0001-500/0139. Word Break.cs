using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0139
    {
        #region LeetCode Approach 1: Breadth-First Search

        #endregion
        #region LeetCode Approach 2: Top-Down Dynamic Programming

        #endregion
        #region LeetCode Approach 3: Bottom-Up Dynamic Programming

        #endregion
        #region LeetCode Approach 4: Trie Optimization

        #endregion
        #region LeetCode Approach 5: A Different DP

        #endregion
        #region Solution
        //************************************************************
        Dictionary<string, bool> dic = new Dictionary<string, bool>() { };
        public bool WordBreak(string s, IList<string> wordDict)
        {

            return WordBreakHelper(s, wordDict, "");
        }

        public bool WordBreakHelper(string s, IList<string> wordDict, string temp)
        {
            if (temp.Length > s.Length) return false;

            if (dic.ContainsKey(temp)) return dic[temp];

            for (int i = 0; i < temp.Length; i++)
            {
                if (s[i] != temp[i]) return false;
            }
            if (s.Length == temp.Length) return true;

            for (int i = 0; i < wordDict.Count; i++)
            {
                if (WordBreakHelper(s, wordDict, temp + wordDict[i]))
                {
                    dic.Add(temp + wordDict[i], true);
                    return true;
                }
            }
            dic.Add(temp, false);
            return false;
        }
        //************************************************************
        HashSet<string> set = new HashSet<string>() { };
        public bool WordBreak_V2(string s, IList<string> wordDict)
        {
            foreach (var item in wordDict)
            {
                set.Add(item);
            }
            return helper_V2(s, wordDict);
        }
        public bool helper_V2(string s, IList<string> wordDict)
        {
            if (dic.ContainsKey(s)) return dic[s];
            if (s == "") return true;
            for (int i = 1; i <= s.Length; i++)
            {
                if (set.Contains(s.Substring(0, i)) && helper_V2(s.Substring(i), wordDict))
                {
                    dic.Add(s, true);
                    return true;
                }
            }
            dic.Add(s, false);
            return false;
        }
        #endregion

        #region 03/26/2024
        IList<string> list_2024_03_26;
        string s_2024_03_26;
        Dictionary<int, bool> dic_2024_03_26;
        public bool WordBreak_2024_03_26(string s, IList<string> wordDict)
        {
            list_2024_03_26 = wordDict;
            s_2024_03_26 = s;
            dic_2024_03_26 = new Dictionary<int, bool>();
            return helper_2024_03_26(0);
        }

        public bool helper_2024_03_26(int index)
        {
            if (index == s_2024_03_26.Length) return true;

            if (dic_2024_03_26.ContainsKey(index)) return dic_2024_03_26[index];

            bool valid = false;
            for(int len = 1; len+ index <=s_2024_03_26.Length ;len++)
            {
                string temp = s_2024_03_26.Substring(index, len);
                if (list_2024_03_26.Contains(temp))
                {
                    valid = valid || helper_2024_03_26(index + len);
                }
            }
            dic_2024_03_26.Add(index, valid);
            return valid;
        }
        #endregion
    }
}
