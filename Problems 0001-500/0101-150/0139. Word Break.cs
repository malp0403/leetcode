using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0139
    {
        //************************************************************
        Dictionary<string, bool> dic = new Dictionary<string, bool>() { };
        public bool WordBreak(string s, IList<string> wordDict)
        {

            return WordBreakHelper(s, wordDict, "");
        }

        public bool WordBreakHelper(string s,IList<string> wordDict,string temp)
        {
            if (temp.Length > s.Length) return false;

            if (dic.ContainsKey(temp)) return dic[temp];

            for (int i = 0; i < temp.Length; i++)
            {
                if (s[i] != temp[i]) return false;
            }
            if(s.Length == temp.Length) return true;

            for (int i =0; i < wordDict.Count; i++)
            {
                if(WordBreakHelper(s, wordDict,temp + wordDict[i]))
                {
                    dic.Add(temp + wordDict[i],true);
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
        public bool helper_V2(string s,IList<string> wordDict)
        {
            if (dic.ContainsKey(s)) return dic[s];
            if (s == "") return true;
            for(int i =1; i <= s.Length; i++)
            {
                if (set.Contains(s.Substring(0, i)) && helper_V2(s.Substring(i), wordDict))
                {
                    dic.Add(s,true);
                    return true;
                }
            }
            dic.Add(s, false);
            return false;
        }
    }
}
