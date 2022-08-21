using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0093
    {
        IList<string> answer = new List<string>(){};
        public IList<string> RestoreIpAddresses(string s)
        {
            backTracking(s, 0, new List<string>() { });
            return answer;
        }
        public void backTracking(string s,int start, List<string> list)
        {
            if(list.Count ==4 && start == s.Length)
            {
                answer.Add(string.Join('.', list));
                return;
            }
            for(int i = 1; i <= 3; i++)
            {
                string sub = s.Substring(start, i);
                if (isValidString(sub))
                {
                    list.Add(sub);
                    backTracking(s, start + i, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        public bool isValidString(string s)
        {
            if (s == "") return false;
            if (s[0] == '0' && s.Length > 1) return false;
            if (int.Parse(s) >= 255) return false;
            return true;
        }
    }
}
